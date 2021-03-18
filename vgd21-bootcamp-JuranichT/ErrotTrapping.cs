using System;
using System.Collections.Generic;
using System.Text;

namespace vgd21_bootcamp_JuranichT
{
    public static class ErrotTrapping
    {



        public static void DontCatchError()
        {
            Console.WriteLine("The divider by zero issue");
            int numerator = 10;
            for (int x = -3; x <= 3; x++)
            {
                if (x != 0)
                {
                    int awnser = numerator / x;
                    Console.WriteLine("{0}/{1} = {2}", numerator, x, awnser);


             
                }

            }
        }

        public static void CatchRuntimeError()
        {
            try
            {
                //Try code that might have an issue in here... 
                Console.WriteLine("The divider by zero issue");
                int numerator = 10;
                for (int x = -3; x <= 3; x++)
                {
                    int awnser = numerator / x;
                    Console.WriteLine("{0}/{1} = {2}", numerator, x, awnser);
                }


            }
            catch (Exception error)
            {
                //Handle any errors that come up in try
                Console.WriteLine(error.Message);
                Console.WriteLine("The program continues...");
            }



        }




    }
}
