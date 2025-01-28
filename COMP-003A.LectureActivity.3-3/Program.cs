// Author: Gauge Garcia
// Course: COMP-003A
// Faculty: Jonathan Cruz
// Purpose: Demonstrate advanced control statements in C#.

namespace COMP_003A.LectureActivity._3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Advanced Control Statements Demo!\n");

            int range; // The range of numbers to iterate through
                       // Get the range of numbers to iterate through
            while (true)
            {
                //try- catch block to handle invalid input
                try
                {
                    //Prompt the user to enter a positive integer
                    Console.Write("Enter a positive integer to iterate through: ");
                    //Parse the input to an integer.
                    range = int.Parse(Console.ReadLine());
                    //Check if the number is positive
                    if (range <= 0) throw new Exception("Number must be positive.");
                    //Exit loop if input valit
                    break;
                }
                catch (Exception ex)
                {
                    //Display an error message and prompt user to retry
                    Console.WriteLine($"Invalid inpit: {ex.Message} \n Please try again.\n");
                }
            }
            // Get the user's preferences for skipping and ending the loop
            Console.Write("Would you like to skip a number? (yes/no): ");
            // Convert response to lowercase to make it case-insensitive
            string skipResponse = Console.ReadLine().ToLower();
            // Initialize the skip number to 0
            int skipNumber = 0;
            //Check if user wants to skip a number
            if (skipResponse == "yes")
            {
                // Prompt the user to enter the number to skip
                Console.Write("Enter the number to skip: ");
                // Parse the input to an integer
                skipNumber = int.Parse(Console.ReadLine());
            }
            //Get the users prefrences for ending loop
            Console.Write("Would you likfe to terminate the loop at a specific number? (yes/no): ");
            //Convert the response to lowercase to make it case insensitive
            string terminateResponse = Console.ReadLine().ToLower();
            //Initialize the termination number to 0
            int terminateNumber = 0;
            //Check if user wants to terminate the loop
            if (terminateResponse == "yes")
            {
                //Prompt the user to enter the termination number
                Console.Write("Enter the termination number: ");
                //Parse the input to an integer
                terminateNumber = int.Parse(Console.ReadLine());
            }
            //Display Output
            Console.WriteLine("\nOutput:");
            //Iterate through the range of numbers
            for (int i = 1; i <= range; i++)
            {
                //Check is the current number is the number to skip
                if (i == skipNumber)
                {
                    continue;// Skip the specified number
                }
                //Check if current number is number to terminate at
                if (i == terminateNumber)
                {
                    //Display message and break out of the loop
                    Console.Write($"Loop terminated at {terminateNumber}.");
                    break;// Terminate the loop
                }

                //Display the current number
                Console.WriteLine(i);
            }

            // Prompt the user to restart the program
            Console.Write("Enter 'restart' to try again or any other key to exit: ");
            // Convert the response to lowercase to make it case-insensititive
            string restart = Console.ReadLine().ToLower();

            //Check if user wants to restart program
            if (restart == "restart")
            {
                // Restart the program
                goto Restart;
            }
        //Label to restart program
        Restart:
            // Display a message and restart program
            Console.WriteLine("Restarting the Program... \n");
            //Restart Program
            Main(args); //Restart the Program
        }
    }
}
