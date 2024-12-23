using System.ComponentModel;

namespace Question5
{

    //5) Write a program to swap two variables using a third variable by Console Application.
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, temp;
            Console.WriteLine("Enter first number : ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number : ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Numbers Before Swap " +
                $"Num1 : {num1} Num2 : {num2}");


            temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine($"Numbers After  Swap " +
               $"Num1 : {num1} Num2 : {num2}");

        }
    }
}
