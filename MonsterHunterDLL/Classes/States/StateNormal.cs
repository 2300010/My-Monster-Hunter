
namespace MonsterHunterDLL.Classes
{
    public class StateNormal : IPlayerStates
    {
        #region Singelton
        //Declare instance of normal state 
        private static StateNormal snStateInstance = null;

        //Declare getter without setter of instance
        public static StateNormal InstanceCreator
        {
            get
            {   //Verify is instance is null before initializing
                if (snStateInstance == null)
                {   //Initialize instance
                    snStateInstance = new StateNormal();
                }
                //Return state
                return snStateInstance;
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

        //Implement method to adjust hunter fDefense in combat
        public float CalculateDefense(Hunter hunter, int shieldDefense)
        {   //Normal fDefense ouput
            return (hunter.Defense + shieldDefense);
        }
        #endregion
    }
}
