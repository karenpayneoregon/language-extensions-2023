using System.Data;
using System.Globalization;
using System.Numerics;
using System.Text.Json;

#pragma warning disable CS8619

namespace UtilitiesLibrary;
public static class GenericExtensions
{
    public static bool Between<T>(this T value, T lowerValue, T upperValue) where T : struct, IComparable<T>
        => Comparer<T>.Default.Compare(value, lowerValue) >= 0 &&
           Comparer<T>.Default.Compare(value, upperValue) <= 0;

    public static bool BetweenExclusive<T>(this IComparable<T> sender, T minimumValue, T maximumValue)
        => sender.CompareTo(minimumValue) > 0 && sender.CompareTo(maximumValue) < 0;

    public static bool IsGreaterThan<T>(this T sender, T value) where T : IComparable
        => sender.CompareTo(value) > 0;

    public static bool IsLessThan<T>(this T sender, T value) where T : IComparable
        => sender.CompareTo(value) < 0;

    /// <summary>
    /// Convert DataTable to List of T
    /// </summary>
    /// <typeparam name="TSource">Type to return from DataTable</typeparam>
    /// <param name="table">DataTable</param>
    /// <returns>List of <see cref="TSource"/>Expected type list</returns>
    public static List<TSource> ToList<TSource>(this DataTable table) where TSource : new()
    {
        List<TSource> list = new();

        var typeProperties = typeof(TSource).GetProperties().Select(propertyInfo => new
        {
            PropertyInfo = propertyInfo,
            Type = Nullable.GetUnderlyingType(propertyInfo.PropertyType) ?? propertyInfo.PropertyType
        }).ToList();

        foreach (var row in table.Rows.Cast<DataRow>())
        {

            TSource current = new();

            foreach (var typeProperty in typeProperties)
            {
                object value = row[typeProperty.PropertyInfo.Name];

                object safeValue = (value is null || DBNull.Value.Equals(value) ? null : 
                    Convert.ChangeType(value, typeProperty.Type))!;

                typeProperty.PropertyInfo.SetValue(current, safeValue, null);
            }

            list.Add(current);
        }

        return list;
    }

    /// <summary>
    /// Serialize string to specific type
    /// </summary>
    /// <typeparam name="T">Type to serialize</typeparam>
    /// <param name="sender"></param>
    /// <param name="fileName">File name to write too</param>
    /// <param name="format">Use formatting for serialization or not</param>
    /// <returns></returns>
    public static (bool result, Exception exception) SerializeToFile<T>(this List<T> sender, string fileName, bool format = true)
    {

        try
        {

            var options = new JsonSerializerOptions { WriteIndented = true };
            File.WriteAllText(
                fileName, 
                JsonSerializer
                    .Serialize(sender, (format ? options : null)));

            return (true, null);

        }
        catch (Exception e)
        {
            return (false, e);
        }

    }

    public static T[] ToNumberArray<T>(this string[] sender) where T : INumber<T> =>
        Array
            .ConvertAll(sender,
                (input) => new
                {
                    IsNumber = T.TryParse(input, NumberStyles.Any, CultureInfo.CurrentCulture, out var value),
                    Value = value
                })
            .Where(result => result.IsNumber)
            .Select(result => result.Value)
            .ToArray();

    public static int[] GetNonNumericIndexes<T>(this string[] sender) where T : INumber<T> =>
        sender.Select(
                (item, index) => T.TryParse(item, NumberStyles.Any | NumberStyles.AllowDecimalPoint,
                    CultureInfo.CurrentCulture, out _) ?
                    new { IsNumber = true, Index = index } :
                    new { IsNumber = false, Index = index })
            .ToArray()
            .Where(item => item.IsNumber == false)
            .Select(item => item.Index).ToArray();
}
