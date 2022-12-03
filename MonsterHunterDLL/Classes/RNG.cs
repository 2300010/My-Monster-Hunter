
using System;

namespace MonsterHunterDLL
{
    public class RNG : Random
    {
        #region Instance
        //Declare instance of RNG class and initialize it to null
        private static RNG RNGinstance = null;
        #endregion

        #region Singleton
        //Getter without setter for the RNG instance
        public static RNG Get_Instance
        {
            //Permits to get the value of the instance
            get
            {
                //Verify if the instance null
                if (RNGinstance == null)
                {
                    //Initialize the instance to a new RNG object
                    RNGinstance = new RNG();
                }
                //Return the value of the instance
                return RNGinstance;
            }
        }
        #endregion
    }
}
