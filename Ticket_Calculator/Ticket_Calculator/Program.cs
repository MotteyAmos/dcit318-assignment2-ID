

namespace Calutor
{
    public class TicketCalculator
    {
        public static void Main(string[] args)
        {
            int numberOfTry = 0;
            string userInput;
            bool quit = false;
            while (!quit)
            {
                try
                {
                    if (numberOfTry == 0) Console.WriteLine("Enter the customer age or enter Q to quit: \n");

                    userInput = Console.ReadLine();

                    if (userInput == "Q") break;

                    int age = Convert.ToInt32(userInput);

                    switch (age)
                    {
                        case >= 65:
                            Console.WriteLine($"Age {age} --> GHC 7");
                            break;
                        case <= 12:
                            Console.WriteLine($"Age {age} --> GHC 7");
                            break;
                        default:
                            Console.WriteLine($"Age {age} --> GHC 10");
                            break;

                    };
                }
                catch (FormatException)
                {
                    Console.WriteLine("Input must be numeric. \n example: 100,12,38  or enter Q to quit Try again: \n");
                    numberOfTry++;
                    continue;
                }
            }
        }
    }
}