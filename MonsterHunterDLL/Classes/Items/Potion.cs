
namespace MonsterHunterDLL.Classes
{
    public class Potion
    {
        #region PotionType
        //Declare variable to recieve type
        public eType potionType;
        #endregion

        #region Constant
        //Declare constants for maxRoll
        public const int ODDS = 7;
        #endregion

        #region Constructor
        //Declare constructor for potion
        public Potion(int piOddsInSix)
        {
            //Set the potion type on creation
            potionType = GetPotionType(piOddsInSix);
        }
        #endregion

        #region Enum
        //Declare enum for potion types
        public enum eType
        {
            Power,
            Poison,
            Invisibility,
            Speed
        }
        #endregion

        #region Method
        //Function to determine which type the potion is
        public eType GetPotionType(int oddsInSix)
        {
            //Declare a variable to return potion type
            eType newPotionType;

            //Verify if the RNG resulted in 1
            if (oddsInSix == 1)
            {
                //Set the potion type to poison
                newPotionType = eType.Poison;
            }//Verify if the RNG resulted in 2 or 3
            else if (oddsInSix == 2 || oddsInSix == 3)
            {
                //Set the potion type to speed
                newPotionType = eType.Speed;
            }//Verify if the RNG resulted in 4 or 5
            else if (oddsInSix == 4 || oddsInSix == 5)
            {
                //Set the potion type to invisibility
                newPotionType = eType.Invisibility;
            }//Verify if the RNG resulted in 6
            else
            {
                //Set the potion type to fPower
                newPotionType = eType.Power;
            }
            
            //Return 
            return newPotionType;
        }
        #endregion
    }
}
