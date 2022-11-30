
namespace MonsterHunterDLL.Classes
{
    public class Potion
    {
        //Declare variable to recieve type
        public Type potionType;

        //Declare constants for maxRoll
        public const int ODDS = 7;

        //Declare constructor for potion
        public Potion(int oddsInSix)
        {
            //Set the potion type on creation
            potionType = GetPotionType(oddsInSix);
        }

        //Declare enum for potion types
        public enum Type
        {
            Power,
            Poison,
            Invisibility,
            Speed
        }

        //Function to determine which type the potion is
        public Type GetPotionType(int oddsInSix)
        {
            //Declare a variable to return potion type
            Type newPotionType;

            //Verify if the RNG resulted in 1
            if (oddsInSix == 1)
            {
                //Set the potion type to poison
                newPotionType = Type.Poison;
            }//Verify if the RNG resulted in 2 or 3
            else if (oddsInSix == 2 || oddsInSix == 3)
            {
                //Set the potion type to speed
                newPotionType = Type.Speed;
            }//Verify if the RNG resulted in 4 or 5
            else if (oddsInSix == 4 || oddsInSix == 5)
            {
                //Set the potion type to invisibility
                newPotionType = Type.Invisibility;
            }//Verify if the RNG resulted in 6
            else
            {
                //Set the potion type to power
                newPotionType = Type.Power;
            }
            
            //Return 
            return newPotionType;
        }
    }
}
