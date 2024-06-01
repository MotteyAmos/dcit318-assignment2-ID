
namespace Calutor
{
    public class GradeCalculator
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
                    if (numberOfTry == 0) Console.WriteLine("Enter the student score or enter Q to quit: \n");
                  
                    userInput = Console.ReadLine();

                    if (userInput == "Q") break;

                    double score = Convert.ToDouble(userInput);
                   
                    switch (score)
                    {
                        case >= 90:
                            Console.WriteLine($"{score} --> A");
                            break;
                        case >= 80 :
                            Console.WriteLine($"{score} --> B");
                            break;
                        case >= 70:
                            Console.WriteLine($"{score} --> C");
                            break;
                        case >= 60:
                            Console.WriteLine($"{score} --> D");
                            break;
                        default:
                            Console.WriteLine($"{score} --> F");
                            break;

                    };      
                }
                catch (FormatException)
                {
                    Console.WriteLine("Input must be numeric. \n example: 100, 80.5. or enter Q to quit Try again: \n");
                    numberOfTry++;
                    continue;
                }
            } 
        }
    }
}