using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITEC102_10_14_24_Activity_DE_ROXAS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Grading System
             * First Activity
             * Requirements:
             * name
             * program
             * course
             * college
             * numerical grade
             * 
             * Option on what to view
             * 
             */
            //Start

            int option;

            string gradingScale = "Numerical Grade  Grade Point   Description" + "\n99-100           1.00          Excellent\n96-98            1.25          Excellent\n93-95            1.50          Very Satisfactory\n90-92            1.75          Very Satisfactory\n87-89            2.00          Satisfactory" +
                                  "\n84-86            2.25          Satisfactory\n81-83            2.50          Fairly Satisfactory\n78-80            2.75          Fairly Satisfactory\n75-77            3.00          Passed\n70-74            4.00          Conditional Failure\n69 and Below     5.00          Failed";

            double grade;           

            Console.WriteLine("Grading System Tool");

            string name;
            string program;
            string course;
            string college;

            Console.Write("Name [Ex. Liam Jan]: ");
            name = Console.ReadLine();
            Console.Write("Program [Ex. BSCS]: ");
            program = Console.ReadLine();
            Console.Write("College [Ex. Fundamentals of Programming]: ");
            course = Console.ReadLine();
            Console.Write("Course [Ex. College of Computer Studies]: ");
            college = Console.ReadLine();

            Console.WriteLine("Option 1: Numerical Grade Equivalent Checker \nOption 2: Display Full Grading Scale \nOption 3: Exit Program");
            Console.Write("Write The corresponding number of Option for the required function: ");
            option = Convert.ToInt32(Console.ReadLine());
            
            if (option == 1)
            {
                Console.Write("Input Numerical Grade (Use up to 2 Decimal Place): ");
                grade = Convert.ToDouble(Console.ReadLine());
                if (grade >= 99 && grade <= 100)
                {
                    Console.Write(name + ", a student from " + program + " under the " + college + ", enrolled in " + course + ", recieved a grade of " + grade);
                    Console.Write(". The Corresponding grade point is 1.00, which is described as Excellent.");
                    Console.ReadKey();
                    return;
                }
                else if (grade >= 96 && grade <= 98.999)
                {
                    Console.Write(name + ", a student from " + program + " under the " + college + ", enrolled in " + course + ", recieved a grade of " + grade);
                    Console.Write(". The Corresponding grade point is 1.25, which is described as Excellent.");
                    Console.ReadKey();
                    return;
                }
                else if (grade >= 93 && grade <= 95.999)
                {
                    Console.Write(name + ", a student from " + program + " under the " + college + ", enrolled in " + course + ", recieved a grade of " + grade);
                    Console.Write(". The Corresponding grade point is 1.50, which is described as Very Satisfactory.");
                    Console.ReadKey();
                    return;
                }
                else if (grade >= 90 && grade <= 92.999)
                {
                    Console.Write(name + ", a student from " + program + " under the " + college + ", enrolled in " + course + ", recieved a grade of " + grade);
                    Console.Write(". The Corresponding grade point is 1.75, which is described as Very Satisfactory.");
                    Console.ReadKey();
                    return;
                }
                else if (grade >= 87 && grade <= 89.999)
                {
                    Console.Write(name + ", a student from " + program + " under the " + college + ", enrolled in " + course + ", recieved a grade of " + grade);
                    Console.Write(". The Corresponding grade point is 2.00, which is described as Satisfactory.");
                    Console.ReadKey();
                    return;
                }
                else if (grade >= 84 && grade <= 86.999)
                {
                    Console.Write(name + ", a student from " + program + " under the " + college + ", enrolled in " + course + ", recieved a grade of " + grade);
                    Console.Write(". The Corresponding grade point is 2.25, which is described as Satisfactory.");
                    Console.ReadKey();
                    return;
                }
                else if (grade >= 81 && grade <= 83.999)
                {
                    Console.Write(name + ", a student from " + program + " under the " + college + ", enrolled in " + course + ", recieved a grade of " + grade);
                    Console.Write(". The Corresponding grade point is 2.50, which is described as Fairly Satisfactory.");
                    Console.ReadKey();
                    return;
                }
                else if (grade >= 78 && grade <= 80.999)
                {
                    Console.Write(name + ", a student from " + program + " under the " + college + ", enrolled in " + course + ", recieved a grade of " + grade);
                    Console.Write(". The Corresponding grade point is 2.75, which is described as Fairly Satisfactory.");
                    Console.ReadKey();
                    return;
                }
                else if (grade >= 75 && grade <= 77.999)
                {
                    Console.Write(name + ", a student from " + program + " under the " + college + ", enrolled in " + course + ", recieved a grade of " + grade);
                    Console.Write(". The Corresponding grade point is 3.00, which is described as Passed.");
                    Console.ReadKey();
                    return;
                }
                else if (grade >= 70 && grade <= 74.999)
                {
                    Console.Write(name + ", a student from " + program + " under the " + college + ", enrolled in " + course + ", recieved a grade of " + grade);
                    Console.Write(". The Corresponding grade point is 4.00, which is described as Conditional Failure.");
                    Console.ReadKey();
                    return;
                }
                else if (grade >= 50 && grade <= 69.999)
                {
                    Console.Write(name + ", a student from " + program + " under the " + college + ", enrolled in " + course + ", recieved a grade of " + grade);
                    Console.Write(". The Corresponding grade point is 5.00, which is described as Failed.");
                    Console.ReadKey();
                    return;
                }
                else
                {
                    Console.WriteLine("Invalid Input. Numerical grade must be between 50 and 100.");
                    Console.WriteLine("Exiting the program. Goodbye!");
                    Console.ReadKey();
                    return;
                }
            }
            else if (option == 2)
            {
                Console.WriteLine(gradingScale);
                Console.WriteLine("Press Any key to exit...");
                Console.ReadKey();
                return;
            }
            else if (option == 3)
            {
                Console.WriteLine("Exiting the program. Goodbye!");
                Console.ReadKey();
                return;
            }
            else 
            {
                Gay();
            }

            void Gay()
            {
                Console.WriteLine("Invalid Input.");
                Console.WriteLine("Exiting the program. Goodbye!");
                Console.ReadKey();
                return;
            }
        }
    }
}
;