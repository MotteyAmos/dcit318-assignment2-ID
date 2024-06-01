
using System.Threading;

namespace Triagle
{
    public class TriagleTypeIdentifier
    {
        public static void Main(string[] args)
        {
            int numberOfTry = 0;
            string userInput = "Q";
            List<double> sides = [];
            bool quit = false;
            while (!quit && sides.Count() < 3)
            {
                
                    try
                    {
                        if (numberOfTry == 0) Console.WriteLine($"Enter side {sides.Count() +1} or enter Q to quit: \n");

                        userInput = Console.ReadLine();

                        if (userInput == "Q") break;

                        double side = Convert.ToDouble(userInput);
                        sides.Add(side);
                       numberOfTry = 0;

                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Input must be numeric. \n example: 100, 80.5. or enter Q to quit Try again: \n");
                        numberOfTry++;
                        continue;
                    }
                    if (userInput == "Q") break;



                if (userInput != "Q" && sides.Count() == 3)
                {
                    if ((sides[0] == sides[1]) && (sides[1] == sides[2]))
                    {
                        Console.WriteLine("It's an Equilateral Triangle: All three sides are equal.\n");
                    }
                    else if ((sides[0] == sides[1]) || (sides[0] == sides[2]) || (sides[1] == sides[2]))
                    {
                        Console.WriteLine("It's an Isosceles Triangle: only two sides are equal\n");
                    }
                    else
                    {
                        Console.Write("It's scalene: No sides are equal.\n");
                    }

                    sides.Clear();
                }

            }

           
        }
    }
}