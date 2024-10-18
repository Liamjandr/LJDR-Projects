using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Activity_DE_ROXAS_MANGUERRA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //start

            //Input

            Console.Write("Input Grade Percentage of The Student: ");
            double Grade = Convert.ToDouble(Console.ReadLine());

            // Decision
            if (Grade <= 100 && Grade >= 99)
            {
                Console.WriteLine("GPA Equivalent: 1.00, Excellent");
            }
            else if (Grade <= 98.99 && Grade >= 96)
            {
                Console.WriteLine("GPA Equivalent: 1.25, Excellent");
            }
            else if (Grade <= 95.99 && Grade >= 93)
            {
                Console.WriteLine("GPA Equivalent: 1.50, Very Satisfactory");
            }
            else if (Grade <= 92.99 && Grade >= 90)
            {
                Console.WriteLine("GPA Equivalent: 1.75, Very Satisfactory");
            }
            else if (Grade <= 89.99 && Grade >= 87)
            {
                Console.WriteLine("GPA Equivalent: 2.00, Satisfactory");
            }
            else if (Grade <= 86.99 && Grade >= 84)
            {
                Console.WriteLine("GPA Equivalent: 2.25, Satisfactory");
            }
            else if (Grade <= 83.99 && Grade >= 81)
            {
                Console.WriteLine("GPA Equivalent: 2.5, Fairly Satisfactory");
            }
            else if (Grade <= 80.99 && Grade >= 78)
            {
                Console.WriteLine("GPA Equivalent: 2.75, Fairly Satisfactory");
            }
            else if (Grade <= 77.99 && Grade >= 75)
            {
                Console.WriteLine("GPA Equivalent: 3.00, Passed");
            }
            else if (Grade <= 74.99 && Grade >= 70)
            {
                Console.WriteLine("GPA Equivalent: 4.00, Conditional Failure");
            }
            else if (Grade <= 69.99 && Grade >= 0)
            {
                Console.WriteLine("GPA Equivalent: 5.00, Failure");
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
            

            //End

            Console.ReadKey();


        }
    }
}
