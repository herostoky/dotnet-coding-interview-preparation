namespace CodingTestPreparation.Puzzle;

internal static class WeightOrder
{
    public static int Solve(int weight0, int weight1, int weight2)
    {
        // Write your code here
        // To debug: Console.Error.WriteLine("Debug messages...");
        var arr = new[]{
            weight0,weight1,weight2
        };
        return Array.IndexOf(arr, arr.Max());
    }
}