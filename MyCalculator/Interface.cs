using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculator {
    class Interface : CalcFunctions  {
        public static string pickFunction = "";
        public static void CalculatorStart() {
            Console.WriteLine("Calculator Started");
            ChooseFunction();
        }
        public static void ChooseFunction() {
            Console.Write("Enter first value: ");
            string input1 = Console.ReadLine();
            Int32.TryParse(input1, out value1);

            Console.Write("Enter second value: ");
            string input2 = Console.ReadLine();
            Int32.TryParse(input2, out value2);

            Console.WriteLine("Please Select one off the Options");

            string[] optionsArray = new string[4];
            optionsArray[0] = "Add";
            optionsArray[1] = "Minus";
            optionsArray[2] = "Multiplly";
            optionsArray[3] = "Substract";

            var showOptions = String.Join(" , ", optionsArray);
            Console.WriteLine(showOptions);

            Console.Write("Type your option here: ");
            pickFunction = Console.ReadLine();

            switch (pickFunction) {
                case "A":
                    AddNums();
                    break;
                case "M":
                    MinusNums();
                    break;
                case "MM":
                    MultNums();
                    break;
                case "D":
                    SubsNums();
                    break;
                default:
                    Console.WriteLine("Incorrect option! Try again");
                    ChooseFunction();
                    break;
            }
        }
    }
}
