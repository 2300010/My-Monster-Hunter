
namespace MonsterHunterDLL
{
    public class Maps
    {
        //Declare 
        private int mapHeight = 0;
        private int mapWidth = 0;

        public int MapHeight 
        { 
            get { return mapHeight; } 
            set 
            {
                if (mapHeight <= 20)
                {
                    mapHeight = value;
                }
                else
                {

                }
            } 
        }
    }
}
