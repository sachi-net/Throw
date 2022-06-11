using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using ThrowValidator.Exceptions;
using ThrowValidator.Extensions;

namespace ThrowUnitTests
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<Person> people = new List<Person>
                {
                    new Person { Name = "Sachintha", Address = "Aluthgama", Age = 28, IsMarried = false },
                    new Person { Name = "Thisaru", Address = "Aluthgama", Age = 24, IsMarried = false },
                    new Person { Name = "Sanoj", Address = "Kalutara", Age = 30, IsMarried = true },
                    new Person { Name = "Rabidu", Address = "Galle", Age = 32, IsMarried = true },
                    new Person { Name = "Ravindu", Address = "Aluthgama", Age = 27, IsMarried = false },
                    new Person { Name = "Subodha", Address = "Pannipitiya", Age = 27, IsMarried = true },
                    new Person { Name = "Ravinga", Address = "Panadura", Age = 22, IsMarried = false },
                    new Person { Name = "Gayani", Address = "Ambalangoda", Age = 27, IsMarried = true },
                    new Person { Name = "Piyumi", Address = "Weligama", Age = 29, IsMarried = false }
                };

                TypeVal(people[0].Name.GetType());
            }
            catch (ArgumentException exp)
            {
                ShowException("CAUGHT BY [ArgumentException]", exp);
            }
            catch (OverflowException exp)
            {
                ShowException("CAUGHT BY [OverflowException]", exp);
            }
            catch (ConditionNotMeetException exp)
            {
                ShowException("CAUGHT BY [ConditionNotMeetException]", exp);
            }
            catch (Exception exp)
            {
                ShowException("[Exception]", exp);
            }

            Console.ReadKey();

            Person x = null;
            x.Throw();
        }

        static void Show(string message)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        static void Write(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.Write(text);
        }

        static void ShowException(string title, Exception exp)
        {
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Write(title);
            Console.ResetColor(); Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($" {exp.Message}");
        }

        static void Rainbow()
        {
            Write("|||||", ConsoleColor.DarkRed);
            Write("|||||", ConsoleColor.Red);
            Write("|||||", ConsoleColor.Yellow);
            Write("|||||", ConsoleColor.Green);
            Write("|||||", ConsoleColor.Blue);
            Write("|||||", ConsoleColor.DarkBlue);
            Write("|||||", ConsoleColor.Magenta);
        }

        #region Numeric types
        // Integrals
        static void Sbyte(sbyte age)
        {
            age.Run(Rainbow)
                .WhenZero()
                .WhenEqualTo(30)
                .WhenLessThan(15)
                .WhenGreaterThan(80)
                .WhenNegative();

            Show(string.Format("Age is {0}", age));
        }

        static void Sbyte_Null(sbyte? age)
        {
            age.Run(Rainbow)
                .WhenZero()
                .WhenNull()
                .WhenEqualTo(30)
                .When(() => age / 10 > 5)
                .WhenLessThan(24);

            Show(string.Format("Age is {0}", age));
        }

        static void Byte(byte age)
        {
            age.Run(Rainbow)
                .WhenZero()
                .WhenEqualTo(30)
                .WhenLessThan(15)
                .WhenGreaterThan(80)
                .WhenNegative();

            Show(string.Format("Age is {0}", age));
        }

        static void Byte_Null(byte? age)
        {
            age.Run(Rainbow)
                .WhenZero()
                .WhenNull()
                .WhenEqualTo(30)
                .When(() => age / 10 > 5)
                .WhenLessThan(24);

            Show(string.Format("Age is {0}", age));
        }

        static void Short(short age)
        {
            age.Run(Rainbow)
                .WhenZero()
                .WhenEqualTo(30)
                .WhenLessThan(15)
                .WhenGreaterThan(80)
                .WhenNegative();

            Show(string.Format("Age is {0}", age));
        }

        static void Short_Nulll(short? age)
        {
            age.Run(Rainbow)
                .WhenZero()
                .WhenNull()
                .WhenEqualTo(30)
                .When(() => age / 10 > 5)
                .WhenLessThan(24);

            Show(string.Format("Age is {0}", age));
        }

        static void Ushort(ushort age)
        {
            age.Run(Rainbow)
                .WhenZero()
                .WhenEqualTo(30)
                .WhenLessThan(15)
                .WhenGreaterThan(80)
                .WhenNegative();

            Show(string.Format("Age is {0}", age));
        }

        static void Ushort_Null(ushort? age)
        {
            age.Run(Rainbow)
                .WhenZero()
                .WhenNull()
                .WhenEqualTo(30)
                .When(() => age / 10 > 5)
                .WhenLessThan(24);

            Show(string.Format("Age is {0}", age));
        }

        static void Int(int age)
        {
            age.Run(Rainbow)
                .WhenZero()
                .WhenEqualTo(30)
                .WhenLessThan(15)
                .WhenGreaterThan(80)
                .WhenNegative();

            Show(string.Format("Age is {0}", age));
        }

        static void Int_Null(int? age)
        {
            age.Run(Rainbow)
                .WhenZero()
                .WhenNull()
                .WhenEqualTo(30)
                .When(() => age / 10 > 5)
                .WhenLessThan(24);

            Show(string.Format("Age is {0}", age));
        }

        static void Uint(uint age)
        {
            age.Run(Rainbow)
                .WhenZero()
                .WhenEqualTo(30)
                .WhenLessThan(15)
                .WhenGreaterThan(80)
                .WhenNegative();

            Show(string.Format("Age is {0}", age));
        }

        static void Uint_Null(uint? age)
        {
            age.Run(Rainbow)
                .WhenZero()
                .WhenNull()
                .WhenEqualTo(30)
                .When(() => age / 10 > 5)
                .WhenLessThan(24);

            Show(string.Format("Age is {0}", age));
        }

        static void Long(long age)
        {
            age.Run(Rainbow)
                .WhenZero()
                .WhenEqualTo(30)
                .WhenLessThan(15)
                .WhenGreaterThan(80)
                .WhenNegative();

            Show(string.Format("Age is {0}", age));
        }

        static void Long_Null(long? age)
        {
            age.Run(Rainbow)
                .WhenZero()
                .WhenNull()
                .WhenEqualTo(30)
                .When(() => age / 10 > 5)
                .WhenLessThan(24);

            Show(string.Format("Age is {0}", age));
        }

        static void Ulong(ulong age)
        {
            age.Run(Rainbow)
                .WhenZero()
                .WhenEqualTo(30)
                .WhenLessThan(15)
                .WhenGreaterThan(80)
                .WhenNegative();

            Show(string.Format("Age is {0}", age));
        }

        static void Ulong_Null(ulong? age)
        {
            age.Run(Rainbow)
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
            salary.Run(Rainbow)
                .WhenZero()
                .WhenEqualTo(50000)
                .When(() => salary / 25 < 40)
                .WhenGreaterThanOrEqualTo(350000)
                .WhenNegative();

            Show(string.Format("Salary is LKR {0}", salary));
        }

        static void Float_Null(float? salary)
        {
            salary.Run(Rainbow)
                .WhenZero()
                .WhenNull()
                .WhenEqualTo(50000)
                .When(() => salary / 25 < 40)
                .WhenGreaterThanOrEqualTo(350000);

            Show(string.Format("Salary is LKR {0}", salary));
        }

        static void Double(double salary)
        {
            salary.Run(Rainbow)
                .WhenZero()
                .WhenEqualTo(2500)
                .When(() => salary / 25 < 40)
                .WhenOutOfRange(2000, 3000, Boundary.RightOnly);

            Show(string.Format("Salary is LKR {0}", salary));
        }

        static void Double_Null(double? salary)
        {
            salary.Run(Rainbow)
                .WhenZero()
                .WhenNull()
                .WhenEqualTo(2500)
                .WhenOutOfRange(2000, 3000, Boundary.RightOnly)
                .When(() => salary / 25 < 40);

            Show(string.Format("Salary is LKR {0}", salary));
        }

        static void Decimal(decimal salary)
        {
            salary.Run(Rainbow)
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
            salary.Run(Rainbow)
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
            name.Run(Rainbow)
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
            dateTime.Run(Rainbow)
                .WhenInRange(new(2022, 1, 1), new(2022, 12, 31), Boundary.Inclusive)
                .WhenEqualTo(new(1993, 11, 8))
                .WhenGreaterThanOrEqualTo(DateTime.Now.Date.AddYears(5))
                .WhenLessThanOrEqualTo(DateTime.Now.Date.AddYears(-5));

            Show(string.Format("DateTime is {0}", dateTime.ToString("yyyy-MM-dd hh:mm:ss tt")));
        }

        static void DateTime_Null_Val(DateTime? dateTime)
        {
            dateTime.Run(Rainbow)
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
            value.Run(Rainbow)
                .WhenFalse()
                .When(() => 5 + 3 == -8);

            Show(string.Format("Value is {0}", value));
        }

        static void Bool_Null(bool? value)
        {
            value.Run(Rainbow)
                .WhenNull()
                .WhenTrue()
                .When(() => 5 + 3 == -8);

            Show(string.Format("Value is {0}", value));
        }
        #endregion

        #region Enum
        static void Enums(Boundary? boundary)
        {
            boundary.Run(Rainbow)
                .WhenNull()
                .When(() => 3 == 3 - 5)
                .WhenOutOfRange(0)
                .WhenEqualTo(Boundary.Exclusive);

            Show(string.Format("Enum is {0}", boundary));
        }
        #endregion

        #region Custom
        static void Custom(Person person)
        {
            person.Run(Rainbow)
                .WhenNull()
                .When(p => !p.IsMarried && p.Age > 35, "Come-on man... you still haven't married.")
                .WhenNot(p => p.Age >= 13, "This is for teenagers only.");

            Show(string.Format("{0} from {1} is {2} years old.", 
                person.Name, person.Address, person.Age));
        }
        #endregion

        #region Collections
        static void Collection(ICollection<Person> list)
        {
            var me = new Person { Name = "Sachintha", Address = "Aluthgama", Age = 28, IsMarried = false };

            list.Run(Rainbow)
                .WhenNull()
                .WhenEmpty()
                .WhenAny(p => p.Age >= 28 && !p.IsMarried)
                .WhenNotContain(me);

            Show(string.Format("List item count is {0}.", list.Count));
        }
        #endregion

        #region Type
        static void TypeVal(Type type)
        {
            type.Run(Rainbow)
                .WhenNull()
                .WhenEqualTo(typeof(string));

            Show(string.Format("Type is {0}.", type.FullName));
        }
        #endregion
    }
}
