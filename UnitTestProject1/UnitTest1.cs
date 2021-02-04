using System;
using ConsoleApp1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            GenericList<int> list1 = new GenericList<int>();
            list1.Push(1);
            list1.Push(2);
            Console.WriteLine("int");
            list1.Write();
            GenericList<string> list2 = new GenericList<string>();
            list1.Push(25);
            list1.Count();
            assertEquals(OBJECT_A, stack.pop());
        }
    }
}
