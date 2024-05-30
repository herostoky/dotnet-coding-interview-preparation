namespace CodingTestPreparation.Puzzle;

internal static class Temperature
{
    public static int ComputeClosestToZero(int[] temperatures)
    {
        if(temperatures.Length == 0) {
            return 0;
        }
        var min = temperatures[0];
        for(var i = 1; i < temperatures.Length; i++) {
            if(Math.Abs(min) > Math.Abs(temperatures[i])
               || (Math.Abs(min) == Math.Abs(temperatures[i]) && temperatures[i] > min)
              ) {
                min = temperatures[i];
            }
        }
        return min;
    }
}