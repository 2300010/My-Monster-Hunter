
namespace MonsterHunterDLL.Classes
{
    public class Monster : Characters
    {
        //Declare construtor for monsters
        public Monster(int positionX, int positionY) : base(positionX, positionY)
        {
            //Set freeze time to 2 seconds on creation
            this.freezeTime = 2;
        }

        //Override of abstract method to verify if movement is valid
        public override bool NextPositionOccupied(int X, int Y)
        {
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
                if (!NextPositionOccupied(PositionX, PositionY))
                {
                    PositionY--;
                }
                
            }
            else if (direction == 2)
            {
                PositionY++;
            }
            else if (direction == 3)
            {
                PositionX--;
            }
            else
            {
                PositionX++;
            }
        }
    }
}
