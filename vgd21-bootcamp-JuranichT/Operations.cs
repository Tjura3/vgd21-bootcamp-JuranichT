using System;
using System.Collections.Generic;
using System.Text;

namespace vgd21_bootcamp_JuranichT
{
    public static class Operations
    {
        //Meathod
        public static void Arithmetic()
        {
            //use the debugger in watch the balues change
            int a = 9;
            int b = 6;

            int c;
            a++;  //specifically adds one
            b--; // specifically minus one
            c = a + b; //add
            c = a - b; //sub
            c = a * b; //multi
            c = a / b;  //divi
            c = a % b; //modulo operator     a/b and return the remainder:  (10/5) = 2 R 0    (Ans = 0)
            c = b % a; //                    b/a and return the remainder:  (5/10) = 0 R 5    (Ans = 5)
            //The modulo is used most often ti=o determin if a number is odd or even.
            c = 13 % 2;// 1: odd
            c = 14 % 2;// 0: even

            //Assignment
            // a=10, b=5
            a += b;   //Shorthand for saying (a = a + b)
            a -= b;   // a=10, b=5   a=a-b
            a *= b;     //a=50 b=5  a=a*b
            a /= b;     //a=10 b=5  a=a/b
            a = b;      // a&b=5   A is B
        }
        public static void Comparison()
        {
            int a = 10;
            int b = 45;
            int c = 10;
            Console.WriteLine(a == b); //is equal
            Console.WriteLine(a != b); // Not equal
            Console.WriteLine(a > c); //Greater than
            Console.WriteLine(a >= c); // "" or equal to
            Console.WriteLine(a < c); //Less than
            Console.WriteLine(a <= c); // "" or equal to
        }
        public static void Logic()  
        {
            int playerXP = 80;
            int playerHealth = 19;
            bool hasWeapon = true; //                       PsST! == basically means it has to equal me before I change.  for example, I have a weapon, But I need to not have a weapon for line 62 to be true.
            bool hasMagic = false;
            bool canUnlockLevel99 = false;
            bool canPickupSword = false;

            //Using and AND operator... "&&" ALL elements must be true     && basically means "As well as"
            canUnlockLevel99 = (playerXP >= 75 && playerHealth > 20 && hasMagic == true);

            //Using OR operator "||" Only one of the things on said list has to be true. "One or the other"  (WILL WORK IF ALL ARE TRUE.)
            canPickupSword = (!hasWeapon || hasMagic);                //just say the thing if its already a boolian                                        // "![placeholder]" means the same as "== false". 
             Console.WriteLine(canPickupSword);
        }
        public static void Ternary()
        {
            int a, b, c;                                      //One more operator, XOR operator   Only ONE true will work.
            a = 20;
            b = 30;
            c = (a == b) ? a : b;   //Ternary operator (Shorthand "If/else" statement)
            // (test) ? (If test is true) : (if test is false)

            Console.WriteLine(c);
        }
    }
}

