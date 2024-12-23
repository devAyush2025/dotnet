namespace Question3
{
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
            

            Console.WriteLine($"Total :{total}");
        }
    }
}
