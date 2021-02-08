using System;
using System.Collections.Generic;
using System.Text;

namespace vgd21_bootcamp_JuranichT
{
    public static class Storing
    {

        //Enums start here...
        enum Days { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday};

        //Structs start here...
        struct _enemy
        {
            public string name;
            public int health;
            public bool isAlive;
            public float damage;

        }



        //our first method
        public static void initialize()
        {
            Console.WriteLine("Hi!");
            Console.WriteLine("C# Bootcamp initialized.");
        }


        public static void DemoVariables()
        {
            int health = 50;
            char gender = 'M';
            bool living = false;
            string Name = "Duke the Unfaltering";
            string Weapon = "Mighty greatsword";
            string Armor = "Titan scale plating";

            Console.WriteLine("Name:\t\t\t" + Name);
            Console.WriteLine("Gender:\t\t\t{0}", gender);
            Console.WriteLine("Current health:\t\t{0}", health);
            Console.WriteLine("Are you dead?\t\t{0}", living);
            Console.WriteLine("Current equips:\n\tW:{0}\n\tA:{1}", Weapon, Armor);
        }

        public static void ReadingInput()
        {
            Console.Write("You that is apporching, would you be so kind as to tell me your name? > ");
            string playerName = Console.ReadLine();
            Console.WriteLine("Ahh so {0} is it? I see, this will be interesting.", playerName);
            Console.Write("\nNow this may be a bit out of the blue, but I wold like to know your age. Its a small thing, but its rather important for this to continue. May you please tell me it? > ");
            int ageInYears = Convert.ToInt16(Console.ReadLine());
            int months = ageInYears * 12;
            float days = ageInYears * 365.25f;
            Console.WriteLine("Ahh. so you are {0} years old. Or {1} months old, or {2} days old. Parfect. now with that out of the way, let us begin.", ageInYears, months, days);

        }

        public static void UsingArrays()
        {
            string[] enemyName = new string[5];
            enemyName[0] = "Eddie the evicerator";
            enemyName[1] = "Abe the Avenger";
            enemyName[2] = "Jason the Judge";
            enemyName[3] = "Mason the Melter";
            enemyName[4] = "Pablo the Pluage Doctor";
            int[] enemyHealth = new int[5] {70, 50, 20, 35, 15 };




            System.Random random = new System.Random();

            while (true) //CTRL-C to exit the endless loop
            {
                int num = random.Next(5);
                Console.WriteLine(num);
                Console.WriteLine("You're fighting {0} who is topped off at {1} HP.", enemyName[num], enemyHealth[num]);
            }
            
            
            
            
        }

        public static void ConstantsEnumsStructs()
        {
            //Constants...
            const double pi = 3.1415926535;
            Console.WriteLine(pi);
            //pi = 3.14; Cant do this


            //Enums  (Also avalible in java)
            var dayOfWeek = Days.Monday;
            Console.WriteLine("The day is {0}", dayOfWeek);
            if(dayOfWeek == Days.Saturday || dayOfWeek == Days.Sunday)
            {
                Console.WriteLine("It's a weekend!");
            }
            else
            {
                Console.WriteLine("It's a weekday.");
            }


            //Structs
            _enemy SamTheShark;
            SamTheShark.name = "Sam the shark";
            SamTheShark.health = 50;
            SamTheShark.isAlive = true;
            SamTheShark.damage = 13.36f;

            SamTheShark.health--;
            Console.WriteLine("{0} has a health of {1}", SamTheShark.name, SamTheShark.health);


        }
        


    } //public static class storing
}
