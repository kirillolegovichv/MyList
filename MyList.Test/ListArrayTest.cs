using NUnit.Framework;
using System;


namespace MyList.Test
{
    public class Tests
    {
        [TestCaseSource(typeof(AddToStartTest))]
        public void AddToStartTest(int value, ListArray list, ListArray expectedList)
        {
            ListArray actualList = list;
            actualList.AddToStart(value);
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(AddToIndexTest))]
        public void AddToIndexTest(int value, int index, ListArray list, ListArray expectedList)
        {
            ListArray actualList = list;
            actualList.AddToIndex(index, value);
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(PopTest))]
        public void PopTest(ListArray list, ListArray expectedList)
        {
            ListArray actualList = list;
            actualList.Pop();
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(PopFromStartTest))]
        public void PopFromStartTest(ListArray list, ListArray expectedList)
        {
            ListArray actualList = list;
            actualList.PopFromStart();
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(PopByIndexTest))]
        public void PopByIndexTest(int index, ListArray list, ListArray expectedList)
        {
            ListArray actualList = list;
            actualList.PopByIndex(index);
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(PopElemsTest))]
        public void PopElemsTest(int count, ListArray list, ListArray expectedList)
        {
            ListArray actualList = list;
            actualList.PopElems(count);
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(PopElemsFromStartTest))]
        public void PopElemsFromStartTest(int count, ListArray list, ListArray expctedList)
        {
            ListArray actualList = list;
            actualList.PopElemsFromStart(count);
            Assert.AreEqual(expctedList, actualList);
        }

        [TestCaseSource(typeof(PopElemsByIndexTest))]
        public void PopElemsByIndexTest(int index, int count, ListArray list, ListArray expectedList)
        {
            ListArray actualList = list;
            actualList.PopElemsByIndex(index, count);
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(ElementTest))]
        public void ElementTest(int index, ListArray list, int expected)
        {
            int actual = list.Element(index);
            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(FirstIndexByElemTest))]
        public void FirstIndexByElemTest(int elem, ListArray list, int expected)
        {
            int actual = list.FirstIndexByElem(elem);
            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(ChangeElemByIndexTest))]
        public void ChangeElemByIndexTest(int index, int value, ListArray list, ListArray expectedList)
        {
            ListArray actualList = list;
            actualList.ChangeElemByIndex(index, value);
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(ReverseTest))]
        public void ReverseTest(ListArray list, ListArray expectedList)
        {
            ListArray actualList = list;
            actualList.Reverse();
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(MaxValueTest))]
        public void MaxValueTest(ListArray list, int expected)
        {
            int actual = list.MaxValue();
            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(MinValueTest))]
        public void MinValueTest(ListArray list, int expected)
        {
            int actual = list.MinValue();
            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(IndexOfMaxValueTest))]
        public void IndexOfMaxValueTest(ListArray list, int expected)
        {
            int actual = list.IndexOfMaxValue();
            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(IndexOfMinValueTest))]
        public void IndexOfMinValueTest(ListArray list, int expected)
        {
            int actual = list.IndexOfMinValue();
            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(AscendingSortTest))]
        public void AscendingSortTest(ListArray list, ListArray expectedList)
        {
            ListArray actualList = list;
            actualList.AscendingSort();
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(DescendingSortTest))]
        public void DescendingSortTest(ListArray list, ListArray expectedList)
        {
            ListArray actualList = list;
            actualList.DescendingSort();
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(PopElemTest))]
        public void PopElemTest(int value, ListArray list, int expected)
        {
            int actual = list.PopElem(value);
            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(PopAllByValueTest))]
        public void PopAllByValueTest(int value, ListArray list, ListArray expectedList)
        {
            ListArray actualList = list;
            actualList.PopAllByValue(value);
            Assert.AreEqual(expectedList, actualList);
        }
    }
}