
namespace MonsterHunterDLL.Classes
{
    public class StateNormal : IPlayerStates
    {
        #region Singelton
        //Declare instance of normal state 
        private static StateNormal _n_state_instance = null;

        //Declare getter without setter of instance
        public static StateNormal InstanceCreator
        {
            get
            {   //Verify is instance is null before initializing
                if (_n_state_instance == null)
                {   //Initialize instance
                    _n_state_instance = new StateNormal();
                }
                //Return state
                return _n_state_instance;
            }
        }
        #endregion

        #region Methods
        //Implement method to adjust hunter to normal state
        public void SetHunterStats(Hunter hunter)
        {
            //Set state to normal
            hunter.HunterState = State.Normal;

            //Set freeze time to base value
            hunter.FreezeTime = Hunter.BASE_FREEZE_TIME;
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
