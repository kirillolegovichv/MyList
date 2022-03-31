using NUnit.Framework;
using System.Collections;


namespace MyList.Test
{
    public class Tests
    {
        [TestCaseSource(typeof(AddToStartTestSource))]
        public void AddToStartTest(int value, ListArray list, ListArray expectedList)
        {
            ListArray actualList = list;
            actualList.AddToStart(value);
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(AddToIndexTestSource))]
        public void AddToIndexTest(int index, int value, ListArray list, ListArray expectedList)
        {
            ListArray actualList = list;
            actualList.AddToIndex(index, value);
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(PopTestSource))]
        public void PopTest(ListArray list, ListArray expectedList)
        {
            ListArray actualList = list;
            actualList.Pop();
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(PopFromStartTestSource))]
        public void PopFromStartTest(ListArray list, ListArray expectedList)
        {
            ListArray actualList = list;
            actualList.PopFromStart();
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(PopByIndexTestSource))]
        public void PopByIndexTest(int index, ListArray list, ListArray expectedList)
        {
            ListArray actualList = list;
            actualList.PopByIndex(index);
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(PopElemsTestSource))]
        public void PopElemsTest(int count, ListArray list, ListArray expectedList)
        {
            ListArray actualList = list;
            actualList.PopElems(count);
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(PopElemsFromStartTestSource))]
        public void PopElemsFromStartTest(int count, ListArray list, ListArray expctedList)
        {
            ListArray actualList = list;
            actualList.PopElemsFromStart(count);
            Assert.AreEqual(expctedList, actualList);
        }

        [TestCaseSource(typeof(PopElemsByIndexTestSource))]
        public void PopElemsByIndexTest(int index, int count, ListArray list, ListArray expectedList)
        {
            ListArray actualList = list;
            actualList.PopElemsByIndex(index, count);
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(ReturnElementByIndexTestSource))]
        public void ReturnElementByIndexTest(int index, ListArray list, int expected)
        {
            int actual = list.ReturnElementByIndex(index);
            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(FirstIndexByElemTestSource))]
        public void FirstIndexByElemTest(int elem, ListArray list, int expected)
        {
            int actual = list.FirstIndexByElem(elem);
            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(ChangeElemByIndexTestSource))]
        public void ChangeElemByIndexTest(int index, int value, ListArray list, ListArray expectedList)
        {
            ListArray actualList = list;
            actualList.ChangeElemByIndex(index, value);
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(ReverseTestSource))]
        public void ReverseTest(ListArray list, ListArray expectedList)
        {
            ListArray actualList = list;
            actualList.Reverse();
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(MaxValueTestSource))]
        public void MaxValueTest(ListArray list, int expected)
        {
            int actual = list.MaxValue();
            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(MinValueTestSource))]
        public void MinValueTest(ListArray list, int expected)
        {
            int actual = list.MinValue();
            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(IndexOfMaxValueTestSource))]
        public void IndexOfMaxValueTest(ListArray list, int expected)
        {
            int actual = list.IndexOfMaxValue();
            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(IndexOfMinValueTestSource))]
        public void IndexOfMinValueTest(ListArray list, int expected)
        {
            int actual = list.IndexOfMinValue();
            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(AscendingSortTestSource))]
        public void AscendingSortTest(ListArray list, ListArray expectedList)
        {
            ListArray actualList = list;
            actualList.AscendingSort();
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(DescendingSortTestSource))]
        public void DescendingSortTest(ListArray list, ListArray expectedList)
        {
            ListArray actualList = list;
            actualList.DescendingSort();
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(PopElemTestSource))]
        public void PopElemTest(int value, ListArray list, int expected)
        {
            int actual = list.PopElem(value);
            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(PopAllByValueTestSource))]
        public void PopAllByValueTest(int value, ListArray list, int expected)
        {
            int actual = list.PopAllByValue(value);
            Assert.AreEqual(expected, actual);
        }
    }

    public class AddToStartTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int value = 6;
            ListArray list = new ListArray(new int[] { 1, 2, 3, 4, 5 });
            ListArray expectedList = new ListArray(new int[] { 6, 1, 2, 3, 4, 5 });
            yield return new object[] { value, list, expectedList };

            value = 3;
            list = new ListArray(new int[] { 1 });
            expectedList = new ListArray(new int[] { 3, 1 });
            yield return new object[] { value, list, expectedList };

            value = 3;
            list = new ListArray(new int[] { });
            expectedList = new ListArray(new int[] { 3 });
            yield return new object[] { value, list, expectedList };
        }
    }

    public class AddToIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int index = 3;
            int value = 6;
            ListArray list = new ListArray(new int[] { 1, 2, 3, 4, 5 });
            ListArray expectedList = new ListArray(new int[] { 1, 2, 3, 6, 4, 5 });
            yield return new object[] { index, value, list, expectedList };

            index = 0;
            value = 5;
            list = new ListArray(new int[] { 3 });
            expectedList = new ListArray(new int[] { 5, 3 });
            yield return new object[] { index, value, list, expectedList };
        }
    }

    public class PopTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            ListArray list = new ListArray(new int[] { 1, 2, 3, 4, 5 });
            ListArray expectedList = new ListArray(new int[] { 1, 2, 3, 4 });
            yield return new object[] { list, expectedList };

            list = new ListArray(new int[] { 3 });
            expectedList = new ListArray(new int[] { });
            yield return new object[] { list, expectedList };
        }
    }

    public class PopFromStartTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            ListArray list = new ListArray(new int[] { 1, 2, 3, 4, 5 });
            ListArray expectedList = new ListArray(new int[] { 2, 3, 4, 5 });
            yield return new object[] { list, expectedList };

            list = new ListArray(new int[] { 3 });
            expectedList = new ListArray(new int[] { });
            yield return new object[] { list, expectedList };
        }
    }

    public class PopByIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int index = 0;
            ListArray list = new ListArray(new int[] { 1, 2, 3, 4, 5 });
            ListArray expectedList = new ListArray(new int[] { 2, 3, 4, 5 });
            yield return new object[] { index, list, expectedList };

            index = 0;
            list = new ListArray(new int[] { 3 });
            expectedList = new ListArray(new int[] { });
            yield return new object[] { index, list, expectedList };

            index = 4;
            list = new ListArray(new int[] { 1, 2, 3, 4, 5 });
            expectedList = new ListArray(new int[] { 1, 2, 3, 4 });
            yield return new object[] { index, list, expectedList };

            index = 2;
            list = new ListArray(new int[] { 1, 2, 3, 4, 5 });
            expectedList = new ListArray(new int[] { 1, 2, 4, 5 });
            yield return new object[] { index, list, expectedList };
        }
    }

    public class PopElemsTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int count = 0;
            ListArray list = new ListArray(new int[] { 1, 2, 3, 4, 5 });
            ListArray expectedList = new ListArray(new int[] { 1, 2, 3, 4, 5 });
            yield return new object[] { count, list, expectedList };

            count = 1;
            list = new ListArray(new int[] { 1, 2, 3, 4, 5 });
            expectedList = new ListArray(new int[] { 1, 2, 3, 4 });
            yield return new object[] { count, list, expectedList };

            count = 1;
            list = new ListArray(new int[] { 2 });
            expectedList = new ListArray(new int[] { });
            yield return new object[] { count, list, expectedList };

            count = 2;
            list = new ListArray(new int[] { 1, 2, 3, 4, 5 });
            expectedList = new ListArray(new int[] { 1, 2, 3 });
            yield return new object[] { count, list, expectedList };

            count = 5;
            list = new ListArray(new int[] { 1, 2, 3, 4, 5 });
            expectedList = new ListArray(new int[] { });
            yield return new object[] { count, list, expectedList };
        }
    }

    public class PopElemsFromStartTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int count = 0;
            ListArray list = new ListArray(new int[] { 1, 2, 3, 4, 5 });
            ListArray expectedList = new ListArray(new int[] { 1, 2, 3, 4, 5 });
            yield return new object[] { count, list, expectedList };

            count = 1;
            list = new ListArray(new int[] { 1, 2, 3, 4, 5 });
            expectedList = new ListArray(new int[] { 2, 3, 4, 5 });
            yield return new object[] { count, list, expectedList };

            count = 2;
            list = new ListArray(new int[] { 1, 2, 3, 4, 5 });
            expectedList = new ListArray(new int[] { 3, 4, 5 });
            yield return new object[] { count, list, expectedList };

            count = 5;
            list = new ListArray(new int[] { 1, 2, 3, 4, 5 });
            expectedList = new ListArray(new int[] { });
            yield return new object[] { count, list, expectedList };
        }
    }

    public class PopElemsByIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int index = 0;
            int count = 0;
            ListArray list = new ListArray(new int[] { 1, 2, 3, 4, 5 });
            ListArray expectedList = new ListArray(new int[] { 1, 2, 3, 4, 5 });
            yield return new object[] { index, count, list, expectedList };

            index = 1;
            count = 0;
            list = new ListArray(new int[] { 1, 2, 3, 4, 5 });
            expectedList = new ListArray(new int[] { 1, 2, 3, 4, 5 });
            yield return new object[] { index, count, list, expectedList };

            index = 2;
            count = 3;
            list = new ListArray(new int[] { 1, 2, 3, 4, 5 });
            expectedList = new ListArray(new int[] { 1, 2 });
            yield return new object[] { index, count, list, expectedList };
        }
    }

    public class ReturnElementByIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int index = 0;
            ListArray list = new ListArray(new int[] { 1, 2, 3, 4, 5 });
            int expected = 1;
            yield return new object[] { index, list, expected };

            index = 4;
            list = new ListArray(new int[] { 1, 2, 3, 4, 5 });
            expected = 5;
            yield return new object[] { index, list, expected };

            index = 2;
            list = new ListArray(new int[] { 1, 2, 3, 4, 5 });
            expected = 3;
            yield return new object[] { index, list, expected };
        }
    }

    public class FirstIndexByElemTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int elem = 0;
            ListArray list = new ListArray(new int[] { 1, 2, 3, 4, 5 });
            int expected = -1;
            yield return new object[] { elem, list, expected };

            elem = 1;
            list = new ListArray(new int[] { 1, 2, 1, 4, 5 });
            expected = 0;
            yield return new object[] { elem, list, expected };

            elem = 4;
            list = new ListArray(new int[] { 1, 2, 1, 4, 5 });
            expected = 3;
            yield return new object[] { elem, list, expected };
        }
    }

    public class ChangeElemByIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int index = 0;
            int value = 0;
            ListArray list = new ListArray(new int[] { 1, 2, 3, 4, 5 });
            ListArray expectedList = new ListArray(new int[] { 0, 2, 3, 4, 5 });
            yield return new object[] { index, value, list, expectedList };

            index = 1;
            value = 0;
            list = new ListArray(new int[] { 1, 2, 3, 4, 5 });
            expectedList = new ListArray(new int[] { 1, 0, 3, 4, 5 });
            yield return new object[] { index, value, list, expectedList };
        }
    }

    public class ReverseTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            ListArray list = new ListArray(new int[] { 1, 2, 3, 4, 5 });
            ListArray expectedList = new ListArray(new int[] { 5, 4, 3, 2, 1 });
            yield return new object[] { list, expectedList };

            list = new ListArray(new int[] { 1, 2, 3, 4 });
            expectedList = new ListArray(new int[] { 4, 3, 2, 1 });
            yield return new object[] { list, expectedList };
        }
    }

    public class MaxValueTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            ListArray list = new ListArray(new int[] { 1, 2, 3, 4, 5 });
            int expected = 5;
            yield return new object[] { list, expected };

            list = new ListArray(new int[] { 1, 2, 5, 3, 4 });
            expected = 5;
            yield return new object[] { list, expected };
        }
    }

    public class MinValueTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            ListArray list = new ListArray(new int[] { 1, 2, 3, 4, 5 });
            int expected = 1;
            yield return new object[] { list, expected };

            list = new ListArray(new int[] { 5, 2, 1, 3, 4 });
            expected = 1;
            yield return new object[] { list, expected };
        }
    }

    public class IndexOfMaxValueTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            ListArray list = new ListArray(new int[] { 1, 2, 3, 4, 5 });
            int expected = 4;
            yield return new object[] { list, expected };

            list = new ListArray(new int[] { 5, 2, 1, 3, 4 });
            expected = 0;
            yield return new object[] { list, expected };
        }
    }

    public class IndexOfMinValueTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            ListArray list = new ListArray(new int[] { 1, 2, 3, 4, 5 });
            int expected = 0;
            yield return new object[] { list, expected };

            list = new ListArray(new int[] { 5, 2, 1, 3, 4 });
            expected = 2;
            yield return new object[] { list, expected };
        }
    }

    public class AscendingSortTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            ListArray list = new ListArray(new int[] { 7, 2, 1, 8, 3 });
            ListArray expectedList = new ListArray(new int[] { 1, 2, 3, 7, 8 });
            yield return new object[] { list, expectedList };

            list = new ListArray(new int[] { 1 });
            expectedList = new ListArray(new int[] { 1 });
            yield return new object[] { list, expectedList };
        }
    }

    public class DescendingSortTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            ListArray list = new ListArray(new int[] { 7, 2, 1, 8, 3 });
            ListArray expectedList = new ListArray(new int[] { 8, 7, 3, 2, 1 });
            yield return new object[] { list, expectedList };

            list = new ListArray(new int[] { 1 });
            expectedList = new ListArray(new int[] { 1 });
            yield return new object[] { list, expectedList };

            list = new ListArray(new int[] { });
            expectedList = new ListArray(new int[] { });
            yield return new object[] { list, expectedList };
        }
    }

    public class PopElemTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int value = 0;
            ListArray list = new ListArray(new int[] { 1, 0, 2, 3, 0, 4 });
            int expected = 1;
            yield return new object[] { value, list, expected };

            value = 2;
            list = new ListArray(new int[] { 1, 1, 2, 3, 0, 4 });
            expected = 2;
            yield return new object[] { value, list, expected };

            value = 5;
            list = new ListArray(new int[] { 1, 1, 2, 3, 0, 4 });
            expected = -1;
            yield return new object[] { value, list, expected };
        }
    }

    public class PopAllByValueTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int value = 0;
            ListArray list = new ListArray(new int[] { 1, 0, 2, 3, 0, 4 });
            int expected = 2;
            yield return new object[] { value, list, expected };

            value = 2;
            list = new ListArray(new int[] { 1, 1, 2, 3, 0, 4 });
            expected = 1;
            yield return new object[] { value, list, expected };

            value = 5;
            list = new ListArray(new int[] { 1, 1, 2, 3, 0, 4 });
            expected = 0;
            yield return new object[] { value, list, expected };
        }
    }
}