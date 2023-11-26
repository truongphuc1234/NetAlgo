namespace Algo.Sorters.Tests;
using Algo.Sorters;

public class InsertionSorterTest
{
    [Fact]
    public void Sort_ShouldReturnValueTrue()
    {
        int[] arr = new int[] { 4, 2, 5, 6, 2, 1, 7, 8, 9 };
        InsertionSorter.Sort(arr, 9);
        Assert.Equal(arr, new int[] { 1, 2, 2, 4, 5, 6, 7, 8, 9 });
    }
}