namespace Question6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //6) Accept a character from a user and print its ASCII value using Console Application.

            char num1;
            Console.WriteLine("Enter a character : ");
            num1 = char.Parse(Console.ReadLine());
            int asci = num1;
            //num1 = Convert.ToChar(Console.ReadLine());

            Console.WriteLine($"ASCII : {asci} ");

        }
    }
}
