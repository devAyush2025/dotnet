using System.ComponentModel;

namespace Question8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 8) Write a program to find LEAP year by using – 
                 a.If – Else and logical operators.
                 b.Conditional operator.
                 c.Note – A Leap year is divisible by 4 and is not divisible by 100 but it could be divisible by 400.*/

            int year;
            Console.WriteLine("Enter a Year : ");
            year = Convert.ToInt32(Console.ReadLine());

            if ((year % 4 == 0 || year % 400 == 0) && year % 100 != 0)
            {
                Console.WriteLine($" Year {year} is  Leap Year ");
            }
            else{
                Console.WriteLine($" Year {year} is  not Leap Year ");

            }


        }
    }
}
