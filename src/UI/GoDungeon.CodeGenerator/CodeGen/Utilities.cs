using System.Text.RegularExpressions;
using System.Text;

namespace GoDungeon.CodeGenerator.CodeGen;

internal static class Utilities
{
    // TODO: Can be modified to accept generated
    // pattern and groups for even larger numbers.
    private static readonly string[] groups =
    {
        "trillion",
        "billion",
        "million",
        "thousand",
        "hundred",
        "cents"
    };

    private static readonly string pattern =
        @"^(?<trillion>\d{1,3})?(?<billion>\d{1,3})?(?<million>\d{1,3})?(?<thousand>\d{1,3})?(?<hundred>\d{1,3})(\.(?<cents>\d{1,2}))?$";
    private static readonly RegexOptions options = RegexOptions.RightToLeft;
    private static Regex regex;

    /// <summary>
    /// Constructor
    /// </summary>
    static Utilities()
    {
        regex = new Regex(pattern, options);
    }

    /// <summary>
    /// Clean up a string so it can be used as a C# variable
    /// </summary>
    /// <param name="name">The name to fix-up</param>
    /// <returns>The string as a c# variable name</returns>
    internal static string? CleanupForCSharp(string name)
    {
        if (string.IsNullOrEmpty(name.Trim()))
        {
            return null;
        }

        // Cleanup spell levels
        var cleanName = name
            .Replace("1st", "First")
            .Replace("2nd", "Second")
            .Replace("3rd", "Third")
            .Replace("4th", "Fourth")
            .Replace("5th", "Fifth")
            .Replace("6th", "Sixth")
            .Replace("7th", "Seventh")
            .Replace("8th", "Eighth")
            .Replace("9th", "Ninth");

        // Clean up for the c# variable name
        return cleanName
            .Replace(" ", string.Empty)
            .Replace("/", string.Empty)
            .Replace("\\", string.Empty)
            .Replace("-", string.Empty)
            .Replace("_", string.Empty)
            .Replace(":", string.Empty)
            .Replace("'", string.Empty)
            .Replace("(", string.Empty)
            .Replace(")", string.Empty)
            .Replace(",", string.Empty)
            .Replace(".", string.Empty)
            .Replace("*", string.Empty)
            .Trim();
    }  

    /// <summary>
    ///build the number as text
    /// </summary>
    /// <param name="value">The decimal value</param>
    /// <returns>The text for the number</returns>
    public static string BuildNumberTextOf(decimal value)
    {
        var match = regex.Match(Convert.ToString(value));

        var sb = new StringBuilder();
        foreach (var group in groups)
        {
            var capturedValue = match.Groups[group].Value.TrimStart(new char[] { '0' });

            // Dollars wont be appended to result if the 
            // hundred group contains all zeros.
            if (capturedValue == "" && group == "hundred")
            {
                sb.Append("dollars ");
                continue;
            }
            else if (capturedValue == "")
            {
                continue;
            }
            else
            {
                var words = HundredsToWords(Convert.ToInt32(capturedValue));

                // Make sure "hundred" doesn't double up since
                // "hundred" is also appended in the HundredsToWords
                // function.
                if (group != "hundred")
                {
                    var cents = group == "cents" ? "and " : "";
                    sb.Append($"{cents}{words} {group} ");
                }
                else
                {
                    sb.Append($"{words} dollars ");
                }
            }
        }

        return sb.ToString().TrimEnd();
    }

    /// <summary>
    /// Numbers to words
    /// </summary>
    /// <param name="number">The number</param>
    /// <returns>The number as a word</returns>
    /// <exception cref="ArgumentOutOfRangeException"></exception>
    private static string HundredsToWords(int number)
    {
        if (number > 999) throw new ArgumentOutOfRangeException("Passed value too large.");

        var sb = new StringBuilder();

        if ((number / 100) > 0)
        {
            sb.Append(HundredsToWords(number / 100) + " hundred ");
            number %= 100;
        }

        if (number > 0)
        {
            var units = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            var tens = new[] { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

            if (number < 20)
            {
                sb.Append(units[number]);
            }
            else
            {
                sb.Append(tens[number / 10]);
                if ((number % 10) > 0)
                {
                    sb.Append("-" + units[number % 10]);
                }
            }
        }
        return sb.ToString();
    }
}
