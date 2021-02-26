using System;
using System.Collections.Generic;
using System.Text;

namespace vgd21_bootcamp_JuranichT
{
    class MadLib
    {


        public static void Execute()
        {
            Console.WriteLine("Enter a number");
            double float1 = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Enter an adjictive");
            string adj1 = Console.ReadLine();
            
            Console.WriteLine("Enter an adjictive");
            string adj2 = Console.ReadLine();
            
            Console.WriteLine("Enter an noun");
            string noun1 = Console.ReadLine();
            
            Console.WriteLine("Enter an pronoun");
            string pnonoun1 = Console.ReadLine();
            
            Console.WriteLine("enter a number");
            double float2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter a verb");
            string verb1 = Console.ReadLine();

            Console.WriteLine("Enter an adjictive");
            string adj3 = Console.ReadLine();

            Console.WriteLine("Enter an adjictive");
            string adj4 = Console.ReadLine();

            Console.WriteLine("Enter a verb");
            string verb2 = Console.ReadLine();

            string Mess = (float2 > 15) ? "big" : "small";


            //all done... tell the story...
            Console.WriteLine("Just as I had turned {0} years old, It suddenly began to snow!", float1);
            Console.WriteLine("Snow in the winter is the BEST! \nThe {0} snow, and the {1} air, It makes one of the best feelings ive ever felt!", adj1, adj2);
            Console.WriteLine("After a nice cup of {0}, Its time, I decided, to get on the skii lift. I grab my {1} {2}, and get in line for the wait.", noun1, float2, pnonoun1);
            Console.WriteLine("Once I got to the lift, I got {0} in, I was happy to look over and see the {1} buildings and houses below." +
                "\n it took a bit for me to get the top, but once up, I put on my {2}, and went down the slope!" +
                "\nAt first, it was a bit of a {3} ride, but I got {4} as the ride whent on. the thrill was exasperating!\n" +
                "once I landed however I got into a huge mess...\n" +
                "MY {2}!! I yelled out screming. Oh dear. I looked over to see that my {5} {2} has broken into many pieces.", verb1, adj3, pnonoun1, adj4, verb2, float2);

            double float3 = float2 * .9;
            
            Console.WriteLine("Oh no, Mom is gonna FLIP when she finds out! I scrape together what I can of the {0} mess and only come up with {1} pieces.. I Hide it away. Hopefully, this can be forgotten about soon...", Mess, float3);
            
            
            

        }

    }


}
