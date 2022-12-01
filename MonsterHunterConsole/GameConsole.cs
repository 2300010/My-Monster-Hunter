using MonsterHunterDLL;
using MonsterHunterDLL.Classes;
using System;

namespace MonsterHunterConsole
{
    public class GameConsole
    {
        static void Main(string[] args)
        {
            string userEntry = "";
            try
            {
                
                while (userEntry != "q")
                {
                    //Potion newPotion =
                    //    new Potion(RNG.Get_Instance.Next(1, Potion.ODDS));

                    //Shield newShield = 
                    //    new Shield(RNG.Get_Instance.Next(Shield.MIN_DEFENSE, Shield.MAX_DEFENSE));

                    //Sword newSword = 
                    //    new Sword(RNG.Get_Instance.Next(Sword.MIN_POWER, Sword.MAX_POWER));

                    //Console.WriteLine("Sword Power = " + newSword.Power);
                    //Console.WriteLine("Shield defense = " + newShield.Defense);
                    //Console.WriteLine("Potion type = " + newPotion.potionType);



                    Console.ReadKey();
                    
                } 
                
            }
            catch (Exception myException)
            {
                //Call error manager to manage catched errors
                Exception_Manager.errorManager(myException, 
                    System.Reflection.MethodBase.GetCurrentMethod().Name);
            }
        }

        //public void DrawAfterMouvement(int x, int y)
        //{
        //    try
        //    {
        //        Console.SetCursorPosition(x, y); //Set the cursor to player's position
        //        Console.Write(" "); //Erase player for old position
        //    }
        //    catch
        //    {

        //    }
        //}
    }
}
