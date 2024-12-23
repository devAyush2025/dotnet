namespace Question9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter basic salary: "); 
            double bs = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter total sales: ");
            double sa = Convert.ToDouble(Console.ReadLine());
            double cr = 0;
            if (sa >= 5000 && sa <= 7500) {
                cr = 0.03; 
            }
            else if (sa > 7500 && sa <= 10500) {
                cr = 0.08; 
            } else if (sa > 10500 && sa <= 15000) { 
                cr = 0.11;
            } else if (sa > 15000) { 
                cr = 0.15;
            }
            double com = sa * cr;
            double ns = bs + com;
            Console.WriteLine("\nSales Amount: Rs. {0}", sa);
            // Debug print
             Console.WriteLine("Commission Rate: {0}", cr); 
            // Debug print
            
             Console.WriteLine("Commission Earned: Rs. {0}", com);
             Console.WriteLine("Net Salary: Rs. {0}", ns);
        }
    }
}
