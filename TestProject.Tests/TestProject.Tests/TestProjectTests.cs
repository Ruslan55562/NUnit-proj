using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TestProject.Tests
{
    [TestFixture]
    public class TestProjectTests
    {


        [Test]
        public void Test1()
        {
            test("Hello", "Hello");
            test("123", "123");
            test("%%%", "%%%");
            test("How are you", "How are you");

            static void test(string P_first, string P_second)
            {
                Assert.AreEqual(P_first, P_second, "The strings aren't equal");
            }
        }
        [Test]
        public void Test2()
        {
            string[] first = { "Hello", "Hi" };
            string[] second = { "Hello", "Hi" };
            test(first, second);


            static void test(string[] firstArr, string[] secondArr)
            {
                Assert.AreEqual(true, TestProjectClass.StringArr(firstArr, secondArr), "The arrays aren't equal");
            }
        }

        [Test]
        public void Test3()
        {
            string[] first = { "Hello", "Hi", "How", "Are", "You" };
            string second = "How";
            test(first, second);


            static void test(string[] StrArr, string P_second)
            {
                Assert.AreEqual(true, TestProjectClass.StringIsInArr(StrArr, P_second), "There is no such string in array");
            }
        }


        [Test]
        public void Test4()
        {
            test(10, 5);
            test(9, 8);
            test(122, 0);
            test(-4, -5);


            static void test(int FirstNumb, int SecondNumb)
            {
                Assert.AreEqual(true, TestProjectClass.MoreThan(FirstNumb, SecondNumb), "The first number is less than second");             
            }
        }

    }
}

