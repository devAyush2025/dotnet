using System.ComponentModel;

namespace Question2
{

    //2) Write a program to accept 5 marks from the user and calculate their average using Console Application.
    internal class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            Console.WriteLine("Enter marks of five subjects");
            for (int i = 1; i <= 5; i++)
            {
                int mark = Convert.ToInt32(Console.ReadLine());
                total += mark;
            }
            float avg = (float)(total / 5);

            Console.WriteLine($"Avergae :{avg}");

        }
    }
}
