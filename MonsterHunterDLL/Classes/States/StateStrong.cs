
namespace MonsterHunterDLL.Classes
{
    public class StateStrong : IPlayerStates
    {
        #region Constants
        //Declare constants for stats modifier
        private const int POWER_MODIFIER = 2;
        private const float DEFENSE_MODIFIER = 1.5f;
        #endregion

        #region Singelton
        //Declare instance of strong state 
        private static StateStrong _s_state_instance = null;

        //Declare getter without setter of instance
        public static StateStrong InstanceCreator
        {
            get
            {   //Verify is instance is null before initializing
                if (_s_state_instance == null)
                {   //Initialize instance
                    _s_state_instance = new StateStrong();
                }
                //Return state
                return _s_state_instance;
            }
        }
        #endregion

        #region Methods
        //Implement method to adjust hunter to strong state
        public void SetHunterStats(Hunter hunter)
        {
            //Set state to Strong
            hunter.HunterState = State.Strong;

            //Set actual hp to max hp
            hunter.ActualHp = Characters.MAX_HP;
        }

        //Implement method to adjust hunter damage in combat
        public float CalculateDamage(Hunter hunter, int swordDmg)
        {   //Double damage output
            return (hunter.Power + swordDmg) * POWER_MODIFIER;
        }

        //Implement method to adjust hunter defense in combat
        public float CalculateDefense(Hunter hunter, int shieldDefense)
        {   //Multiply defense output by 1.5
            return (hunter.Defense + shieldDefense) * DEFENSE_MODIFIER;
        }
        #endregion
    }
}
