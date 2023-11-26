namespace Algo.Sorters.Tests;
using Algo.Sorters;

public class SelectionSorterTest
{
    [Fact]
    public void Sort_ShouldReturnValueTrue()
    {
        int[] arr = new int[] { 4, 2, 5, 6, 2, 1, 7, 8, 9 };
        SelectionSorter.Sort(arr, 9);
        Assert.Equal(new int[] { 1, 2, 2, 4, 5, 6, 7, 8, 9 }, arr);
    }
}