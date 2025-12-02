using System;
using System.IO;
using System.Collections.Generic;
using System.Globalization; // dla parsowania liczb z przecinkiem/kropką

class Program
{
    static void Main()
    {
        string inputFile = "ranking_raw.txt";
        string outputFile = "ranking_clean.txt";

        // 1. Wczytanie wszystkich linii do listy
        string[] lines = File.ReadAllLines(inputFile);

        if (lines.Length == 0)
        {
            Console.WriteLine("Plik pusty.");
            return;
        }

        List<string> cleanLines = new List<string>();

        // 2. Zachowanie nagłówka
        string header = lines[0];
        cleanLines.Add(header);

        // 3. Przetwarzanie każdej linii z wynikami (od 2. linii)
        for (int i = 1; i < lines.Length; i++)
        {
            string line = lines[i].Trim();

            if (string.IsNullOrWhiteSpace(line))
                continue;

            string[] fields = line.Split(';');

            // Sprawdzenie liczby pól
            if (fields.Length != 5)
                continue; // linia błędna → pomijamy

            string nick = fields[0];
            string czas = fields[1];
            string punktyRaw = fields[2];
            string status = fields[3];
            string opis = fields[4];

            // 4. Konwersja punktów – jeśli błędne, ustaw 0
            int punkty;
            if (!int.TryParse(punktyRaw, out punkty))
                punkty = 0;

            // 5. Kryteria usuwania hackerów
            // - status == HACKER
            // - czas podejrzany: "00:00:01" lub "0:00:01"
            if (status.ToUpper() == "HACKER" ||
                czas == "00:00:01" ||
                czas == "0:00:01")
            {
                continue; // pomijamy ten wpis
            }

            // Jeśli linia OK → zapisujemy poprawioną
            string newLine = $"{nick};{czas};{punkty};{status};{opis}";
            cleanLines.Add(newLine);
        }

        // 6. Zapis nowego pliku
        File.WriteAllLines(outputFile, cleanLines);

        // 7. Wyświetlenie wyniku
        Console.WriteLine("=== Nowy ranking (ranking_clean.txt) ===");
        foreach (string l in File.ReadAllLines(outputFile))
        {
            Console.WriteLine(l);
        }
    }
}
