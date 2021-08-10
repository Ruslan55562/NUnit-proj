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

            void test(string first, string second)
            {
                Assert.AreEqual(first, second, "The strings aren't equal");
            }
        }
        [Test]
        public void Test2()
        {
            string[] first = { "Hello", "Hi" };
            string[] second = { "Hello", "Hi" };
            test(first, second);


            void test(string[] first, string[] second)
            {
                bool ActualResult = TestProjectClass.StringArr(first, second);
                Assert.AreEqual(true, ActualResult, "The arrays aren't equal");
            }
        }

        [Test]
        public void Test3()
        {
            string[] first = { "Hello", "Hi", "How", "Are", "You" };
            string second = "How";
            test(first, second);


            void test(string[] first, string second)
            {
                bool actualResult = TestProjectClass.StringIsInArr(first, second);
                Assert.AreEqual(true, actualResult, "There is no such string in array");
            }
        }


        [Test]
        public void Test4()
        {
            test(10, 5);
            test(9, 8);
            test(122, 0);
            test(-4, -5);
           


            void test(int first, int second)
            {
                bool actualResult = TestProjectClass.MoreThan(first, second);
                Assert.AreEqual(true, actualResult, "The first number is less than second");
            }
        }
    }
    }

