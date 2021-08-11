using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TestProject.Tests
{
    [TestFixture]
    public class AssertionsTest
    {


        [Test]
        public void EqualStrings()
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
        public void EqualLists()
        {
            List<string>first = new List<string> { "Hello", "Hi" };
            List<string>second = new List<string> { "Hello", "Hi" };
            test(first, second);

            static void test(List<string> firstLst, List<string> secondLst)
            {
                for (int i = 0; i < firstLst.Count; i++)
                {
                    Assert.AreEqual(firstLst[i], secondLst[i], "The lists aren't equal");
                }
            }
        }

        [Test]
        public void Word_In_Array()
        {
            List<string> firstLst = new List <string>{ "Hello", "Hi", "How", "Are", "You" };
            string second = "How";
            test(firstLst, second);

            static void test(List<string> StrLst, string P_second)
            {
                Assert.Contains(P_second, StrLst, "There is no such word in array");
            }
        }


        [Test]
        public void Compare_two_numbers()
        {
            test(6, 5);
            test(9, 8);
            test(122, 0);
            test(-4, -5);

            //For Assert.IsFalse
            //test(2, 3);
            //test(0, 1);
            //test(-6, -5);



            static void test(int FirstNumb, int SecondNumb)
            {
                // Assert.AreEqual(true, TestProjectClass.MoreThan(FirstNumb, SecondNumb), "The first number is less than second");
                 Assert.Greater(FirstNumb, SecondNumb, "The first number is less than second");
                //Assert.IsTrue(TestProjectClass.MoreThan(FirstNumb, SecondNumb), "The first number is less than second");
                //Assert.IsTrue(FirstNumb > SecondNumb);
                //Assert.IsFalse(TestProjectClass.MoreThan(FirstNumb, SecondNumb), "The first number is more than second");
            }
        }

    }
}

