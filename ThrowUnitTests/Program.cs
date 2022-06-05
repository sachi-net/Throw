using System;
using ThrowValidator.Extensions;

namespace ThrowUnitTests
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Double_Null(null);
            }
            catch (ArgumentException exp)
            {
                Console.ResetColor();
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("CAUGHT BY [ArgumentException]: {0}", exp.Message);
            }
            catch (Exception exp)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(exp.Message);
            }

            Console.ReadKey();
        }

        static void Show(string message)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        static void Int(int age)
        {
            age.Throw()
                .WhenZero()
                .WhenEqualTo(30)
                .WhenLessThan(15)
                .WhenGreaterThan(80)
                .WhenNegative();

            Show(string.Format("Age is {0}", age));
        }

        static void Int_Null(int? age)
        {
            age.Throw()
                .WhenZero()
                .WhenNull()
                .WhenEqualTo(30)
                .When(() => age / 10 > 5)
                .WhenLessThan(24);

            Show(string.Format("Age is {0}", age));
        }

        static void Double(double salary)
        {
            salary.Throw()
                .WhenZero()
                .WhenEqualTo(50000)
                .When(() => salary / 25 < 40)
                .WhenGreaterThanOrEqualTo(350000);

            Show(string.Format("Salary is LKR {0}", salary));
        }

        static void Double_Null(double? salary)
        {
            salary.Throw()
                .WhenZero()
                .WhenNull()
                .WhenEqualTo(50000)
                .When(() => salary / 25 < 40)
                .WhenGreaterThanOrEqualTo(350000);

            Show(string.Format("Salary is LKR {0}", salary));
        }
    }
}
