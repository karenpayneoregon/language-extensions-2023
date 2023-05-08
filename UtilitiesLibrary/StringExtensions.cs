using System.Text.Json;
using System.Text.RegularExpressions;
#pragma warning disable CS8603

namespace UtilitiesLibrary;
public static class StringExtensions
{
    /// <summary>
    /// Use to split on upper cased characters and separate with a single space.
    /// </summary>
    public static string SplitCamelCase(this string sender) =>
        string.Join(" ", Regex.Matches(sender, @"([A-Z][a-z]+)")
            .Select(m => m.Value));

    /// <summary>
    /// Remove all white space in a string, at start, end and in-between
    /// </summary>
    /// <param name="sender"></param>
    /// <returns>a string with no whitespace</returns>
    public static string RemoveAllWhiteSpace(this string sender)
        => sender
            .ToCharArray().Where(character => !char.IsWhiteSpace(character))
            .Select(character => character.ToString())
            .Aggregate((value1, value2) => value1 + value2);

    public static string RemoveWhitespace(this string input) =>
        new(input.ToCharArray()
            .Where(c => !char.IsWhiteSpace(c))
            .ToArray());

    /// <summary>
    /// Trim last character from a string while the stock <see cref="string.TrimEnd()"/> will trim multiples e.g. given Hello!!
    /// will return Hello while this extension given Hello!! will return Hello!
    /// </summary>
    /// <param name="sender">string to work on</param>
    /// <returns>Original string if null otherwise original string minus the last character</returns>
    public static string TrimLastCharacter(this string sender)
        => string.IsNullOrWhiteSpace(sender) ? 
            sender : 
            sender[..^1];

    /// <summary>
    /// Replace string case insensitive
    /// </summary>
    /// <param name="sender">String to work on</param>
    /// <param name="from">Find string</param>
    /// <param name="to">Replace string</param>
    /// <returns>original string with replacement or if none original string</returns>
    public static string ReplaceInsensitive(this string sender, string from, string to)
        => Regex.Replace(sender, @from, to, RegexOptions.IgnoreCase);

    /// <summary>
    /// Convert a json string to a list of T
    /// </summary>
    /// <typeparam name="T">Type to deserialize</typeparam>
    /// <param name="json">Valid json</param>
    /// <returns>List&lt;T&gt;</returns>
    public static List<T> JSonToList<T>(this string json)
        => JsonSerializer.Deserialize<List<T>>(json, new JsonSerializerOptions());
}
