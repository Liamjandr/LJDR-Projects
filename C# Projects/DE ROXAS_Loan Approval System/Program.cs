using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DE_ROXAS_Loan_Approval_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;
            int credit;
            int IncomeMax;
            int EmployStat;
            string eligibilityA = "Did Not Work";
            string eligibilityI = "Did Not Work";
            double Income;
            //

            //Credit
            double CPersonal;
            double CHome;
            double CCar;
            // After Employmentstat
            double Duration;
            // 5 Years Max
            // 30 Years Max
            // 7 Years Max
            //Monthly Install
            double Tinstall = 1;
            double Minstall = 1;
            /*
             * Acronyms:
             * P = Personal Loans
             * H = Home Loans
             * C = Car Loans
            */

            //Eligibility Test

            Console.WriteLine("Eligibility Test For Loan Qualification");
            
            //Check Age Qualification
            Console.Write("Input Your Age: ");
            age = Convert.ToInt32(Console.ReadLine());

            if (age >= 21 && age <= 25)
            {
                eligibilityA = "P";               
            }
            else if (age >= 26 && age <= 45)
            {
                eligibilityA = "PHC";             
            }
            else if (age >= 46 && age <= 65)
            {
                eligibilityA = "HC";                
            }
            else
            {
                eligibilityA = "Non Eligible";
            }

            //Income Level Qualification
            Console.Write("Input Your Month Income: ");
            Income = Convert.ToDouble(Console.ReadLine());

            if (Income < 15000)
            {
                eligibilityI = "P";
                IncomeMax = 200000;
            }
            else if (Income >= 15000 && Income <= 50000)
            {
                eligibilityI = "PC";
                IncomeMax = 1000000;
            }
            else
            {
                eligibilityI = "PHC";
                IncomeMax = 5000000;
            }

            //Credit Score Qualification
            Console.Write("Input Your Current Credit Score: ");
            credit = Convert.ToInt32(Console.ReadLine());

            if(credit > 750)
            {
                CPersonal = 0.05;
                CCar = 0.04;
                CHome = 0.03;
            }
            else if(credit >= 600 && credit <= 750)
            {
                CPersonal = 0.08;
                CCar = 0.06;
                CHome = 0.05;
            }
            else
            {
                CPersonal = 0.1;
                CCar = 0.08;
                CHome = 0.07;
            }

            //Employment Status
            Console.Write("Choose a number for the Type of Employment Status '1' [Self-Employed], '2' [Salaried]: ");
            EmployStat = Convert.ToInt32(Console.ReadLine());

            if (EmployStat == 1)
            {
                CPersonal += 0.015;
                CCar += 0.015;
                CHome += 0.015;
            }
            else if (EmployStat == 2) 
            {

            }
            else
            {
                Console.WriteLine("Error, input Correct Employment Status!");
                Console.WriteLine("Please Retry.");
                Console.ReadKey();
                Environment.Exit(1);
            }

            //Type of Loan & Duration
            Console.Write("Input the Type of Loan You are Acquiring [Personal] [Home] [Car]: ");
            string TypeLoan = Console.ReadLine();
            Console.Write("Input Solicited Loan Amount: ");
            double loan = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input the Duration of Your Loan or Loan Tenure: ");
            Duration = Convert.ToDouble(Console.ReadLine());

            //Monthly Installments:

            double RP = CPersonal / 12;
            double RH = CHome / 12;
            double RC = CCar / 12;


            if (TypeLoan == "Personal")
            {
                Tinstall = (loan * RP * (Math.Pow((1 + RP), (Duration * 12)))) / (Math.Pow((1 + RP), (Duration * 12)) + 1);
                Minstall = (IncomeMax * RP * (Math.Pow((1 + RP), (Duration * 12)))) / (Math.Pow((1 + RP), (Duration * 12)) + 1);
            }
            else if (TypeLoan == "Home")
            {
                Tinstall = (loan * RH * (Math.Pow((1 + RH), (Duration * 12)))) / (Math.Pow((1 + RH), (Duration * 12)) + 1);
                Minstall = (IncomeMax * RH * (Math.Pow((1 + RH), (Duration * 12)))) / (Math.Pow((1 + RH), (Duration * 12)) + 1);
            }
            else if (TypeLoan == "Car")
            {
                Tinstall = (loan * RC * (Math.Pow((1 + RC), (Duration * 12)))) / (Math.Pow((1 + RC), (Duration * 12)) + 1);
                Minstall = (IncomeMax * RC * (Math.Pow((1 + RC), (Duration * 12)))) / (Math.Pow((1 + RC), (Duration * 12)) + 1);
            }
            else
            {
                Console.WriteLine("Input Correct Loan Type.");
            }

           

            double Gtotal = loan + Tinstall * (Duration * 12);
            double Mtotal = IncomeMax + Minstall * (Duration * 12);



            if (Tinstall >= (Income * 0.4))
            {
                
                
                
            }
            else
            {
               
                Console.WriteLine("Your monthly loan installment exceeds the 40 percentage treshold of your monthly Income.\nPlease Input Larger monthly Income or Increase loan Duration.");
            }

            //Type And Duration Qualification
            if (TypeLoan == "Personal" && eligibilityA == "P" || eligibilityA == "PHC" && eligibilityI == "P" || eligibilityI == "PC" || eligibilityI == "PHC" && Duration <= 5)
            {
                Console.WriteLine("You are Qualified to apply for this type of Loan. \nThese are the following Specification:");
                Console.WriteLine("Maximum Possible Loan: " + IncomeMax);
                Console.WriteLine("The Interest yearly: " + CPersonal);
                Console.WriteLine("The Interest monthly: " + RP);
                Console.WriteLine("The Monthly installment for Maximum Loan: " + Minstall);
                Console.WriteLine("total cost of the loan over its lifetime: " + Mtotal);
                Console.WriteLine("The Monthly installment for Solicited Loan: " + Tinstall);
                Console.WriteLine("total cost of the loan over its lifetime: " + Gtotal);
            }
            else if(TypeLoan == "Home" && eligibilityA == "PHC" || eligibilityA == "HC" && eligibilityI == "PHC" && Duration <= 30)
            {
                Console.WriteLine("You are Qualified to apply for this type of Loan. \nThese are the following Specification:");
                Console.WriteLine("Maximum Possible Loan: " + IncomeMax);
                Console.WriteLine("The Interest yearly: " + CPersonal);
                Console.WriteLine("The Interest monthly: " + RP);
                Console.WriteLine("The Monthly installment for Maximum Loan: " + Minstall);
                Console.WriteLine("total cost of the loan over its lifetime: " + Mtotal);
                Console.WriteLine("The Monthly installment for Solicited Loan: " + Tinstall);
                Console.WriteLine("total cost of the loan over its lifetime: " + Gtotal);
            }
            else if (TypeLoan == "Car" && eligibilityA == "PHC" || eligibilityA == "HC" && eligibilityI == "PC" || eligibilityI == "PHC"  && Duration <= 7)
            {
                Console.WriteLine("You are Qualified to apply for this type of Loan. \nThese are the following Specification:");
                Console.WriteLine("Maximum Possible Loan: " + IncomeMax);
                Console.WriteLine("The Interest yearly: " + CPersonal);
                Console.WriteLine("The Interest monthly: " + RP);
                Console.WriteLine("The Monthly installment for Maximum Loan: " + Minstall);
                Console.WriteLine("total cost of the loan over its lifetime: " + Mtotal);
                Console.WriteLine("The Monthly installment for Solicited Loan: " + Tinstall);
                Console.WriteLine("total cost of the loan over its lifetime: " + Gtotal);
            }
            else if (eligibilityA == "Non Eligible")
            {
                Console.WriteLine("Sorry, You did not meet the requirements.\nPlease come and try again next time.");
                Console.ReadKey();
                Environment.Exit(1);
            }
            else
            {
                Console.WriteLine("Sorry, You did not meet the required Duration.\nPlease Input the correct Duration according to the type of loan.");
                Console.ReadKey();
                Environment.Exit(1);
            }

               

           

            // For Testing
            Console.ReadKey();
        }
    }
}
