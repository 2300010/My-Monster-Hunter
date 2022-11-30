
namespace MonsterHunterDLL.Classes
{
    public class Axe
    {
        //Function to determine if axe is broken
        public bool IsBroken()
        {
            //Declare constants for the the RNG
            const int chances = 3;

            //Declare variable to receive the 1 in 5 RNG
            int oneInFive = RNG.Get_Instance.Next(1, chances);

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
