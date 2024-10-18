using System;

namespace Mix_Match_Samaniego__De_Roxas
{
    internal class Program
    {
        static void Main(string[] args)
        {


            double price = 150.00;
            double sen = 0.2;

            //Main dish
            String meal1 = "1-Piece Chicken Joy";
            String meal2 = "Jolly Spaghetti";
            String meal3 = "Burger Steak";


            //Side dish
            String side1 = "French fries";
            String side2 = "Mashed potato";
            String side3 = "Buttered corn";

            //Drinks
            String drink1 = "Coke";
            String drink2 = "Sprite";
            String drink3 = "Iced Tea";


            Console.WriteLine("Welcome to JohnnyBee Mix&&Match ");
            Console.WriteLine("Choose main dish ");
            Console.WriteLine("Meal 1 :" + meal1);
            Console.WriteLine("Meal 2 :" + meal2);
            Console.WriteLine("Meal 3 :" + meal3);
            Console.Write("Input Selected Meal: ");
            String mealChoice = Console.ReadLine();

            String selectedMeal = "";
            String selectedSide = "";
            String selectedDrink = "";

            switch (mealChoice)
            {
                case "Meal 1":
                    selectedMeal = meal1;
                    break;

                case "Meal 2":
                    selectedMeal = meal2;
                    break;

                case "Meal 3":
                    selectedMeal = meal3;
                    break;


                default:
                    Console.WriteLine("Invalid meal selection. Exiting...");
                    Console.ReadKey();
                    return;

            }

            Console.WriteLine("Choose side dish");
            Console.WriteLine("Side 1 :" + side1);
            Console.WriteLine("Side 2 :" + side2);
            Console.WriteLine("Side 3 :" + side3);
            Console.Write("Input Selected Meal: ");
            String sideChoice = Console.ReadLine();

            switch (sideChoice)
            {
                case "Side 1":
                    selectedSide = side1;
                    break;

                case "Side 2":
                    selectedSide = side2;
                    break;

                case "Side 3":
                    selectedSide = side3;
                    break;


                default:
                    Console.WriteLine("Invalid side selection. Exiting...");
                    Console.ReadKey();
                    return;

            }

            Console.WriteLine("Choose drinks");
            Console.WriteLine("Drink 1 :" + drink1);
            Console.WriteLine("Drink 2 :" + drink2);
            Console.WriteLine("Drink 3 :" + drink3);
            Console.Write("Input Selected Meal: ");
            String drinkChoice = Console.ReadLine();

            switch (drinkChoice)
            {
                case "Drink 1":
                    selectedDrink = drink1;
                    break;

                case "Drink 2":
                    selectedDrink = drink2;
                    break;

                case "Drink 3":
                    selectedDrink = drink3;
                    break;


                default:
                    Console.WriteLine("Invalid drink selection. Exiting...");
                    Console.ReadKey();
                    return;

            }

            Console.Write("How many sets of Jhonnybee Mix and Match?: ");
            double sets = Convert.ToDouble(Console.ReadLine());

            String choice = "";
            Console.WriteLine("Are you a Senior Citizen? (Yes / No)");
            choice = Console.ReadLine().ToLower();

            if (choice == "yes")
            {
                price *= sets;
                price = price - (price * sen);
                Console.WriteLine("Your order is " + selectedMeal + ", " + selectedSide + ", and " + selectedDrink);
                double deprice = Math.Round(price, 2);
                string deplaces = String.Format("{0:0.00}", deprice);
                Console.WriteLine("Your Total is: " + deplaces + " pesos");
                Console.WriteLine("Thank you for ordering at JohnnyBee! Please come again next time.");
                Console.ReadKey();

            }
            else if (choice == "no")
            {
                price *= sets;
                Console.WriteLine("Your order is " + selectedMeal + ", " + selectedSide + ", and " + selectedDrink);
                double deprice = Math.Round(price, 2);
                string deplaces = String.Format("{0:0.00}", deprice);
                Console.WriteLine("Your Total is: " + deplaces + " pesos");
                Console.WriteLine("Thank you for ordering at JohnnyBee! Please come again next time.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Invalid Input. Exiting....");
                Console.ReadKey();
            }
            Console.ReadKey();


        }
    }
}
