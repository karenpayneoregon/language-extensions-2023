using ConsoleApp1.Classes;
using ConsoleApp1.Models;
using UtilitiesLibrary;

namespace ConsoleApp1;

internal class Program
{
    static void Main(string[] args)
    {
        RemoveWhitespace2();
        Console.ReadLine();
    }

    static void JsonExample()
    {
        List<Person> people = Mocked.People();
        people.SerializeToFile("people.json", false);

    }
    static void IntBetweenExample()
    {
        int lower = 2;
        int upper = 8;
        int middle = 5;

        Console.WriteLine(middle.Between(lower,upper));
    }
    static void DateBetweenExample()
    {
        var startDate = new DateOnly(2023, 1, 15);
        var endDate = new DateOnly(2023, 1, 20);
        var middleDate = new DateOnly(2023, 1, 17);

        Console.WriteLine(
            middleDate
                .Between(startDate, endDate));
    }
    static void DeconstructDateOnly()
    {
        var (day, month, year) = new DateOnly(2023,1,15);
        Console.WriteLine($"{month} {day} {year}");
    }

    static void RemoveWhitespace1()
    {
        string value = " This   is  filled with white space 1  2  3";
        Console.WriteLine($"[{value.RemoveAllWhiteSpace()}]");
    }

    static void RemoveWhitespace2()
    {
        string value = " This   is  filled with white space 1  2  3";
        Console.WriteLine($"[{value.RemoveWhitespace()}]");
    }
}
