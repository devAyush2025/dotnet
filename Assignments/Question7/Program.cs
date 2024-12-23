using System.ComponentModel;
using System.Text.RegularExpressions;

namespace Question7
{
    internal class Program
    {

//        7) Write a program to calculate Net Salary of an employee using Basic Salary based on following parameters – 
//a.HRA is 20% of basic salary.
//b.DA is 40% of basic salary.
//c.PF is 10% of Gross salary.
//d.Gross Salary is Basic Salary + HRA + DA.
//e.Net salary is Gross Salary – PF.
        static void Main(string[] args)
        {

            float bSal ;
            float HRA, DA, PF, grossSal;
            Console.WriteLine("Enter basic salary :");
            bSal = Convert.ToInt32(Console.ReadLine());

            HRA = (bSal * 20) / 100;
            DA = (bSal * 40) / 100;

            PF = (bSal * 10) / 100;
            grossSal = bSal + HRA + DA;

            float netSal = grossSal - PF;
            Console.WriteLine("Base salary : " + bSal); 
            Console.WriteLine("HRA : " + HRA); 
            Console.WriteLine("DA : " + DA);
            Console.WriteLine("gross salary : " + grossSal);
            Console.WriteLine("Net salary : "+netSal);

        }
    }
}
