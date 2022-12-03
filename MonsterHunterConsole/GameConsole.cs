using MonsterHunterDLL;
using MonsterHunterDLL.Classes;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace MonsterHunterConsole
{
    public class GameConsole
    {
        static void Main(string[] args)
        {
            try
            {
                //Declare variables
                int iMapChoice = 0;
                string sSelectedMap = "";

                //Instanciate objects
                Hunter hCurrentHunter = new Hunter(0, 0);
                Maps mCurrentMap = new Maps();
                List<Monster> lMonsterList = new List<Monster>();

                //Set cursor to middle of the screen on first line
                Console.SetCursorPosition(Console.WindowWidth / 3, 0);

                //Welcome screen
                Console.WriteLine("Welcome to Monster Hunter!");

                //Set cursor to middle of the screen on next line
                Console.SetCursorPosition(Console.WindowWidth / 3, 1);

                //Ask player to press a key
                Console.Write("    Press any key...");

                //Readkey to continue
                Console.ReadKey();

                //Clear screen to make space for new instructions
                Console.Clear();

                //Loop to make sure the name length is not to long
                do
                {
                    //Ask player to enter a name
                    Console.WriteLine("Please enter your hunter name : ");

                    //Read the players' entry for the player name
                    hCurrentHunter.Name = Console.ReadLine();

                } while (hCurrentHunter.Name.Length == 0);

                //Ask the player to select a map
                Console.Write("Please select a map for your game :");

                //Loop to make sure the player selects an existing map
                do
                {
                    //Show map menu on screen
                    Console.WriteLine("\nMaps:");
                    Console.WriteLine("1: " + mCurrentMap.maps[0]);
                    Console.WriteLine("2: " + mCurrentMap.maps[1]);
                    Console.WriteLine("3: " + mCurrentMap.maps[2]);

                    //Read players' entry and convert to a number
                    iMapChoice = Convert.ToInt32(Console.ReadLine());

                    //Switch permits to select right map from players' choice
                    switch (iMapChoice)
                    {
                        case 1:
                            {   //Set selected map to the related name index
                                sSelectedMap = mCurrentMap.MapNameList[iMapChoice - 1];
                            }
                            break;
                        case 2:
                            {   //Set selected map to the related name index
                                sSelectedMap = mCurrentMap.MapNameList[iMapChoice - 1];
                            }
                            break;
                        case 3:
                            {   //Set selected map to the related name index
                                sSelectedMap = mCurrentMap.MapNameList[iMapChoice - 1];
                            }
                            break;
                        default:
                            {
                                //Error message
                                Console.Write("Error! Please select a valid map: ");
                            }
                            break;
                    }
                    //Makes sur that the player choose a existing map
                } while (iMapChoice < 1 || iMapChoice > 3);

                //Clear console to show map
                Console.Clear();

                //Call function to load selected map
                mCurrentMap.LoadMap(sSelectedMap, hCurrentHunter, lMonsterList);

                //Call function to draw map
                mCurrentMap.DrawMap();

                //Set position of hunter and monsters

                //Game loop
                while (!hCurrentHunter.IsDead())
                {
                    //Call function to activate fights
                    Fight(hCurrentHunter, lMonsterList);   

                }

                //Function to fight monsters
                void Fight(Hunter pHFightingHunter, List<Monster> pLFightingMonsters)
                {
                    //Call CalculateDamage and CalculateDefense
                }
            }
            catch (Exception myException)
            {
                //Call error manager to manage catched errors
                Exception_Manager.errorManager(myException,
                    System.Reflection.MethodBase.GetCurrentMethod().Name);
            }
        }

        
    }
}
