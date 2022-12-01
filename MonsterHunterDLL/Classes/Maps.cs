
namespace MonsterHunterDLL
{
    public class Maps
    {
        //Declare constants for maps limits
        private const int MAX_MAP_HEIGHT = 20;
        private const int MAX_MAP_WIDTH = 70;

        //Declare variables for maps 
        private int mapHeight = 0;
        private int mapWidth = 0;

        //Declare array to receive names of the maps
        private string[] mapNameList;

        //Declare jagged array to receive maps
        public string[][] mapsList;

        #region Getter/Setter
        //Declare getter and setter for map height
        public int MapHeight 
        { 
            get { return mapHeight; } 
            set 
            {   //Verify if map height is not bigger than the limit
                if (mapHeight <= MAX_MAP_HEIGHT || mapHeight >= 0)
                {   //Set map height to new value
                    mapHeight = value;
                }
                else
                {   //Set map height back to 0
                    mapHeight = 0;
                }
            } 
        }

        //Declare getter and setter for map height
        public int MapWidth 
        { 
            get => mapWidth; 
            set
            {
                //Verify if map height is not bigger than the limit
                if (mapWidth <= MAX_MAP_WIDTH || mapWidth >= 0)
                {   //Set map height to new value
                    mapWidth = value;
                }
                else
                {   //Set map height back to 0
                    mapWidth = 0;
                }
            }
        }

        public string[] MapNameList { get => mapNameList; private set => mapNameList = value; }
        #endregion


    }
}
