using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static Project.logic;
namespace Project
{
    class Tests
    {
        public static int CountTestsPassed = 0;
        public static int CountTestsFailed = 0;
        public static bool TEST(string nameTest, Func<string, bool> testMethod, string data, bool value)
        {
            bool res = testMethod(data);
            if (res != value)
            {
                System.Console.Write($"{nameTest}  crash. With a value of ({data}), expected the {value}, got the {res}\n");
                CountTestsFailed++;
                return false;
            }
            CountTestsPassed++;
            return true;
        }
        public static bool TEST(string nameTest, Func<string, string, bool> testMethod, string data1, string data2, bool value)
        {
            bool res = testMethod(data1, data2);
            if (res != value)
            {
                System.Console.Write($"{nameTest}  crash. With a value of ({data1}, {data2}), expected the {value}, got the {res}\n");
                CountTestsFailed++;
                return false;
            }
            CountTestsPassed++;
            return true;
        }
        public static bool TEST(string nameTest, string[] res, string[] value)
        {
            if (res.Length != value.Length)
            {
                System.Console.Write($"{nameTest}  crash. Expected the lenght {value.Length}, got the {res.Length}\n");
                CountTestsFailed++;
                return false;
            }

            for (int i = 0; i < res.Length; ++i)
                if (res[i] != value[i])
                {
                    System.Console.Write($"{nameTest}  crash. Expected the {value[i]}, got the {res[i]}\n");
                    CountTestsFailed++;
                    return false;
                }
            CountTestsPassed++;
            return true;
        }
        static void Main(string[] args)
        {
            TEST("test isNumber", isNumber, "1231", true);
            TEST("test isNumber", isNumber, "asd", false);
            TEST("test isNumber", isNumber, "asd123", false);
            TEST("test strLenghtIsNorm", strLenghtIsNorm, "999999", true);
            TEST("test strLenghtIsNorm", strLenghtIsNorm, "20", true);
            TEST("test strLenghtIsNorm", strLenghtIsNorm, "9999999", false);
            TEST("test isEmpty", isEmpty, "Введите гиги", "Введите гиги", true);
            TEST("test isEmpty", isEmpty, "Введите гиги", "999999", false);
            string[] strClass = new string[8];
            string line = "0;1;2;3;4;5;6;7";
            for (int i = 0; i < 8; ++i)
                strClass[i] += i;

            TEST("test readDBLine", ReadDBLine(line), strClass);
            System.Console.Write($"Completed tests: {CountTestsPassed}\tFailed Tests: {CountTestsFailed}");
            Thread.Sleep(3000);
        }
    }
}
