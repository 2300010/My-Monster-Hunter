using MonsterHunterDLL.Classes;
using System;
using System.Collections.Generic;
using System.IO;

namespace MonsterHunterDLL
{
    public class Maps
    {
        #region Contants
        //Declare constants for maps limits
        private const int MAX_MAP_HEIGHT = 20;
        private const int MAX_MAP_WIDTH = 70;

        //Declare constants for files
        private const string MAPS_PATH = @".\\..\\..\\..\\MonsterHunterDLL\\bin\\Debug\\Maps\\";
        private const string MAP_EXT = "*.map";
        #endregion

        #region Proprieties
        //Declare variables for maps 
        private int iMapHeight = 0;
        private int iMapWidth = 0;
        #endregion

        #region Arrays
        //Declare array to receive names of the maps
        private string[] mapNameList = Directory.GetFiles(MAPS_PATH, MAP_EXT);

        //Declare jagged array to receive maps
        public char[][] selectedMapContent = new char[0][];

        //Declare array for temporary map list
        public string[] maps = new string[3];
        #endregion

        #region Getter/Setter
        //Declare getter and setter for map height
        public int IMapHeight 
        { 
            get { return iMapHeight; } 
            set 
            {   //Verify if map height is not bigger than the limit
                if (iMapHeight <= MAX_MAP_HEIGHT || iMapHeight >= 0)
                {   //Set map height to new value
                    iMapHeight = value;
                }
                else
                {   //Set map height back to 0
                    iMapHeight = 0;
                }
            } 
        }

        //Declare getter and setter for map height
        public int IMapWidth 
        { 
            get => iMapWidth; 
            set
            {
                //Verify if map height is not bigger than the limit
                if (iMapWidth <= MAX_MAP_WIDTH || iMapWidth >= 0)
                {   //Set map height to new value
                    iMapWidth = value;
                }
                else
                {   //Set map height back to 0
                    iMapWidth = 0;
                }
            }
        }

        //Declare getter and setter for map name list
        public string[] MapNameList { get => mapNameList; private set => mapNameList = value; }
        #endregion

        #region Constructor
        //Declare Constructor
        public Maps()
        {
            //Declare variable
            int mapCount = 0;

            //Check for every map folder
            foreach (string map in mapNameList)
            {   //Put maps found in an array
                maps[mapCount] = map.Substring(51);

                //Increment map count
                mapCount++;
            }
        }
        #endregion

        #region Methods
        //Method to load the chosen map
        public void LoadMap
            (string psMapName, Hunter pHcurrentHunter, List<Monster> pLMonsters)
        {
            //On map reload, reset value of width and height
            IMapWidth = 0;
            IMapHeight = 0;

            //Declare temporary variables to receive hunter and pLMonsters position
            int monstersCreated = 0;

            //Loop to find every character in map file
            foreach (string stringLine in File.ReadLines($"{MAPS_PATH}{psMapName}"))
            {
                //Convert string line in temporary char array
                char[] lineOfChar = stringLine.ToCharArray();

                foreach (char character in lineOfChar)
                {
                    //Resize jagged array of map content
                    Array.Resize(ref selectedMapContent, selectedMapContent.Length + 1);

                    //Add string line in jagged array
                    selectedMapContent[selectedMapContent.GetUpperBound(0)] = lineOfChar;

                    //Verify if character is the hunter
                    if (character == 'H')
                    {   //Set pHcurrentHunter position
                        pHcurrentHunter.PositionY = iMapHeight;
                        pHcurrentHunter.PositionX = selectedMapContent.Length;

                        //Clear hunter position
                        selectedMapContent[pHcurrentHunter.PositionY][pHcurrentHunter.PositionX] = ' ';
                    }   //Verify if character is the hunter
                    else if (character == 'M')
                    {   //Add monster to monster list
                        pLMonsters.Add(new Monster(selectedMapContent.Length, IMapHeight));

                        //Set position of new monster
                        pLMonsters[monstersCreated].PositionY = iMapHeight;
                        pLMonsters[monstersCreated].PositionX = selectedMapContent.Length;

                        //Clear monster position
                        selectedMapContent[pLMonsters[monstersCreated].PositionY]
                            [pLMonsters[monstersCreated].PositionX] = ' ';

                        //Increment monstersCreated
                        monstersCreated++;
                    }

                    //Adjust map width with jagged array length
                    IMapWidth = selectedMapContent.Length;
                }

                //Adjust map height for each line in map
                IMapHeight++;
            }
        }

        //Function to draw map
        public void DrawMap()
        {
            try
            {

            }
            catch (Exception ex)
            {
                Exception_Manager.errorManager(ex,
                        System.Reflection.MethodBase.GetCurrentMethod().Name);
            }
            for (int y = 0; y < selectedMapContent.GetLength(0); y++)
            {
                for (int x = 0; x < selectedMapContent.GetLength(1); x++)
                {
                    //Draw character at position y and x
                    Console.Write(selectedMapContent[y][x]);
                }

                //Skip a line to draw next line of map
                Console.WriteLine();
            }
        }
        #endregion
    }
}
