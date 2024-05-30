namespace CodingTestPreparation.Algo;


internal static class BinarySearch
{
    public static bool Exists(int[] array, int toSearch)
    {
        // Binary search to find the target value
        var low = 0;
        var high = array.Length - 1;
        while (low <= high)
        {
            var mid = low + (high - low) / 2; // Avoid overflow for large arrays
            if (array[mid] == toSearch)
            {
                return true;
            }
            if (array[mid] < toSearch)
            {
                low = mid + 1;
            }
            else
            {
                high = mid - 1;
            }
        }
        return false;
    }
}