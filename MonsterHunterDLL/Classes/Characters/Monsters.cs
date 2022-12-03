
using System.Collections.Generic;

namespace MonsterHunterDLL.Classes
{
    public class Monsters
    {
        //Declare 
        List<Monster> monstersList = new List<Monster>();

        //Declare function to return list of monster with position
        public List<Monster> MonstersPosition
            (int xPosition, int yPosition, List<Monster> monstersOnMap)
        {
            //Verify every element of the list monstersOnMap
            foreach (Monster monster in monstersOnMap)
            {   //Verify if the position checked is occupied by 
                if (monster.PositionX == xPosition && monster.PositionY == yPosition)
                {
                    //Add monster found to monstersList
                    monstersList.Add(monster);
                }
            }

            //Return list with monsters
            return monstersList;
        }
    }
}
