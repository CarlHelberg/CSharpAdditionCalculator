using System;
using System.Collections.Generic;
using System.Linq;


namespace basicCalculator
{
    public class App
    {
        public static void Main(string[] args)
        {
            bool firstValuecheck = false;
            bool secondValuecheck = false;
            double numValue1 = 0;
            double numValue2 = 0;
            string numModifier = ("");
            while (firstValuecheck == false)
            {
                Console.WriteLine("Please input the first value");
                string value1 = Console.ReadLine();

                try
                {
                    numValue1 = Convert.ToDouble(value1);
                    firstValuecheck = true;
                }
                catch
                {
                    Console.WriteLine("The first Value was not valid");
                    firstValuecheck = false;
                }
            }
            Console.WriteLine("Please input an Operation for the two values");
            Console.WriteLine("The following options are available: + - * /");
            numModifier = Console.ReadLine();

            while (secondValuecheck == false)
            {
                Console.WriteLine("Please input the second value");
                string value2 = Console.ReadLine();

                try
                {
                    numValue2 = Convert.ToDouble(value2);
                    secondValuecheck = true;
                }

                catch
                {
                    Console.WriteLine("The second Value was not valid");
                    secondValuecheck = false;
                }
            }



            if (firstValuecheck == true && secondValuecheck == true)
            {
                Console.WriteLine(numValue1 + " " + numModifier + " " + numValue2 + " ");

                switch (numModifier)
                {
                    case "+":
                        Console.WriteLine(numValue1 + numValue2);
                        break;
                    case "-":
                        Console.WriteLine(numValue1 - numValue2);
                        break;
                    case "/":
                        Console.WriteLine(numValue1 / numValue2);
                        break;
                    default:
                        Console.WriteLine(numValue1 * numValue2);
                        break;
                }
            }
            else
            {
                Console.WriteLine("Did not run successful");
            }
            Console.Read();

        }
    }
}