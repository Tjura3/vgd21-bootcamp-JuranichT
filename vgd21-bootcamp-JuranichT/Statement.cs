using System;
using System.Collections.Generic;
using System.Text;

namespace vgd21_bootcamp_JuranichT
{
     public static class Statement
     {
        public static void branchingIF()
        {
            int a = 3; //Try changing this later...

            if (a < 4)  //Few things in c# without a ; at the end
            {
                Console.WriteLine("The thieves quivers are running rather dry...");
                Console.WriteLine("Time to strike!");

            }
            else if (a >= 4 && a <= 10)                                            //Else is when If is false
            {
                Console.WriteLine("The thieves are armed with arrows");
            }
            else
            {
                Console.WriteLine("The thieves have a full quiver of arrows");
            }

            //one line test
            int b = 10;
            if (b > 5) Console.WriteLine("b is bigger then 5.");     //Not necesary for {} when a single line   [can also be thrown into a new line if still, just one line.]




        }


        public static void Switching()
        {
            int p =  3 % 7; //using mod 7 to wrap weeks
            string pill = "";

            switch (p)       // No ; after switch
            {
                case 1:      //In case d == 1, what do you want to do?
                    pill = "Red pill";
                    break;
                case 2:
                    pill = "Blue pill";
                    break;
                case 3: 
                    pill = "Orange pill";
                    break;
                case 4:
                    pill = "Pink pill";
                    break;
                case 5:
                    pill = "White pill";
                    break;
                case 6:
                    pill = "Purple pill";
                    break;
                case 7:
                    pill = "Green pill";
                    break;
                default:
                    pill = "Black pill";
                    break;
                    

            }
            Console.WriteLine("Rolled a {0}... You got a {1}!!!", p, pill);

        }

        public static void Forloop()
        {
                    //used for counting (often for integers)
                    //for (initializer; test-expression; updater)

            for (int i = 1; i <= 15; i++)     //No ; here
            {
                Console.WriteLine("The value of i is {0}", i);
            }

            //Nested For Loops     Useful for populating or traversing a grid
            //outer loop (i)
            for (int i = 0; i<10; i++)
            {
                Console.WriteLine("Outer Loop {0}", i);


                //inner loop (j)  the loop within the loop
                
                
                for (int j = 0; j < 5; j++)
                {
                    Console.WriteLine("\tInner Loop {0}", j);
                }


            }

        }

        public static void WhileLoops()
        {
            //While (test expression == true) {statements}
            int i = 0;
            while (i < 10) //no ;
            {
                Console.WriteLine("\tThe Pincushins pin count is {0}", i);
                i++;
            }

            //do-while loop  TESTING gts done at the END (or bottom) of the loop
            int j = 0;
            do
            {
                Console.WriteLine("Amount of walls broken: {0}", j);
                j++;

            } while (j < 5);

            //do-whiles are used for accepting input from users until they "q"

            do
            {
                Console.WriteLine("Enter a command: > ");
            } while (Console.ReadLine() != "q"); 



        }

        public static void LoopingArrays()
        {
            string[] monster = new string[4];
            monster[0] = "Fred the Foe";
            monster[1] = "Thomas the Terrible";
            monster[2]= "Logan the Lacerator";
            monster[3] = "Ron the Ravounus";

            Console.WriteLine("Monster List:");

            for(int i = 0; i < 4; i++)
            {
                Console.WriteLine("\t{0}", monster[i]);


            }



        }

        public static void ForEachIterations()
        {
            List<string> Weapons = new List<string>();
            Weapons.Add("Sheild of hope");
            Weapons.Add("Bullet Lance");
            Weapons.Add("Furious Morningstar");
            Weapons.Add("Iron Shortsword");
            Weapons.Add("Electron Cannon");

            Console.WriteLine("List of weapons in inventory");
            //iterate through them...
            foreach(string w in Weapons)
            {
                Console.WriteLine("\t{0}", w);
            }



        }



     }

    

    
}
