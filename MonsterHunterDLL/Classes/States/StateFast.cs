
namespace MonsterHunterDLL.Classes.States
{
    public class StateFast : IPlayerStates
    {
        //Declare constants for modifier
        private const int FREEZE_TIME_MODIFIER = 2;

        #region Singelton
        //Declare instance of fast state 
        private static StateFast _f_state_instance = null;

        //Declare getter without setter of instance
        public static StateFast InstanceCreator
        {
            get
            {   //Verify is instance is null before initializing
                if (_f_state_instance == null)
                {   //Initialize instance
                    _f_state_instance = new StateFast();
                }
                //Return state
                return _f_state_instance;
            }
        }
        #endregion

        #region Methods
        //Implement method to adjust hunter to fast state
        public void SetHunterStats(Hunter hunter)
        {
            //Set state to fast
            hunter.HunterState = State.Fast;

            //Set freeze time to half it's value
            hunter.FreezeTime -= hunter.FreezeTime / FREEZE_TIME_MODIFIER;
        }

        //Implement method to adjust hunter damage in combat
        public float CalculateDamage(Hunter hunter, int swordDmg)
        {   //Normal damage output
            return (hunter.Power + swordDmg);
        }

        //Implement method to adjust hunter defense in combat
        public float CalculateDefense(Hunter hunter, int shieldDefense)
        {   //Normal defense ouput
            return (hunter.Defense + shieldDefense);
        }
        #endregion
    }
}
