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

        [TestCaseSource(typeof(AddFirstTestSource))]
        public void AddFirstTest(int value, LinkedList list, LinkedList expectedList)
        {
            LinkedList actualList = list;
            actualList.AddFirst(value);

            Assert.AreEqual(expectedList, actualList);
        }
        
        [TestCaseSource(typeof(AddByIndexTestSource))]
        public void AddByIndexTest(int index,int value, LinkedList list, LinkedList expectedList)
        {
            LinkedList actualList = list;
            actualList.AddByIndex(index,value);

            Assert.AreEqual(expectedList, actualList);
        } 
        
        [TestCaseSource(typeof(DeleteLastTestSource))]
        public void DeleteLastTest(LinkedList list, LinkedList expectedList)
        {
            LinkedList actualList = list;
            actualList.DeleteLast();

            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(DeleteFirstTestSource))]
        public void DeleteFirstTest(LinkedList list, LinkedList expectedList)
        {
            LinkedList actualList = list;
            actualList.DeleteFirst();

            Assert.AreEqual(expectedList, actualList);
        }
        
        [TestCaseSource(typeof(DeleteByIndexTestSource))]
        public void DeleteByIndexTest(int index,LinkedList list, LinkedList expectedList)
        {
            LinkedList actualList = list;
            actualList.DeleteByIndex(index);

            Assert.AreEqual(expectedList, actualList);
        }
        
        [TestCaseSource(typeof(DeleteFromEndElementsTestSource))]
        public void DeleteFromEndElementsTest(int count,LinkedList list, LinkedList expectedList)
        {
            LinkedList actualList = list;
            actualList.DeleteFromEndElements(count);

            Assert.AreEqual(expectedList, actualList);
        }
        
        [TestCaseSource(typeof(DeleteFromBeginingElementsTestSource))]
        public void DeleteFromBeginingElementsTest(int count,LinkedList list, LinkedList expectedList)
        {
            LinkedList actualList = list;
            actualList.DeleteFromBeginingElements(count);

            Assert.AreEqual(expectedList, actualList);
        }
        
        [TestCaseSource(typeof(DeleteElementsByIndexElementsTestSource))]
        public void DeleteElementsByIndexTest(int count,int index,LinkedList list, LinkedList expectedList)
        {
            LinkedList actualList = list;
            actualList.DeleteElementsByIndex(count,index);

            Assert.AreEqual(expectedList, actualList);
        }
        
        [TestCaseSource(typeof(LengthTestSource))]
        public void LengthTest(LinkedList list, int expected)
        {
            int actual = list.Length;
            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(FindFirstIndexByValueTestSource))]
        public void FindFirstIndexByValueTest(int value,LinkedList list, int expected)
        {
            int actual = list.FindFirstIndexByValue(value);
            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(ChangeValueByIndexTestSource))]
        public void ChangeValueByIndexTest(int index, int value, LinkedList list, LinkedList expectedList)
        {
            LinkedList actualList = list;
            actualList.ChangeValueByIndex(index,value);

            Assert.AreEqual(expectedList, actualList);
        }
        
        [TestCaseSource(typeof(ReverseTestSource))]
        public void ReverseTest(LinkedList list, LinkedList expectedList)
        {
            LinkedList actualList = list;
            actualList.Reverse();

            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(FindMaxElementTestSource))]
        public void FindMaxElementTest(LinkedList list, int expected)
        {
            int actual = list.FindMaxElement();
            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(FindMinElementTestSource))]
        public void FindMinElementTest(LinkedList list, int expected)
        {
            int actual = list.FindMinElement();
            Assert.AreEqual(expected, actual);
        }
        
        [TestCaseSource(typeof(FindIndexOfMaxElementTestSource))]
        public void FindIndexOfMaxElementTest(LinkedList list, int expected)
        {
            int actual = list.FindIndexOfMaxElement();
            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(FindIndexOfMinElementTestSource))]
        public void FindIndexOfMinElementTest(LinkedList list, int expected)
        {
            int actual = list.FindIndexOfMinElement();
            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(SortInAscendingTestSource))]
        public void SortInAscendingTest(LinkedList list, LinkedList expectedList)
        {
            LinkedList actualList = list;
            actualList.SortInAscending();

            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(SortInDescendingTestSource))]
        public void SortInDescendingTest(LinkedList list, LinkedList expectedList)
        {
            LinkedList actualList = list;
            actualList.SortInDescending();

            Assert.AreEqual(expectedList, actualList);
        }






    }
}