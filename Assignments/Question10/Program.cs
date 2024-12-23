namespace Question10
{
    internal class Program
    {
        static void Main(string[] args)
        { int num1, num2;
            Console.WriteLine("Enter First numbers");
            num1 = Convert.ToInt32(Console.ReadLine);
            Console.WriteLine("Enter Second numbers");
            num2 = Convert.ToInt32(Console.ReadLine);
            Console.WriteLine("<---Enter your choice--->");
            Console.WriteLine("1.Addition");
            Console.WriteLine("2.Subtraction");
            Console.WriteLine("3.Division");
            Console.WriteLine("4.Multiplication");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice) {
                case 1:
                    Console.WriteLine($"Addition :  {num1 + num2}");

                    break;
                case 2:
                    Console.WriteLine($"Substraction :{num1 + num2}");
                    break;
                case 3:
                    Console.WriteLine($"Division : {Convert.ToDouble(num1 / num2)}");
                    break;
                case 4:
                    Console.WriteLine($"Multiplication :{num2*num1}");
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;

            }
        }
    }
}
