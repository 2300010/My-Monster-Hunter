
namespace MonsterHunterDLL.Classes
{
    public class Axe
    {
        #region Constants
        //Declare constants for the the RNG
        const int ODDS = 3;
        #endregion

        #region Method
        //Function to determine if axe is broken
        public bool IsBroken(int piOneInThree)
        {
            //Verify if the RNG is 1
            if (piOneInThree == 1)
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
