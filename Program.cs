// Kaden Bleazard Final

using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        List<string> database = new List<string>();

        string filePath = "cowdata.txt";
        if (File.Exists(filePath))
        {
            ReadFromFile(database, filePath);
        }

        while (true)
        {
            Console.WriteLine("Select an option:");
            Console.WriteLine("1. Search for a cow");
            Console.WriteLine("2. Add a new cow");
            Console.WriteLine("3. Add notes to a cow");
            Console.WriteLine("4. Display all cows");
            Console.WriteLine("5. Exit");

            string input = Console.ReadLine();

            if (input == "1")
            {
                Console.Write("Enter a cow number to search for: ");
                int searchNumber = int.Parse(Console.ReadLine());
                string cowData = FindCowByNumber(database, searchNumber);
                if (cowData != null)
                {
                    string[] parts = cowData.Split(',');
                    int cowNumber = int.Parse(parts[0]);
                    int cowCalves = int.Parse(parts[1]);
                    int cowAge = int.Parse(parts[2]);
                    int cowHealth = int.Parse(parts[3]);
                    string cowNotes = parts.Length > 4 ? parts[4] : "";
                    Console.WriteLine($"Cow #{cowNumber}: {cowCalves} calves, {cowAge} years old, {cowHealth}% health");
                    Console.WriteLine($"Notes: {cowNotes}");
                }
                else
                {
                    Console.WriteLine($"Cow #{searchNumber} not found in database");
                }
            }
            else if (input == "2")
            {
                Console.Write("Enter cow number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Enter number of calves: ");
                int calves = int.Parse(Console.ReadLine());
                Console.Write("Enter cow age: ");
                int age = int.Parse(Console.ReadLine());
                Console.Write("Enter cow health percentage: ");
                int health = int.Parse(Console.ReadLine());
                string notes = "";

                AddCowToDatabase(database, number, calves, age, health, notes);

                Console.WriteLine($"Cow #{number} added to database");
            }
            else if (input == "3")
            {
                Console.Write("Enter a cow number to add notes to: ");
                int cowNumber = int.Parse(Console.ReadLine());
                string cowData = FindCowByNumber(database, cowNumber);
                if (cowData != null)
                {
                    Console.Write("Enter notes for the cow: ");
                    string notes = Console.ReadLine();
                    UpdateCowNotes(database, cowNumber, notes);
                    Console.WriteLine($"Notes added to cow #{cowNumber}");
                }
                else
                {
                    Console.WriteLine($"Cow #{cowNumber} not found in database");
                }
            }
            else if (input == "4")
            {
                DisplayAllCows(database);
            }
            else if (input == "5")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid option. Please enter 1, 2, 3, 4, or 5.");
            }
        }

        WriteToFile(database, filePath);
    }

    static void ReadFromFile(List<string> database, string filePath)
    {
        string[] lines = File.ReadAllLines(filePath);
        foreach (string line in lines)
        {
            database.Add(line);
        }
    }

    static void WriteToFile(List<string> database, string filePath)
    {
        string[] lines = database.ToArray();
        File.WriteAllLines(filePath, lines);
    }

    static string FindCowByNumber(List<string> database, int cowNumber)
    {
        foreach (string cowData in database)
        {
            string[] parts = cowData.Split(',');
            int number = int.Parse(parts[0]);
            if (number == cowNumber)
            {
                return cowData;
            }
        }
        return null;
    }

    static void AddCowToDatabase(List<string> database, int number, int calves, int age, int health, string notes)
    {
        string cowData = $"{number},{calves},{age},{health},{notes}";
        database.Add(cowData);
    }


    static void UpdateCowNotes(List<string> database, int cowNumber, string notes)
    {
        for (int i = 0; i < database.Count; i++)
        {
            string cowData = database[i];
            string[] parts = cowData.Split(',');
            int number = int.Parse(parts[0]);
            if (number == cowNumber)
            {
                parts[4] = notes;
                cowData = string.Join(",", parts);
                database[i] = cowData;
                return;
            }
        }
    }

    static void DisplayAllCows(List<string> database)
    {
        if (database.Count == 0)
        {
            Console.WriteLine("No cows in database");
            return;
        }
        foreach (string cowData in database)
        {
            string[] parts = cowData.Split(',');
            int cowNumber = int.Parse(parts[0]);
            int cowCalves = int.Parse(parts[1]);
            int cowAge = int.Parse(parts[2]);
            int cowHealth = int.Parse(parts[3]);
            string cowNotes = parts.Length > 4 ? parts[4] : "";
            Console.WriteLine($"Cow #{cowNumber}: {cowCalves} calves, {cowAge} years old, {cowHealth}% health");
            Console.WriteLine($"Notes: {cowNotes}");
        }
    }
}