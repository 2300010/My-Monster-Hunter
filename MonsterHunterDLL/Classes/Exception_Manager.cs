using System;
using System.IO;

namespace MonsterHunterDLL.Classes
{
    public static class Exception_Manager
    {
        //Declare constant for error message text file path
        const string TXT_FILE_PATH = "ErrorMessage.txt";

        //Declare constant for
        const bool DEBUG_MODE = true;

        //Function to manage catched errors
        public static void errorManager(Exception exception, string sFunctionName)
        {
            try
            {
                //Generate detailed error
                string sDetailledError = DateTime.Now + "|Une erreur s'est produite dans la fonction "
                    + sFunctionName + " :"
                    + exception.Message;

                //If debug mode is true
                if (DEBUG_MODE)
                {   //Show detailed error on screen
                    Console.WriteLine(sDetailledError);
                }

                //Open error text file
                StreamWriter writer = new StreamWriter(TXT_FILE_PATH, true);

                //Write in error text file
                writer.WriteLine(sDetailledError);

                //Close the error text file
                writer.Close();

                //Warn the user that there is an error
                Console.WriteLine("Une erreur est survenue.");

                //Wait for user input so user can read error message
                Console.ReadKey();
            }
            catch (Exception myException)
            {
                //Call error manager to manage catched errors
                errorManager(myException, System.Reflection.MethodBase.GetCurrentMethod().Name);
            }
        }

    }
}
