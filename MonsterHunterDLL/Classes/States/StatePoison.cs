
namespace MonsterHunterDLL.Classes
{
    public class StatePoison : IPlayerStates
    {
        #region Constants
        //Declare constants for stats modifier
        private const float POWER_MODIFIER = 0.5f;
        private const float DEFENSE_MODIFIER = 0.5f;
        private const int FREEZE_TIME_MODIFIER = 4;
        #endregion

        #region Singelton
        //Declare instance of poisoned state 
        private static StatePoison spStateInstance = null;

        //Declare getter without setter of instance
        public static StatePoison InstanceCreator
        {
            get
            {   //Verify is instance is null before initializing
                if (spStateInstance == null)
                {   //Initialize instance
                    spStateInstance = new StatePoison();
                }
                //Return state
                return spStateInstance;
            }
        }
        #endregion

        #region Methods
        //Implement method to adjust hunter to poison state
        public void SetHunterStats(Hunter hunter)
        {
            //Set state to poisoned
            hunter.HunterState = State.Poisoned;

            //Set freeze time with 25% increase to it's value
            hunter.FreezeTime += 
                Hunter.BASE_FREEZE_TIME / FREEZE_TIME_MODIFIER;

            //Reduce actual hp by 5
            hunter.ActualHp -= 5;
        }

        //Implement method to adjust hunter damage in combat
        public float CalculateDamage(Hunter hunter, int swordDmg)
        {   //Divide damage output in half
            return (hunter.Power + swordDmg) * POWER_MODIFIER;
        }

        //Implement method to adjust hunter fDefense in combat
        public float CalculateDefense(Hunter hunter, int shieldDefense)
        {   //Divide fDefense output in half
            return (hunter.Defense + shieldDefense) * DEFENSE_MODIFIER;
            
        }
        #endregion
    }
}
