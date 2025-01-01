namespace Question4
{
    internal class Program
    {

        //4) Print addition of two hardcoded nos.Using Console Application.
        static void Main(string[] args)
        {
            int num1, num2,sum;
            Console.WriteLine("Enter first number : ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number : ");
            num2 = Convert.ToInt32(Console.ReadLine());
                sum = num1 + num2;

            Console.WriteLine($"Sum : {sum}");
        }
    }
}
