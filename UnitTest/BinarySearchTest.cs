using CodingTestPreparation.Algo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingTestPreparation.UnitTest;

[TestClass]
public class BinarySearchTest
{
    [TestMethod]
    public void Test_ElementPresentInArray()
    {
        int[] array = [ 1, 2, 3, 4, 5 ];
        var result = BinarySearch.Exists(array, 3);
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void Test_ElementNotPresentInArray()
    {
        int[] array = [1, 2, 3, 4, 5];
        var result = BinarySearch.Exists(array, 6);
        Assert.IsFalse(result);
    }

    [TestMethod]
    public void Test_EmptyArray()
    {
        int[] array = [];
        var result = BinarySearch.Exists(array, 1);
        Assert.IsFalse(result);
    }

    [TestMethod]
    public void Test_SingleElementArray_ElementPresent()
    {
        int[] array = [1];
        var result = BinarySearch.Exists(array, 1);
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void Test_SingleElementArray_ElementNotPresent()
    {
        int[] array = [1];
        var result = BinarySearch.Exists(array, 2);
        Assert.IsFalse(result);
    }

    [TestMethod]
    public void Test_ElementPresentAtBeginning()
    {
        int[] array = [1, 2, 3, 4, 5];
        var result = BinarySearch.Exists(array, 1);
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void Test_ElementPresentAtEnd()
    {
        int[] array = [1, 2, 3, 4, 5];
        var result = BinarySearch.Exists(array, 5);
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void Test_ArrayWithDuplicates_ElementPresent()
    {
        int[] array = [1, 2, 2, 3, 4, 5];
        var result = BinarySearch.Exists(array, 2);
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void Test_ArrayWithDuplicates_ElementNotPresent()
    {
        int[] array = [1, 2, 2, 3, 4, 5];
        var result = BinarySearch.Exists(array, 6);
        Assert.IsFalse(result);
    }

    [TestMethod]
    public void Test_LargeArray_ElementPresent()
    {
        var array = Enumerable.Range(0, 999).ToArray();
        var result = BinarySearch.Exists(array, 500);
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void Test_LargeArray_ElementNotPresent()
    {
        var array = Enumerable.Range(0, 999).ToArray();
        var result = BinarySearch.Exists(array, 1000);
        Assert.IsFalse(result);
    }
}