namespace CodingTestPreparation.Algo;

internal static class BubbleSort
{
    public static int[] Sort(int[] array) {
        for (var i = 0; i < array.Length - 1; i++) {
            var swapped = false;
            for (var j = 0; j < array.Length - i - 1; j++) {
                if (array[j] > array[j + 1]) {
                    (array[j], array[j + 1]) = (array[j + 1], array[j]); // Swap J and J+1
                    swapped = true;
                }
            }
            // If no swaps occurred in the inner loop, the array is already sorted
            if (!swapped) {
                break;
            }
        }
        return array;
    }
}