using System;

namespace MonsterHunterDLL.Classes
{
    #region Enum State
    //Declare enum to access every state from hunter class
    public enum State
    {
        Normal,
        Strong,
        Poisoned,
        Invisible,
        Fast
    }
    #endregion

    public class Hunter : Characters
    {
        #region Constants MAX
        //Declare constant for the max value/length & base value
        private const int MAX_SCORE = 100000;
        public const int MAX_NAME_LENGTH = 20;
        public const int BASE_FREEZE_TIME = 1000;
        #endregion

        #region Hunter Variables
        //Declare variable for hunter
        private string name = "";
        private int score = 0;
        private State hunterState;
        #endregion

        #region Getter/Setter
        //Declare getter and setter for name
        public string Name
        {
            get => name;
            set
            {   //Verify if length of the name is more than 20 characters
                if (value.Length > MAX_NAME_LENGTH)
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

        //Declare getter and setter for state
        public State HunterState { get => hunterState; set => hunterState = value; }
        #endregion

        #region Constructor
        //Declare constructor for the hunter
        public Hunter(int positionX, int positionY) : base(positionX, positionY)
        {   //Initialize freeze time
            this.FreezeTime = BASE_FREEZE_TIME;
        }
        #endregion

        #region Methods
        //Override of abstract method to verify if movement is valid
        public override bool CollisionDetector(int X, int Y)
        {
            //Declare temporary map to search for obstacles
            Maps tempMap = new Maps();

            //if ()
            return false;
            

        }

        //Delcare method to move the hunter
        public void MoveHunter(ConsoleKeyInfo playerMouvement, string selectedMap)
        {
            //Declare 

            //Mouvement manager
            switch (playerMouvement.Key)
            {   //Key to move up is pressed
                case ConsoleKey.W:
                    {
                        //Verify if there is something in futur position
                        if (!CollisionDetector(PositionX, PositionY - 1))
                        {
                            //Reduce player's Y coordinate by 1
                            PositionY--;
                        }
                    }
                    break;
                //Key to move down is pressed
                case ConsoleKey.S:
                    {
                        //Verify if there is something in futur position
                        if (!CollisionDetector(PositionX, PositionY))
                        {
                            //Increase player's Y coordinate by 1
                            PositionY++;
                        }
                    }
                    break;
                //Key to move left is pressed
                case ConsoleKey.A:
                    {
                        //Verify if there is something in futur position
                        if (!CollisionDetector(PositionX, PositionY))
                        {
                            //Reduce player's X coordinate by 1
                            PositionX--;
                        }
                    }
                    break;
                //Key to move right is pressed
                case ConsoleKey.D:
                    {
                        //Verify if there is something in futur position
                        if (!CollisionDetector(PositionX, PositionY))
                        {
                            //Increase player's X coordinate by 1
                            PositionX++;
                        }
                    }
                    break;
            }
        }
        #endregion
    }
}
