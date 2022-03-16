using HelloWorld.Test;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            StretchRectangle(new Rectangle(2, 5));
            StretchSquare(new Square (2, 5));
            //Console.WriteLine("Hello TD Africa!");
            //int number = 45764;
            //Console.Write("Please enter a number: ");
            //int number = int.Parse(Console.ReadLine());
            //int divisibleBy100 = (number/100);
            //int thirdDigit = (divisibleBy100) % 10 ;
            // if (thirdDigit == 7)
            // {
            //     Console.WriteLine("The third digit is Seven");
            // }
            // else
            // {
            //     Console.WriteLine("The third digit is NOT Seven");
            // }
            //Console.WriteLine(thirdDigit == 7 ? true : false );
            //int n = 11;
            //int sum = 0;
            //for (int i = 1; i <= n; i +=2)
            //{
            //     if (i % 7 == 0)
            //     {
            //         continue;
            //     }
            //     sum += i;
            //}
            //Console.WriteLine( "Sum = " + sum);
        }

        private static void StretchSquare(Square square)
        {
            square.Width *= 2 ;
            square.Height *= 2;

             Console.WriteLine(square.Area);
        }

        private static void StretchRectangle(Rectangle rectangle)
        {
            rectangle.Width *= 2;
            rectangle.Height *= 2;

            Console.WriteLine(rectangle.Area);
        }
    }
}