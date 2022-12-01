
namespace MonsterHunterDLL.Classes
{
    public class Axe
    {
        //Declare constants for the the RNG
        const int ODDS = 3;

        //Function to determine if axe is broken
        public bool IsBroken(int oneInThree)
        {
            //Verify if the RNG is 1
            if (oneInThree == 1)
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
