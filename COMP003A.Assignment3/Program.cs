/*
* Author: Steven Gonzalez
* Course: COMP-003A
* Purpose: Numeric to letter grade using an if-else statement and Integer to string day using an switch statement
*/

namespace COMP003A.LectureActivity3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numeric to letter grade using an if-else statement");

            Console.WriteLine("Enter a numeric grade (0-100): ");

            int inputNumber = Convert.ToInt32(Console.ReadLine());
            if (inputNumber >= 0 && inputNumber <= 59)
            {
                Console.WriteLine("Letter Grade: F");
            }
            else if (inputNumber >= 0 && inputNumber <= 69)
            {
                Console.WriteLine("Letter Grade: D");
            }
            else if (inputNumber >= 70 && inputNumber <= 79)
            {
                Console.WriteLine("Letter Grade: C");
            }
            else if (inputNumber >= 80 && inputNumber <= 89)
            {
                Console.WriteLine("Letter Grade: B");
            }
            else if (inputNumber >= 90 && inputNumber <= 100)
            {
                Console.WriteLine("Letter Grade: A");
            }
            
             Console.WriteLine(inputNumber > 100 ? "Invalid Input!" : "Invalid Input!");
            
            Console.WriteLine("**********************************************");

            Console.WriteLine("Integer to string day using an switch statement");
            Console.WriteLine("Enter an integer day of the week (1-7): ");

            int NumericDay = Convert.ToInt32(Console.ReadLine());

            switch (NumericDay)
            {

                case 1: Console.WriteLine("String Day: Monday");
                    break;
                    case 2: Console.WriteLine("String Day: Tuesday");
                    break;
                    case 3: Console.WriteLine("String Day: Wednesday");
                    break;
                    case 4: Console.WriteLine("String Day: Thursday");
                    break;
                    case 5: Console.WriteLine("String Day: Friday");
                    break;
                        case 6: Console.WriteLine("String Day: Saturday");
                    break;
                    case 7: Console.WriteLine("String Day: Sunday");
                        break;
                    
                    Console.WriteLine(inputNumber > 7 ? "Invalid Day!" : "Invalid Day!");
            }



        }
    }
}
