
namespace MonsterHunterDLL.Classes
{
    public class StateInvisiblity : IPlayerStates
    {
        #region Singelton
        //Declare instance of invisible state 
        private static StateInvisiblity _i_state_instance = null;

        //Declare getter without setter of instance
        public static StateInvisiblity InstanceCreator
        {
            get
            {   //Verify is instance is null before initializing
                if (_i_state_instance == null)
                {   //Initialize instance
                    _i_state_instance = new StateInvisiblity();
                }
                //Return state
                return _i_state_instance;
            }
        }
        #endregion

        #region Methods
        //Implement method to adjust hunter to invisible state
        public void SetHunterStats(Hunter hunter)
        {   //Set state to invisible
            hunter.HunterState = State.Invisible;
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
