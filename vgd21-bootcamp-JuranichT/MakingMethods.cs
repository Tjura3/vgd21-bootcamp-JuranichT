using System;
using System.Collections.Generic;
using System.Text;

namespace vgd21_bootcamp_JuranichT
{
    class MakingMethods
    {
        //methods are created like this:

        //access-type return-data-type method-name  (  parameters  )  { your-code}

        //access-type: public, private, protected*, internal*
        //data-type: string, int, float, bool, bouble, objects

        private static double BodyTempF()
        {
            double tempreature = 98.99999;
            return tempreature;

        }
        
        private static double BodyTempC()
        {
            return 37.0;
        }

        public static void ReportBodyTemp()
        {
            double bTF = BodyTempF();
            double bTC = BodyTempC();
            Console.WriteLine("Your temp is {0} degF or {1} degC", bTF, bTC);
        }

        //How to use arguments
        public static double ConvertFtoC (double degF)
        {
            double C;
            C = (degF - 32.0) * 5.0 / 9.0;
            return C;
        }

        //Overloading: same method name, but with diffrent arguments, diffren return types
        public static float Area(float radious)
        {
            return (3.14159f * radious);
        }

        public static float Area(float width, float height)
        {
            return (width * height);
        }

        public static int Area(int edgeOfSquareLength)
        {
            return edgeOfSquareLength * edgeOfSquareLength;
        }


        //Passing values by value or by ref.... C and C++   but C# can also do it this way...
        //Totaly optional.... just want you to be aware of it!
        private static int ReturnByValue(int x)
        {
            x++;
            return x * x;
        }


        private static int ReturnByReference(ref int x)     //similar to a pointer in C & C++
        {
            x++;
            return x * x;
        }

        public static void TestThem()
        {
            int side = 5;
            int awnser;

            awnser = ReturnByValue(side);
            Console.WriteLine("When input is {0}, output is {1}", side, awnser);

            awnser = ReturnByReference(ref side);
            Console.WriteLine("When input is {0}, output is {1}", side, awnser);

        }
    }
}
