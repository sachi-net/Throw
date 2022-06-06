using System;
using System.Text.RegularExpressions;
using ThrowValidator.Extensions;

namespace ThrowUnitTests
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Enum a = Boundary.Inclusive;
                Console.WriteLine(a.ToString() == Boundary.Inclusive.ToString());

                Enums(Boundary.RightOnly);
            }
            catch (ArgumentException exp)
            {
                ShowException("CAUGHT BY [ArgumentException]", exp);
            }
            catch (Exception exp)
            {
                ShowException("[Exception]", exp);
            }

            Console.ReadKey();
        }

        static void Show(string message)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        static void ShowException(string title, Exception exp)
        {
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Write(title);
            Console.ResetColor(); Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($" {exp.Message}");
        }

        #region Numeric types
        // Integrals
        static void Sbyte(sbyte age)
        {
            age.Throw()
                .WhenZero()
                .WhenEqualTo(30)
                .WhenLessThan(15)
                .WhenGreaterThan(80)
                .WhenNegative();

            Show(string.Format("Age is {0}", age));
        }

        static void Sbyte_Null(sbyte? age)
        {
            age.Throw()
                .WhenZero()
                .WhenNull()
                .WhenEqualTo(30)
                .When(() => age / 10 > 5)
                .WhenLessThan(24);

            Show(string.Format("Age is {0}", age));
        }

        static void Byte(byte age)
        {
            age.Throw()
                .WhenZero()
                .WhenEqualTo(30)
                .WhenLessThan(15)
                .WhenGreaterThan(80)
                .WhenNegative();

            Show(string.Format("Age is {0}", age));
        }

        static void Byte_Null(byte? age)
        {
            age.Throw()
                .WhenZero()
                .WhenNull()
                .WhenEqualTo(30)
                .When(() => age / 10 > 5)
                .WhenLessThan(24);

            Show(string.Format("Age is {0}", age));
        }

        static void Short(short age)
        {
            age.Throw()
                .WhenZero()
                .WhenEqualTo(30)
                .WhenLessThan(15)
                .WhenGreaterThan(80)
                .WhenNegative();

            Show(string.Format("Age is {0}", age));
        }

        static void Short_Nulll(short? age)
        {
            age.Throw()
                .WhenZero()
                .WhenNull()
                .WhenEqualTo(30)
                .When(() => age / 10 > 5)
                .WhenLessThan(24);

            Show(string.Format("Age is {0}", age));
        }

        static void Ushort(ushort age)
        {
            age.Throw()
                .WhenZero()
                .WhenEqualTo(30)
                .WhenLessThan(15)
                .WhenGreaterThan(80)
                .WhenNegative();

            Show(string.Format("Age is {0}", age));
        }

        static void Ushort_Null(ushort? age)
        {
            age.Throw()
                .WhenZero()
                .WhenNull()
                .WhenEqualTo(30)
                .When(() => age / 10 > 5)
                .WhenLessThan(24);

            Show(string.Format("Age is {0}", age));
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

        static void Uint(uint age)
        {
            age.Throw()
                .WhenZero()
                .WhenEqualTo(30)
                .WhenLessThan(15)
                .WhenGreaterThan(80)
                .WhenNegative();

            Show(string.Format("Age is {0}", age));
        }

        static void Uint_Null(uint? age)
        {
            age.Throw()
                .WhenZero()
                .WhenNull()
                .WhenEqualTo(30)
                .When(() => age / 10 > 5)
                .WhenLessThan(24);

            Show(string.Format("Age is {0}", age));
        }

        static void Long(long age)
        {
            age.Throw()
                .WhenZero()
                .WhenEqualTo(30)
                .WhenLessThan(15)
                .WhenGreaterThan(80)
                .WhenNegative();

            Show(string.Format("Age is {0}", age));
        }

        static void Long_Null(long? age)
        {
            age.Throw()
                .WhenZero()
                .WhenNull()
                .WhenEqualTo(30)
                .When(() => age / 10 > 5)
                .WhenLessThan(24);

            Show(string.Format("Age is {0}", age));
        }

        static void Ulong(ulong age)
        {
            age.Throw()
                .WhenZero()
                .WhenEqualTo(30)
                .WhenLessThan(15)
                .WhenGreaterThan(80)
                .WhenNegative();

            Show(string.Format("Age is {0}", age));
        }

        static void Ulong_Null(ulong? age)
        {
            age.Throw()
                .WhenZero()
                .WhenNull()
                .WhenEqualTo(30)
                .When(() => age / 10 > 5)
                .WhenLessThan(24);

            Show(string.Format("Age is {0}", age));
        }

        // Floats
        static void Float(float salary)
        {
            salary.Throw()
                .WhenZero()
                .WhenEqualTo(50000)
                .When(() => salary / 25 < 40)
                .WhenGreaterThanOrEqualTo(350000)
                .WhenNegative();

            Show(string.Format("Salary is LKR {0}", salary));
        }

        static void Float_Null(float? salary)
        {
            salary.Throw()
                .WhenZero()
                .WhenNull()
                .WhenEqualTo(50000)
                .When(() => salary / 25 < 40)
                .WhenGreaterThanOrEqualTo(350000);

            Show(string.Format("Salary is LKR {0}", salary));
        }

        static void Double(double salary)
        {
            salary.Throw()
                .WhenZero()
                .WhenEqualTo(2500)
                .When(() => salary / 25 < 40)
                .WhenOutOfRange(2000, 3000, Boundary.RightOnly);

            Show(string.Format("Salary is LKR {0}", salary));
        }

        static void Double_Null(double? salary)
        {
            salary.Throw()
                .WhenZero()
                .WhenNull()
                .WhenEqualTo(2500)
                .WhenOutOfRange(2000, 3000, Boundary.RightOnly)
                .When(() => salary / 25 < 40);

            Show(string.Format("Salary is LKR {0}", salary));
        }

        static void Decimal(decimal salary)
        {
            salary.Throw()
                .WhenZero()
                .WhenEqualTo(2500)
                .When(() => salary / 25 < 40)
                .WhenGreaterThanOrEqualTo(350000)
                .WhenNegative()
                .WhenInRange(2000, 3000, Boundary.LeftOnly);

            Show(string.Format("Salary is LKR {0}", salary));
        }

        static void Decimal_Null(decimal? salary)
        {
            salary.Throw()
                .WhenZero()
                .WhenNull()
                .WhenEqualTo(2500)
                .When(() => salary / 25 < 40)
                .WhenGreaterThanOrEqualTo(350000)
                .WhenInRange(2000, 3000, Boundary.LeftOnly);

            Show(string.Format("Salary is LKR {0}", salary));
        }
        #endregion

        #region String
        static void String(string name)
        {
            name.Throw()
                .WhenNull()
                .WhenEmpty()
                .WhenWhiteSpaces()
                .When(() => name.Contains("ABC"))
                .WhenNotMatchWith(new Regex(@"^[a-z]+$", RegexOptions.IgnoreCase))
                .WhenNotContain("NTHA", StringComparison.OrdinalIgnoreCase)
                .WhenStartWith("A")
                .WhenNotStartWith("s", StringComparison.OrdinalIgnoreCase)
                .WhenEndWith("Z")
                .WhenNotEndWith("A", StringComparison.OrdinalIgnoreCase)
                .WhenLengthEqualTo(20);

            Show(string.Format("Name is {0}", name));
        }
        #endregion

        #region DateTime
        static void DateTimeVal(DateTime dateTime)
        {
            dateTime.Throw()
                .WhenInRange(new(2022, 1, 1), new(2022, 12, 31), Boundary.Inclusive)
                .WhenEqualTo(new(1993, 11, 8))
                .WhenGreaterThanOrEqualTo(DateTime.Now.Date.AddYears(5))
                .WhenLessThanOrEqualTo(DateTime.Now.Date.AddYears(-5));

            Show(string.Format("DateTime is {0}", dateTime.ToString("yyyy-MM-dd hh:mm:ss tt")));
        }

        static void DateTime_Null_Val(DateTime? dateTime)
        {
            dateTime.Throw()
                .When(() => 5 + 3 == -8)
                .WhenOutOfRange(new(2022, 5, 10), new(2022, 5, 20), Boundary.LeftOnly)
                .WhenEqualTo(new(1993, 11, 8))
                .WhenNull()
                .WhenGreaterThanOrEqualTo(DateTime.Now.Date.AddYears(5))
                .WhenLessThanOrEqualTo(DateTime.Now.Date.AddYears(-5));

            Show(string.Format("DateTime is {0}", ((DateTime)dateTime).ToString("yyyy-MM-dd hh:mm:ss tt")));
        }
        #endregion

        #region Boolean
        static void Bool(bool value)
        {
            value.Throw()
                .WhenFalse()
                .When(() => 5 + 3 == -8);

            Show(string.Format("Value is {0}", value));
        }

        static void Bool_Null(bool? value)
        {
            value.Throw()
                .WhenNull()
                .WhenTrue()
                .When(() => 5 + 3 == -8);

            Show(string.Format("Value is {0}", value));
        }
        #endregion

        #region Enum
        static void Enums(Boundary? boundary)
        {
            boundary.Throw()
                .WhenNull()
                .When(() => 3 == 3 - 5)
                .WhenOutOfRange(0)
                .WhenEqualTo(Boundary.Exclusive);

            Show(string.Format("Enum is {0}", boundary));
        }
        #endregion
    }
}
