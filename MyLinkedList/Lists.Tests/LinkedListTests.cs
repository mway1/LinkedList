using System;
using NUnit.Framework;
using System.Collections;
using Lists.Tests.LinkedListTestsSources;
//using ist.Tests.ArrayListNegativeTestsSources;

namespace Lists.Tests
{
    public class LinkedListTests
    {
        [TestCaseSource(typeof(AddToEndTestSource))]
        public void AddToEndTest(int value,LinkedList list, LinkedList expectedList)
        {
            LinkedList actualList = list;
            actualList.AddToEnd(value);

            Assert.AreEqual(expectedList, actualList);
        }
    }
}