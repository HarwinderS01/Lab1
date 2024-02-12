using System;
using System.Collections.Generic;
using System.Linq;

class Person
{
    public int PersonId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string FavoriteColour { get; set; }
    public int Age { get; set; }
    public bool IsWorking { get; set; }

    public void DisplayPersonInfo()
    {
        Console.WriteLine($"{PersonId}: {FirstName} {LastName}'s favorite colour is {FavoriteColour}");
    }

    public void ChangeFavoriteColour(string newFavoriteColour)
    {
        FavoriteColour = newFavoriteColour;
    }

    public int GetAgeInTenYears()
    {
        return Age + 10;
    }

    public override string ToString()
    {
        return $"PersonId: {PersonId}\nFirstName: {FirstName}\nLastName: {LastName}\nFavoriteColour: {FavoriteColour}\nAge: {Age}\nIsWorking: {IsWorking}";
    }
}

class Relation
{
    public string RelationshipType { get; set; }

    public void ShowRelationship(Person person1, Person person2)
    {
        
        Console.WriteLine($"Relationship between {person1.FirstName} and {person2.FirstName} is: {RelationshipType}");
    }
}

class MainClass
{
    public static void Main(string[] args)
    {
        List<Person> people = new List<Person>()
        {
            new Person() { PersonId = 1, FirstName = "Ian", LastName = "Brooks", FavoriteColour = "Red", Age = 30, IsWorking = true },
            new Person() { PersonId = 2, FirstName = "Gina", LastName = "James", FavoriteColour = "Green", Age = 18, IsWorking = false },
            new Person() { PersonId = 3, FirstName = "Mike", LastName = "Briscoe", FavoriteColour = "Blue", Age = 45, IsWorking = true },
            new Person() { PersonId = 4, FirstName = "Mary", LastName = "Beals", FavoriteColour = "Yellow", Age = 28, IsWorking = true }
        };

        
        people[1].DisplayPersonInfo(); // Gina
        Console.WriteLine(people[2].ToString()); // Mike

        people[0].ChangeFavoriteColour("White"); // Ian changes favorite colour
        people[0].DisplayPersonInfo(); // Ian

        Console.WriteLine($"{people[3].FirstName} {people[3].LastName}'s Age in 10 years is: {people[3].GetAgeInTenYears()}"); // Mary

        // Showing relationships
        Relation sisterRelation = new Relation() { RelationshipType = "Sisterhood" };
        Relation brotherRelation = new Relation() { RelationshipType = "Brotherhood" };
        sisterRelation.ShowRelationship(people[1], people[3]); // Gina and Mary
        brotherRelation.ShowRelationship(people[0], people[2]); // Ian and Mike

        var averageAge = people.Average(p => p.Age);
        Console.WriteLine($"Average age is: {averageAge}");

        var youngestPerson = people.OrderBy(p => p.Age).First();
        var oldestPerson = people.OrderByDescending(p => p.Age).First();
        Console.WriteLine($"The youngest person is: {youngestPerson.FirstName}");
        Console.WriteLine($"The oldest person is: {oldestPerson.FirstName}");

        
        Console.WriteLine(people[2].ToString()); // Mike
        Console.WriteLine(people[3].ToString()); // Mary
        Console.WriteLine(people[2].ToString()); // Mike again
        Console.WriteLine("Press Enter to close...");
        Console.ReadLine();
    }
}
