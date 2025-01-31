/*
 Author: Arun Kanjirathingal Joyson
 Date: 29 January 2025
 Project: Arun_As1_Task_1
  
 Description:
 This program calculates the total money Carlo spent on his business trips. 
 Since he always returns to Toronto before making another trip, each trip cost is a round-trip.
 It calculates the total travel expenses and the average cost per trip.
  
 Concepts used: Constants, variables, user input, loops, arithmetic operations, and formatted output.
 */

using System;

namespace AssignmentOne
{
    class Program
    {


        static void Main(string[] args)
        {
            //Variable declaration
            string input;
            int totalCost;
            int totalTrips;
            double averageCost;
            // Displays welcome message
            Console.WriteLine("Welcome to the Business Travel Expense Calculator!");
            Console.WriteLine("Carlo always returns to Toronto before making another trip.");
            Console.WriteLine("Let's calculate his total travel expenses.\n");

            // Define round-trip ticket prices for the 3 locations
            const int ROUND_TRIP_CALGARY = 1350 * 2;
            const int ROUND_TRIP_VANCOUVER = 1500 * 2;
            const int ROUND_TRIP_MONTREAL = 575 * 2;

            while (true) // Loop concept for multiple calculations
            {
                int tripsToCalgary = -1, tripsToVancouver = -1, tripsToMontreal = -1;

                // Ask user for the number of trips to Calgary
                while (tripsToCalgary < 0)
                {
                    Console.Write("Enter the number of trips to Calgary: ");
                    input = Console.ReadLine();

                    try
                    {
                        tripsToCalgary = Convert.ToInt32(input);
                        if (tripsToCalgary < 0)
                        {
                            Console.WriteLine("Invalid input. Please enter a non-negative whole number.");
                            tripsToCalgary = -1; // Reset back to starting value
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                    }
                }

                // Ask user for the number of trips to Vancouver
                while (tripsToVancouver < 0)
                {
                    Console.Write("Enter the number of trips to Vancouver: ");
                    input = Console.ReadLine();

                    try
                    {
                        tripsToVancouver = Convert.ToInt32(input);
                        if (tripsToVancouver < 0)
                        {
                            Console.WriteLine("Invalid input. Please enter a non-negative whole number.");
                            tripsToVancouver = -1; // Reset back to starting value
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                    }
                }

                // Ask user for the number of trips to Montreal
                while (tripsToMontreal < 0)
                {
                    Console.Write("Enter the number of trips to Montreal: ");
                    input = Console.ReadLine();

                    try
                    {
                        tripsToMontreal = Convert.ToInt32(input);
                        if (tripsToMontreal < 0)
                        {
                            Console.WriteLine("Invalid input. Please enter a non-negative whole number.");
                            tripsToMontreal = -1; // Reset back to starting value
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                    }
                }

                // Calculate total cost
                totalCost = (tripsToCalgary * ROUND_TRIP_CALGARY) +
                                (tripsToVancouver * ROUND_TRIP_VANCOUVER) +
                                (tripsToMontreal * ROUND_TRIP_MONTREAL);

                // Calculate total number of trips
                totalTrips = tripsToCalgary + tripsToVancouver + tripsToMontreal;

                // Calculate average cost per trip (avoid division by zero)

                if (totalTrips > 0)
                {
                    averageCost = (double)totalCost / totalTrips;  // Calculate average if trips are more than 0
                }
                else
                {
                    averageCost = 0;  // Set average to 0 if there are no trips
                }

                // Display results
                Console.WriteLine("\nSummary of Travel Expenses:");
                // Displaying the results with formatted output
                Console.WriteLine($"Total money spent: ${totalCost:F2}");  // Format totalCost as currency with no decimals
                Console.WriteLine($"Total trips taken: {totalTrips:N0}");  // Format totalTrips as a number with no decimals
                Console.WriteLine($"Average cost per trip: ${averageCost:F2}");  // Format averageCost with 2 decimal places

                // Ask the user if they want to calculate again
                Console.Write("\nWould you like to calculate again? (Enter 'y' to continue, any other key to exit): ");
                string userResponse = Console.ReadLine().ToLower();

                if (userResponse != "y")
                {
                    Console.WriteLine("Thank you for using the Business Travel Expense Calculator! Goodbye!");
                    break; // Exit loop
                }

                Console.WriteLine(); // Add spacing before the next input
            }
        }
    }
}
