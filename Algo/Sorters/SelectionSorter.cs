namespace Algo.Sorters;

public class SelectionSorter
{
    public static void Sort(int[] arr, int n)
    {
        for (int i = 0; i < n - 1; i++)
        {
            int idx = i;
            for (var j = i; j < n; j++)
            {
                if (arr[j] < arr[idx])
                {
                    idx = j;
                }
            }
            (arr[idx], arr[i]) = (arr[i], arr[idx]);
        }
    }
}