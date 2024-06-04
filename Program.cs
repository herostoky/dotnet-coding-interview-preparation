using CodingTestPreparation.Puzzle;

namespace CodingTestPreparation
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var result = Temperature.ComputeClosestToZero([1, 2, -1]);
            Console.WriteLine($"Hello, World!, Temp is {result}");
            WeightOrder.Solve(0,3,1);
            Console.WriteLine("madam is Palindrome ? :=> " + PalindromeCheck.IsPalindrome("madam"));
        }
    }
}
