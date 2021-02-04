using System;
using ConsoleApp1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void EmptyStack()
        {
            GenericList<int> list1 = new GenericList<int>();
             
            Equals(list1,false);
        }

        [TestMethod]
        public void WrongPushData()
        {
            GenericList<int> list1 = new GenericList<int>();
            var res = list1.Push('2');
            Equals(res, false);
        }
    }
}
