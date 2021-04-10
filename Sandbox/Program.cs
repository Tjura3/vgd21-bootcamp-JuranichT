using System;

namespace Sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            string phrase = "1 2 3 4 5 4 3 2 1";
            string target = "3";

            for(int startPos = 0; startPos < phrase.Length; ++startPos)
            {
                int location = phrase.IndexOf(target, startPos);
                Console.WriteLine("Starting at {0}, I found the target at {1}", startPos, location);
                if (location != -1)
                {
                    Console.WriteLine("The test is true!");
                }
                else
                {
                    Console.WriteLine("The test is false.");
                }

            }

            GetZString();
        }

        static string GetZString()
        {
            bool startsWithZ = false;
            string userEntry = "";
            while(!startsWithZ)
            {
                Console.Write("Enter a name that starts with \"Z\"> ");
                userEntry = Console.ReadLine();
                startsWithZ = userEntry.Trim().StartsWith("Z");
            }

            return userEntry;
        }
    }
}
