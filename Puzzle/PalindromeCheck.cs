namespace CodingTestPreparation.Puzzle;

internal static class PalindromeCheck
{
    public static bool IsPalindrome(string text) {
        var left = 0;
        var right = text.Length - 1;
        while (left < right) {
            var leftChar = text[left];
            var rightChar = text[right];
            // Ignore non-alphanumeric characters
            if (!char.IsLetterOrDigit(leftChar)) {
                left++;
                continue;
            }
            if (!char.IsLetterOrDigit(rightChar)) {
                right--;
                continue;
            }
            if (char.ToLower(leftChar) != char.ToLower(rightChar)) {
                return false;
            }
            left++;
            right--;
        }
        return true;
    }
}