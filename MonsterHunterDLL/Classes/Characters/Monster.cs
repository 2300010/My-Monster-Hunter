
namespace MonsterHunterDLL.Classes
{
    public class Monster : Characters
    {
        #region Constructor
        //Declare construtor for monsters
        public Monster(int positionX, int positionY) : base(positionX, positionY)
        {
            //Set freeze time to 2 seconds on creation
            this.FreezeTime = 2000;
        }
        #endregion

        #region Methods
        //Override of abstract method to verify if movement is valid
        public override bool CollisionDetector(int X, int Y)
        {   //Verify if 
            if (PositionX + 1 == X || PositionY + 1 == Y)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Delcare method to move the monsters
        public void MoveMonster(int direction)
        {
            if (direction == 1)
            {
                if (!CollisionDetector(PositionX, PositionY))
                {
                    PositionY--;
                }
                
            }
            else if (direction == 2)
            {
                if (!CollisionDetector(PositionX, PositionY))
                {
                    PositionY++;
                }
            }
            else if (direction == 3)
            {
                if (!CollisionDetector(PositionX, PositionY))
                {
                    PositionX--;
                }
            }
            else
            {
                if (!CollisionDetector(PositionX, PositionY))
                {
                    PositionX++;
                }
            }
        }
        #endregion
    }
}
