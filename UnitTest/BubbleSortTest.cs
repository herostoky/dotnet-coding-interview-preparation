using CodingTestPreparation.Algo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingTestPreparation.UnitTest;

[TestClass]
public class BubbleSortTest
{
    [TestMethod]
    public void Test_Sort_EmptyArray()
    {
        int[] array = [];
        int[] expected = [];
        var result = BubbleSort.Sort(array);
        CollectionAssert.AreEqual(expected, result);
    }

    [TestMethod]
    public void Test_Sort_SingleElementArray()
    {
        int[] array = [1];
        int[] expected = [1];
        var result = BubbleSort.Sort(array);
        CollectionAssert.AreEqual(expected, result);
    }

    [TestMethod]
    public void Test_Sort_SortedArray()
    {
        int[] array = [1, 2, 3, 4, 5];
        int[] expected = [1, 2, 3, 4, 5];
        var result = BubbleSort.Sort(array);
        CollectionAssert.AreEqual(expected, result);
    }

    [TestMethod]
    public void Test_Sort_UnsortedArray()
    {
        int[] array = [5, 3, 1, 4, 2];
        int[] expected = [1, 2, 3, 4, 5];
        var result = BubbleSort.Sort(array);
        CollectionAssert.AreEqual(expected, result);
    }

    [TestMethod]
    public void Test_Sort_ArrayWithDuplicates()
    {
        int[] array = [4, 2, 3, 1, 2];
        int[] expected = [1, 2, 2, 3, 4];
        var result = BubbleSort.Sort(array);
        CollectionAssert.AreEqual(expected, result);
    }

    [TestMethod]
    public void Test_Sort_ArrayWithNegativeNumbers()
    {
        int[] array = [-3, -1, -2, -5, -4];
        int[] expected = [-5, -4, -3, -2, -1];
        var result = BubbleSort.Sort(array);
        CollectionAssert.AreEqual(expected, result);
    }

    [TestMethod]
    public void Test_Sort_ArrayWithMixedNumbers()
    {
        int[] array = [3, -1, 2, -5, 0];
        int[] expected = [-5, -1, 0, 2, 3];
        var result = BubbleSort.Sort(array);
        CollectionAssert.AreEqual(expected, result);
    }
}