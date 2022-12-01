
namespace MonsterHunterDLL.Classes
{
    public class Sword
    {
        #region Constants
        //Declare constants for maxPower and minPower
        public const int MAX_POWER = 10;
        public const int MIN_POWER = 4;

        //Declare constants for the the RNG
        public const int ODDS = 6;
        #endregion

        //Declare variable and initialize to 0
        private int power = 0;

        //Declare constructor for sword
        public Sword(int power)
        {
            //Set sword power to the RNG number while creating
            this.power = power;
        }

        //Getter and setter for the sword power value
        public int Power 
        {
            //Permits to get the value of the power
            get
            {
                //Return the power value
                return power; 
            }
        }

        //Function to determine if sword is broken
        public bool IsBroken(int oneInFive)
        {
            //Verify if the RNG is 1
            if (oneInFive == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
