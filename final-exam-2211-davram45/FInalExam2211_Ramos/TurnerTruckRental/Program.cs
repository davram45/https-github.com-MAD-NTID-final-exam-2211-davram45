using System;

namespace TurnerTruckRental
{
    class Program
    {
        static void Main(string[] args)
        {
            const double smallVans = 40;
            const double largeVans = 60;
            const double insurance = .09;
            const double taxRate= .075;
  

            /* Create a menu for user to read and type
             */
            Console.WriteLine("*** TURNER Truck Rental ***\n");

            // User enter the company name
            Console.Write("Please Enter your company name: ");
            string companyName = Console.ReadLine();

            // User enter their customer's name
            Console.Write("Please enter the customer's name: ");
            string customerName = Console.ReadLine();

            // User enter either S or L size van
            Console.Write("What size van do u need? ('S' for Small / 'L' for Large) ");
            string smallorLarge = Console.ReadLine();
            if (smallorLarge == " " || smallorLarge == "")
            {
                Console.WriteLine("You must enter either S or L");
            }
            if (!(smallorLarge == "s" || smallorLarge == "S" || smallorLarge == "l" || smallorLarge == "L"))
            {
                Console.WriteLine("You didn't enter either S or L");
            }
            // Calculation for small vans

            if (smallorLarge == "s" || smallorLarge == "S")
            {
                Console.Write("How many car do you need? ");
                int.TryParse(Console.ReadLine(), out int numberOfVans);
                double subtotal = numberOfVans * smallVans;
                double insuranceTotal = subtotal * insurance;
                double taxAmount = subtotal * taxRate;
                double dailyTotal = subtotal + insuranceTotal + taxAmount;

                Console.WriteLine("*** TURNER Truck Rental ***\n");
                Console.WriteLine($"Company Name:           {companyName}");
                Console.WriteLine($"Contact Name:           {customerName}\n");

                Console.WriteLine($"Order                   {numberOfVans} Small at {smallVans:C} each per day\n");
                Console.WriteLine($"Subtotal                {subtotal:C}");
                Console.WriteLine($"Insurance               {insuranceTotal:C}");
                Console.WriteLine($"Tax Amount              {taxAmount:C}");
                Console.WriteLine($"Daily Total             {dailyTotal:C}");
                Console.WriteLine("\n ==> Thnak you for using the rental estimate system");
                Console.WriteLine(" ==> Exiting...");

            }
            // Display the result for small vans calculation
            //Calculation for large Vans

            if (smallorLarge == "l" || smallorLarge == "L")
            {
                Console.Write("How many car do you need? ");
                int.TryParse(Console.ReadLine(), out int numberOfVans);
                double subtotal = numberOfVans * largeVans;
                double insuranceTotal = subtotal * insurance;
                double taxAmount = subtotal * taxRate;
                double dailyTotal = subtotal + insuranceTotal + taxAmount;

                Console.WriteLine("*** TURNER Truck Rental ***\n");
                Console.WriteLine($"Company Name:           {companyName}");
                Console.WriteLine($"Contact Name:           {customerName}\n");

                Console.WriteLine($"Order                   {numberOfVans} Large at {largeVans:C} each per day\n");
                Console.WriteLine($"Subtotal                {subtotal:C}");
                Console.WriteLine($"Insurance               {insuranceTotal:C}");
                Console.WriteLine($"Tax Amount              {taxAmount:C}");
                Console.WriteLine($"Daily Total             {dailyTotal:C}");
                Console.WriteLine("\n ==> Thnak you for using the rental estimate system");
                Console.WriteLine(" ==> Exiting...");
            }
            // Display the result for large vans calculation

        }
    }
}
