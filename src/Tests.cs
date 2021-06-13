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
        public static bool BOOL_TEST(string nameTest, Func<string, bool> testMethod, string data, bool value)
        {
            bool res = testMethod(data);
            if (res != value)
            {
                System.Console.Write($"{nameTest}  crash. With a value of {data}, expected the {value}, got the {res}\n");
                CountTestsFailed++;
                return false;
            }
            CountTestsPassed++;
            return true;
        }
        static void Main(string[] args)
        {
            BOOL_TEST("test isNumber", isNumber, "1231", true);
            BOOL_TEST("test isNumber", isNumber, "asd", false);
            BOOL_TEST("test isNumber", isNumber, "asd123", false);
            System.Console.Write($"Completed tests: {CountTestsPassed}\tFailed Tests: {CountTestsFailed}");
            Thread.Sleep(3000);
        }
    }
}
