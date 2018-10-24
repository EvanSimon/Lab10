using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLab10
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            bool response = true;
            while (response == true)
            {

                Console.WriteLine("Welcome to the Circle Tester");

                Console.WriteLine("Enter radius");
                double UserInput = double.Parse(Console.ReadLine());

                Circle myCircle = new Circle(UserInput);

                Console.WriteLine($"Circumfrance: {myCircle.CaluculateCircumference()}");
                Console.WriteLine($"Circumfrance:{myCircle.CaluculateFormattedCircumference()}");

                Console.WriteLine($"Area: {myCircle.CalculateArea()}");
                Console.WriteLine($"Area: {myCircle.CalculatedFormatedArea()}");
              
                i++;
                Console.WriteLine($"Circles:{i}");

                response = GetYorN();


            }

            
        }

        public static bool GetYorN()
        {
            
            while (true)
            {
                Console.WriteLine("Would you like to continue y/n ?");
                string answer = Console.ReadLine().ToLower();

                if (answer == "y") //if yes it breaks this loops and the false function runs it back to the top of the program loop
                {
                  
                    break;
                }

                else if (answer == "n")//if no it breaks the loop agian but true function ends the program; n
                {

                   return false;
                }


                else if (answer != "y" || answer != "n") //if anything other then y or n it continues to ask the user
                {
                    
                    continue;
                }

            }

            return true;
        }

    }
}