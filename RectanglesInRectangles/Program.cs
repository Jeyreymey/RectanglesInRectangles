using System;

namespace RectanglesInRectangles
{
    class Program
    {
        static void Main()
        {
            TestA();
            TestB();
            TestC();

            Console.ReadLine();
        }

        static void TestA()
        {
            Console.WriteLine("Test A");
            var rectA = new Rectangle(9, 4);
            var rectB = new Rectangle(8, 6);

            if (rectA.FitsInRectangle(rectB))
            {
                Console.WriteLine("Test A Failed");
                Console.WriteLine("Rect A fits in Rect B");
            }
            else
            {
                Console.WriteLine("Test A Passed");
                Console.WriteLine("Rect A DOES NOT fit in Rect B");
            }
            Console.WriteLine();
        }

        static void TestB()
        {
            Console.WriteLine("Test B");
            var rectA = new Rectangle(88, 13);
            var rectB = new Rectangle(81, 59);

            if (rectA.FitsInRectangle(rectB))
            {
                Console.WriteLine("Test B Failed");
                Console.WriteLine("Rect A fits in Rect B");
            }
            else
            {
                Console.WriteLine("Test B Passed");
                Console.WriteLine("Rect A DOES NOT fit in Rect B");
            }
            Console.WriteLine();
        }

        static void TestC()
        {
            Console.WriteLine("Test C");
            var rectA = new Rectangle(8, 6);
            var rectB = new Rectangle(8, 6);

            if (rectA.FitsInRectangle(rectB))
            {
                Console.WriteLine("Test C Passed");
                Console.WriteLine("Rect A fits in Rect B");
            }
            else
            {
                Console.WriteLine("Test C Failed");
                Console.WriteLine("Rect A DOES NOT fit in Rect B");
            }
            Console.WriteLine();
        }
    }
}
