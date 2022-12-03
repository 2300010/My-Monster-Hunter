
namespace MonsterHunterDLL
{
    public abstract class Characters
    {
        #region Constants
        //Declare constants to limit stats
        public const float MAX_POWER = 7f;
        public const float MAX_DEFENSE = 4f;
        public const float MAX_HP = 30f;
        #endregion

        #region Mouvement Stats
        //Declare variable for the freeze time when moving
        private int iFreezeTime = 0;

        //Declare variables for character position
        private int iPositionX = 0;
        private int iPositionY = 0;

        //Declare variables for character max position
        private int iMaxPositionX = 0;
        private int iMaxPositionY = 0;
        #endregion

        #region Stats Properties
        //Declare variables for character stats
        private float fActualHp = 0f;
        private float fPower = 0f;
        private float fDefense = 0f;
        #endregion

        #region Constructors
        //Declare constructor to force two variables on creation
        protected Characters(int piPositionX, int piPositionY)
        {
            this.iPositionX = piPositionX;
            this.iPositionY = piPositionY;
        }
        
        //Declare constructor to access 2 more variables if necessary
        protected Characters(int piPositionX, int piPositionY, int piMaxPositionX, int piMaxPositionY)
        {
            this.iMaxPositionX = piMaxPositionX;
            this.iMaxPositionY = piMaxPositionY;
            this.iPositionX = piPositionX;
            this.iPositionY = piPositionY;
        }
        #endregion

        #region Getters/Setters
        //Declare getter and setter for iPositionX
        public int PositionX 
        { 
            get => iPositionX; 
            set
            {   //Verify if position is out of bounds of screen
                if (value < 0)
                {
                    //Set position back to 0
                    iPositionX = 0;
                }//Verify if position is out of bounds of the map
                else if (value > iMaxPositionX)
                {   //Set position back to bounds of map
                    iPositionX = iMaxPositionX;
                }
                else 
                {   //Set position to the new value 
                    iPositionX = value; 
                }
            }
                 
        }

        //Declare getter and setter for iPositionY
        public int PositionY 
        { 
            get => iPositionY; 
            set
            {   //Verify if position is out of bounds of screen
                if (value < 0)
                {   //Set position back to 0
                    iPositionY = 0;
                }//Verify if position is out of bounds of the map
                else if (value > iMaxPositionY)
                {   //Set position back to bounds of map
                    iPositionY = iMaxPositionY;
                }
                else
                {   //Set position to the new value
                    iPositionY = value;
                }
            }
        }

        //Declare getter and setter for fActualHp
        public float ActualHp 
        { 
            get => fActualHp;
            set 
            {   //Verify if value is higher than maxHp
                if (value > MAX_HP)
                {   //Set fActualHp back to maxHp
                    fActualHp = MAX_HP;
                }
                else
                {   //Set fActualHp to new value
                    fActualHp = value;
                }
            }  
        }

        //Declare getter and setter for fPower
        public float Power 
        { 
            get => fPower; 
            set
            {   //Verify if value is lower than 0
                if (value < 0)
                {   //Set fPower back to 0
                    fPower = 0;
                }//Verify if value is higher than max fPower
                else if (value > MAX_POWER)
                {   //Set fPower back to max fPower
                    fPower = MAX_POWER;
                }
                else
                {   //Set fPower to new value
                    fPower = value;
                }
            } 
        }

        //Declare getter and setter for fDefense
        public float Defense 
        { 
            get => fDefense; 
            set
            {   //Verify if value is lower than 0
                if (value < 0)
                {   //Set fDefense back to 0
                    fDefense = 0;
                }//Verify if value is higher than max fDefense
                else if (value > MAX_DEFENSE)
                {   //Set fDefense back to max fDefense
                    fDefense = MAX_DEFENSE;
                }
                else
                {   //Set fDefense to new value
                    fDefense = value;
                }
            } 
        }

        public int FreezeTime { get => iFreezeTime; set => iFreezeTime = value; }
        #endregion

        #region Methods
        //Declare abstract method to verify futur position
        public abstract bool CollisionDetector(int X, int Y);

        //Declare mehtod to verify if character is dead
        public bool IsDead()
        {
            if (this.fActualHp <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion
    }
}
