
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
        private int freezeTime = 0;

        //Declare variables for character position
        private int positionX = 0;
        private int positionY = 0;

        //Declare variables for character max position
        private int maxPositionX = 0;
        private int maxPositionY = 0;
        #endregion

        #region Stats Properties
        //Declare variables for character stats
        private float actualHp = 0f;
        private float power = 0f;
        private float defense = 0f;
        #endregion

        #region Constructors
        //Declare constructor to force two variables on creation
        protected Characters(int positionX, int positionY)
        {
            this.positionX = positionX;
            this.positionY = positionY;
        }
        
        //Declare constructor to access 2 more variables if necessary
        protected Characters(int positionX, int positionY, int maxPositionX, int maxPositionY)
        {
            this.maxPositionX = maxPositionX;
            this.maxPositionY = maxPositionY;
            this.positionX = positionX;
            this.positionY = positionY;
        }
        #endregion

        #region Getters/Setters
        //Declare getter and setter for positionX
        public int PositionX 
        { 
            get => positionX; 
            set
            {   //Verify if position is out of bounds of screen
                if (value < 0)
                {
                    //Set position back to 0
                    positionX = 0;
                }//Verify if position is out of bounds of the map
                else if (value > maxPositionX)
                {   //Set position back to bounds of map
                    positionX = maxPositionX;
                }
                else 
                {   //Set position to the new value 
                    positionX = value; 
                }
            }
                 
        }

        //Declare getter and setter for positionY
        public int PositionY 
        { 
            get => positionY; 
            set
            {   //Verify if position is out of bounds of screen
                if (value < 0)
                {   //Set position back to 0
                    positionY = 0;
                }//Verify if position is out of bounds of the map
                else if (value > maxPositionY)
                {   //Set position back to bounds of map
                    positionY = maxPositionY;
                }
                else
                {   //Set position to the new value
                    positionY = value;
                }
            }
        }

        //Declare getter and setter for actualHp
        public float ActualHp 
        { 
            get => actualHp;
            set 
            {   //Verify if value is higher than maxHp
                if (value > MAX_HP)
                {   //Set actualHp back to maxHp
                    actualHp = MAX_HP;
                }
                else
                {   //Set actualHp to new value
                    actualHp = value;
                }
            }  
        }

        //Declare getter and setter for power
        public float Power 
        { 
            get => power; 
            set
            {   //Verify if value is lower than 0
                if (value < 0)
                {   //Set power back to 0
                    power = 0;
                }//Verify if value is higher than max power
                else if (value > MAX_POWER)
                {   //Set power back to max power
                    power = MAX_POWER;
                }
                else
                {   //Set power to new value
                    power = value;
                }
            } 
        }

        //Declare getter and setter for defense
        public float Defense 
        { 
            get => defense; 
            set
            {   //Verify if value is lower than 0
                if (value < 0)
                {   //Set defense back to 0
                    defense = 0;
                }//Verify if value is higher than max defense
                else if (value > MAX_DEFENSE)
                {   //Set defense back to max defense
                    defense = MAX_DEFENSE;
                }
                else
                {   //Set defense to new value
                    defense = value;
                }
            } 
        }

        public int FreezeTime { get => freezeTime; set => freezeTime = value; }
        #endregion

        #region Methods
        //Declare abstract method to verify futur position
        public abstract bool CollisionDetector(int X, int Y);

        //Declare mehtod to verify if character is dead
        public bool IsDead()
        {
            if (this.actualHp <= 0)
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
