// Kaden Bleazard Final

using System;
using System.IO;

class Program {
    static void Main(string[] args) {
        List<string> database = new List<string>();

        AddCow(database, 1, 2, 5, 80);
        AddCow(database, 2, 1, 3, 90);
        AddCow(database, 3, 0, 6, 75);

        WriteToFile(database, "cowdata.txt");

        database.Clear();

        ReadFromFile(database, "cowdata.txt");

        // Search for a cow by number
        Console.Write("Enter a cow number to search for: ");
        int searchNumber = int.Parse(Console.ReadLine());
        string cowData = FindCowByNumber(database, searchNumber);
        if (cowData != null) {
            string[] parts = cowData.Split(',');
            int cowNumber = int.Parse(parts[0]);
            int cowCalves = int.Parse(parts[1]);
            int cowAge = int.Parse(parts[2]);
            int cowHealth = int.Parse(parts[3]);
            Console.WriteLine($"Cow #{cowNumber}: {cowCalves} calves, {cowAge} years old, {cowHealth}% health");
        }
        else {
            Console.WriteLine($"Cow #{searchNumber} not found in database");
        }
    }

    static void AddCow(List<string> database, int number, int calves, int age, int health) {
        string cowData = $"{number},{calves},{age},{health}";
        database.Add(cowData);
    }

    static void RemoveCow(List<string> database, int number) {
        database.RemoveAll(cowData => cowData.StartsWith($"{number},"));
    }

    static string FindCowByNumber(List<string> database, int number) {
        return database.Find(cowData => cowData.StartsWith($"{number},"));
    }

    static void WriteToFile(List<string> database, string filePath) {
        using (StreamWriter writer = new StreamWriter(filePath)) {
            foreach (string cowData in database) {
                writer.WriteLine(cowData);
            }
        }
    }

    static void ReadFromFile(List<string> database, string filePath) {
        using (StreamReader reader = new StreamReader(filePath)) {
            string line;
            while ((line = reader.ReadLine()) != null) {
                database.Add(line);
            }
        }
    }
}
