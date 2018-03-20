using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculator {
    class CalcFunctions {
        public static int finalResult = 0;
        public static int value1 = 0;
        public static int value2 = 0;

        public static void CalculateStart() {
            Console.Write("Enter first value: ");
            string input1 = Console.ReadLine();
            Int32.TryParse(input1, out value1);

            Console.Write("Enter first value: ");
            string input2 = Console.ReadLine();
            Int32.TryParse(input2, out value2);

            Console.WriteLine(Interface.pickFunction);
        }

        public static void AddNums() {
            finalResult = (value1 + value2);
            Console.WriteLine(finalResult);
            Console.WriteLine("To try again press Enter");
            Interface.ChooseFunction();
        }

        public static void MinusNums() {
            finalResult = value1 - value2;
            Console.WriteLine(finalResult);
            Console.WriteLine("To try again press Enter");
            Interface.ChooseFunction();
        }

        public static void MultNums() {
            finalResult = value1 * value2;
            Console.WriteLine(finalResult);
            Console.WriteLine("To try again press Enter");
            Interface.ChooseFunction();
        }

        public static void SubsNums() {
            finalResult = value1 / value2;
            Console.WriteLine(finalResult);
            Console.WriteLine("To try again press Enter");
            Interface.ChooseFunction();
        }
    }
}
