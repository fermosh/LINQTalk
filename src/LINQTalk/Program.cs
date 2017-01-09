using LINQTalk.Models;
using System;
using System.Collections.Generic;

class Program
{
    const string NOT = "NOT";
    private delegate bool LegalAgeChecker( Person person );

    private static bool AmericanLegalAge(Person person)
    {
        return person.Age >= 21;
    }
    private static bool MexicanLegalAge(Person person)
    {
        return person.Age >= 18;
    }

    
    static void Main(string[] args)
    {
        var people = new List<Person> {
            new Person { Name = "Maria", Age = 19 },
            new Person { Name = "Juan", Age = 22 },
            new Person { Name = "Rodrigo", Age = 15 }
        };

        DisplayLegalAges("Mexico", people, MexicanLegalAge);
        Console.ReadLine();
        DisplayLegalAges("America", people, AmericanLegalAge);
        Console.ReadLine();
    }

    private static void DisplayLegalAges(string country, List<Person> people, LegalAgeChecker ageChecker)
    {
        foreach (var person in people)
        {
            var isOfLegalAge = ageChecker(person);
            Console.WriteLine("In {0}, {1} is {2} of legal age, being {3}",country, person.Name, isOfLegalAge ? string.Empty : NOT,person.Age);
        }
    }
}