using System;
using System.Collections.Generic;
using System.Text;

namespace vgd21_bootcamp_JuranichT
{
    public static class MiniDC
    {
        struct _player     //will include moster
        {
            public int ID; //0 will be you!!
            public string name;
            public int health;
            public int dexterity;
            public int strength;


        };

        struct _location       //You can customize these later for more points 
        {
            public string locationName;
            public string description;
            public int monsterID;
        };

        
        public static void PlayGame()
        {
            string version ="0.0.2";

            //Create the player...
            _player player;
            player.ID = 0;    //The protagonist (Main player)
            player.name = "fearless ferdinand";
            player.health = 50;


            //give the player a location (pX,pY)
            int pX = 5;
            int pY = 5;


            //Create some monsters
            _player[] monster = new _player[10];
            monster[1].ID = 1; monster[1].name = "Zeke the Zombie"; monster[1].health = 5;
            monster[2].ID = 2; monster[2].name = "Shreck the oger"; monster[2].health = 500;
            monster[3].ID = 3; monster[3].name = "Tom the Evil Cat"; monster[3].health = 15;




            //Create some locations
            int maxX = 10; int maxY = 10;
            _location[,] location = new _location[maxX, maxY];
            location[5, 5].locationName = "Home";
            location[5, 6].locationName = "Jail";
            location[5, 6].description = "You see chaini, and whips, and stockades in this room. You are nervous that the executioner will return soon.";
            location[2, 2].locationName = "The Zither room";
            location[2, 2].description = "you enter this room and hear strange sounding music. You feel yourself entering a trance.";
            location[2, 2].monsterID = 3;
            location[7, 7].monsterID = 2;
            location[4, 6].monsterID = 1;
            location[4, 6].locationName = "The forest";
            location[9, 9].locationName = "The fountain of youth";

            //Start the game engine...
            Console.WriteLine("welcome to The crypt. Version {0}", version);
            Random dice = new Random();
            while (true) //Forever loop
            {


                //display info about where the charechter is...
                Console.WriteLine("\n\n---------------------------------------------------------");
                Console.WriteLine("You are at ({0},{1}", pX, pY);
                Console.WriteLine("Your health is: {0}", player.health);
                Console.WriteLine("*{0}*\n{1}", location[pX,pY].locationName, location[pX,pY].description);

                //Monster Detection & Battle...
                if (location[pX,pY].monsterID != 0)       //we found a monster, TIME TO BATTLE
                {
                    int mID = location[pX, pY].monsterID;
                    Console.WriteLine("You encounter {0} with {1} health", monster[mID].name, monster[mID].health);

                    //Battle!
                    int damagetoPlayer = dice.Next(0, 10);   //can customize this based on monster later. 
                    int damageToMonster = dice.Next(0,10);
                    player.health -= damagetoPlayer;
                    monster[mID].health -= damageToMonster;
                    Console.WriteLine("You take {0} damage!", damagetoPlayer);
                    Console.WriteLine("{0} takes {1} damage!", monster[mID].name, damageToMonster);
                    //Deal with death!!!
                    if (monster[mID].health <= 0)
                    {
                        Console.WriteLine("You kill {0}!!!", monster[mID].name);
                        location[pX, pY].monsterID = 0;



                    }
                    if(player.health <= 0)
                    {
                        Console.WriteLine("\n\nYOU DIE!!!");
                        return;
                    }


                }//End of the fight

                //specialized rooms
                if (pX == 9 && pY == 9)
                {
                    Console.WriteLine("You drink an elixer and feel like you can suplex a mountain!!!(Healed 10 health!)");
                    player.health += 10;
                }





                //Ask the player for a command
                Console.WriteLine("\nYour wish is my command > ");
                string cmd = Console.ReadLine();
                if (cmd == "q") 
                {
                    Console.WriteLine("Thank you for playing!");
                     return;
                }

                if (cmd == "n") pY--;
                if (cmd == "e") pX++;
                if (cmd == "s") pY++;
                if (cmd == "w") pX--;
                if (cmd == "m") DrawMap(location, pX, pY);
                pX = Math.Clamp(pX, 0, maxX - 1);
                pY = Math.Clamp(pY, 0, maxY - 1);

            }//end of while true
            Console.WriteLine("Game Over.");


        }



        private static void DrawMap(_location[,] loc, int playerX, int playerY)
        {
            //https://docs.microsoft.com/en-us/dotnet/api/system.array.length?view=net-5.0
            //Console.WriteLine(loc.Rank);
            int xDim = loc.GetUpperBound(0);
            int yDim = loc.GetUpperBound(1);
            //Console.WriteLine("{0}, {1}", xDim, yDim);
            for (int y = 0; y <= yDim; y++)
            {
                for (int x = 0; x <= xDim; x++)
                {
                    string locName = "*";

                    if (loc[x, y].locationName != null || loc[x, y].monsterID != 0)
                    {
                        //locName = (loc[x, y].locationName).Substring(1,1);
                        locName = "+";
                    }
                    if (x == playerX && y == playerY)
                    {
                        locName = "X";
                    }
                    Console.Write(locName);
                }
                Console.WriteLine("");
            }
        }









    }

}
