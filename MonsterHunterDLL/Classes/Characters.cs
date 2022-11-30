
namespace MonsterHunterDLL
{
    public abstract class Characters
    {
        //Declare constants to limit stats
        protected const int MAX_POWER = 7;
        protected const int MAX_DEFENSE = 4;

        //Declare variables for character position
        private int positionX = 0;
        private int positionY = 0;

        //Declare variables for character max position
        private int maxPositionX = 0;
        private int maxPositionY = 0;

        //Declare variables for character stats
        #region Stats Properties
        protected int maxHp = 30;
        private int actualHp = 0;
        private int power = 0;
        private int defense = 0;
        #endregion

        //Declare variable for the freeze time when moving
        protected int freezeTime = 0;

        protected Characters(int positionX, int positionY)
        {
            this.positionX = positionX;
            this.positionY = positionY;
        }

        //protected Characters(int positionX, int positionY, int maxPositionX, int maxPositionY)
        //{
        //    this.maxPositionX = maxPositionX;
        //    this.maxPositionY = maxPositionY;
        //    this.positionX = positionX;
        //    this.positionY = positionY;
        //}


        #region Getters/Setters
        //Declare getter and setter for positionX
        protected int PositionX 
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
        protected int PositionY 
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
        protected int ActualHp 
        { 
            get => actualHp;
            set 
            {   //Verify if value is higher than maxHp
                if (value > maxHp)
                {   //Set actualHp back to maxHp
                    actualHp = maxHp;
                }
                else
                {   //Set actualHp to new value
                    actualHp = value;
                }
            }  
        }

        //Declare getter and setter for power
        protected int Power 
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
        protected int Defense 
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
        #endregion

        #region Methods
        //Declare abstract method to verify futur position
        public abstract bool NextPositionOccupied(int X, int Y);

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
