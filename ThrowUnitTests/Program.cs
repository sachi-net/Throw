﻿using System;
using ThrowValidator.Extensions;

namespace ThrowUnitTests
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Short_Nulll(null);
            }
            catch (ArgumentException exp)
            {
                ShowException("CAUGHT BY [ArgumentException]", exp);
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

        static void ShowException(string title, Exception exp)
        {
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Write(title);
            Console.ResetColor(); Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($" {exp.Message}");
        }

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
