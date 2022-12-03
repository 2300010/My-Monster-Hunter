
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

        #region Power Variable
        //Declare variable and initialize to 0
        private int power = 0;
        #endregion

        #region Constructor
        //Declare constructor for sword
        public Sword(int power)
        {
            //Set sword fPower to the RNG number while creating
            this.power = power;
        }
        #endregion

        #region Getter/Setter
        //Getter and setter for the sword fPower value
        public int Power 
        {
            //Permits to get the value of the fPower
            get
            {
                //Return the fPower value
                return power; 
            }
        }
        #endregion

        #region Method
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
        #endregion
    }
}
