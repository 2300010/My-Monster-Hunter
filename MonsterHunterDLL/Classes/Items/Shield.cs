
namespace MonsterHunterDLL.Classes
{
    public class Shield
    {
        #region Constants
        //Declare constants for maxDefense and minDefense
        public const int MAX_DEFENSE = 7;
        public const int MIN_DEFENSE = 3;

        //Declare constants for the the RNG
        public const int ODDS = 5;
        #endregion

        #region Variable
        //Declare variable and initialize to 0
        private int defense = 0;
        #endregion

        #region Constructor
        //Declare constructor for shield
        public Shield(int defense)
        {
            //Set sword fDefense to the RNG number while creating
            this.defense = defense;
        }
        #endregion

        #region Getter/Setter
        //Getter and setter for the shield fDefense value
        public int Defense
        {
            //Permits to get the value of the fDefense
            get
            {
                //Return the fDefense value
                return defense;
            }
        }
        #endregion

        #region Method
        //Function to determine if shield is broken
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
