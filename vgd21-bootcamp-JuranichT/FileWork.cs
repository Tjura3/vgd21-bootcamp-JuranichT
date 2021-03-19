using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace vgd21_bootcamp_JuranichT
{
    public static class FileWork
    {
        public static string path = "D:\\Video Game Design 2020\\VISUAL STUDIO 2019\vgd21-bootcamp-JuranichT\vgd21-bootcamp-JuranichT\\Player save data";
        struct _player
        {
            public int ID;
            public string name;
            public int health;
            public int gold;
        };

        public static void Commander()
        {
            _player player;
            player.ID = 0;
            player.name = "Fred";
            player.health = 50;
            player.gold = 100;

            while (true)
            {
                Console.Write("\nYour wish is my command> ");
                string cmd = Console.ReadLine();
                if (cmd.Trim().ToLower().StartsWith("quit")) return;
                if (cmd.Trim().ToLower().StartsWith("stat"))
                {
                    Console.WriteLine("{0} has health of {1} and {2} units of gold.", player.name, player.health, player.gold);
                }
                if (cmd.Trim().ToLower().StartsWith("save"))
                {
                    //SavePlayer(player);
                }
                if (cmd.Trim().ToLower().StartsWith("load"))
                {
                    //LoadPlayer ( ref player);
                }

                player.health--;
                player.gold++;
            }
        } //Commander

        private static void SavePlayer(_player p)
        {
            string dataToWrite = p.ID + "," + p.name + "," + p.health + "," + p.gold;
            dataToWrite += "\n" + DateTime.Now;
            try
            {
                File.WriteAllText(path, dataToWrite);
                Console.WriteLine("Player data saved.");
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
        }

        private static void LoadPlayer( ref _player p)
        {
            try
            {

                string[] playerFile = File.ReadAllLines(path);
                //Console.WriteLine(playerFile[0]);
               // Console.WriteLine(playerFile[1]);
                Console.WriteLine("restoring data from {0}", playerFile[1]);
                string[] playerData = playerFile[0].Split(",");
                p.ID = Convert.ToInt32(playerData[0]);
                p.name = playerData[1];
                p.health = Convert.ToInt32(playerData[2]);
                p.gold = Convert.ToInt32(playerData[3]);


            }catch (Exception error)
            {
                Console.WriteLine("Could not recover player data.");
                Console.WriteLine(error.Message);
            }


        }


    }
}
