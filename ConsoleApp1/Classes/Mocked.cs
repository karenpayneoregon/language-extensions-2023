using ConsoleApp1.Models;

namespace ConsoleApp1.Classes;

public class Mocked
{
    public static List<Person> People() =>
        new()
        {
            new()
            {
                Id = 1, 
                FirstName = "Anne", 
                LastName = "White", 
                Gender = "F"
            },
            new()
            {
                Id = 2, 
                FirstName = "Mike", 
                LastName = "Smith", 
                Gender = "M"
            }
        };
}