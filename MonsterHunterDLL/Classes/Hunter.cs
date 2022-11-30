using System;

namespace MonsterHunterDLL.Classes
{
    public class Hunter : Characters
    {
        //Declare constant for the maximum score
        private const int MAX_SCORE = 100000;

        //Declare variable for hunter
        private string name = "";
        private int score = 0;
        private string state = "";

        #region Getter/Setter
        //Declare getter and setter for name
        public string Name
        {
            get => name;
            set
            {   //Verify if length of the name is more than 20 characters
                if (value.Length > 20)
                {   //Set name back at 0 character
                    name = "";
                }
                else
                {   //Set name to new value
                    name = value;
                }
            }
        }

        //Declare getter and setter for score
        public int Score
        {
            get => score;
            set
            {   //Verify if value is higher than max score
                if (value > MAX_SCORE)
                {   //Set score back to maximum score
                    score = MAX_SCORE;
                }//Verify if value is lower than 0
                else if (value < 0)
                {   //Set score back to 0
                    score = 0;
                }
                else
                {   //Set score to new value
                    score = value;
                }
            }
        }
        #endregion

        //Declare constructor for the hunter
        public Hunter(int positionX, int positionY) : base(positionX, positionY)
        {   
            //Set freeze time to 1 second on creation
            this.freezeTime = 1;

            //Set state to normal on creation
            this.state = "Normal";
        }

        #region Methods
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

        //Delcare method to move the hunter
        public void MoveHunter(ConsoleKeyInfo playerMouvement)
        {
            //Mouvement manager
            switch (playerMouvement.Key)
            {   //Key to move up is pressed
                case ConsoleKey.W:
                    {
                        //Reduce player's Y coordinate by 1
                        PositionY--;
                    }
                    break;
                //Key to move down is pressed
                case ConsoleKey.S:
                    {   //Increase player's Y coordinate by 1
                        PositionY++; 
                    }
                    break;
                //Key to move left is pressed
                case ConsoleKey.A:
                    {   //Reduce player's X coordinate by 1
                        PositionX--; 
                    }
                    break;
                //Key to move right is pressed
                case ConsoleKey.D:
                    {   //Increase player's X coordinate by 1
                        PositionX++; 
                    }
                    break;
            }
        }
        #endregion
    }
}
