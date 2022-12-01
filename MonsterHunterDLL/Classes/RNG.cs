
using System;

namespace MonsterHunterDLL
{
    public class RNG : Random
    {
        //Declare instance of RNG class and initialize it to null
        private static RNG _instance = null;

        #region Singleton
        //Getter without setter for the RNG instance
        public static RNG Get_Instance
        {
            //Permits to get the value of the instance
            get
            {
                //Verify if the instance null
                if (_instance == null)
                {
                    //Initialize the instance to a new RNG object
                    _instance = new RNG();
                }
                //Return the value of the instance
                return _instance;
            }
        }
        #endregion
    }
}
