
namespace MonsterHunterDLL.Classes
{
    public class Shield
    {
        //Declare constants for maxDefense and minDefense
        public const int MAX_DEFENSE = 7;
        public const int MIN_DEFENSE = 3;

        //Declare constants for the the RNG
        const int ODDS = 5;

        //Declare variable and initialize to 0
        private int defense = 0;

        //Declare constructor for shield
        public Shield(int defense)
        {
            //Set sword defense to the RNG number while creating
            this.defense = defense;
        }

        //Getter and setter for the shield defense value
        public int Defense
        {
            //Permits to get the value of the defense
            get
            {
                //Return the defense value
                return defense;
            }
        }

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
    }
}
