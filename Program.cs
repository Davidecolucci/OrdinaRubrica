﻿using System.Diagnostics;
public class RubricaContatti
{
    const string FilePath = "Rubrica2.csv";
    static Dictionary<string, string[]> rubrica = new Dictionary<string, string[]>();
    
    static void Main()
    {
        //CaricaContatti
        List<string> nominativi = CaricaContatti();

        //Chiamata Bubble Sort + Calcolo del tempo
        Stopwatch Timer = new Stopwatch();
        Timer.Start();
        Algoritmi.BubbleSort(CaricaContatti());
        Timer.Stop();
        TimeSpan TimerBubble = Timer.Elapsed;

        Console.WriteLine("Array ordinato con: Bubble Sort");
        Console.WriteLine($"Il Bubble Sort ci ha messo {TimerBubble}");

        //Chiamata Selection Sort + Calcolo del tempo
        Timer.Restart();
        Algoritmi.SelectionSort(CaricaContatti());
        Timer.Stop();
        TimeSpan TimerSelection = Timer.Elapsed;

        Console.WriteLine("Array ordinato con: Selection Sort");
        Console.WriteLine($"Il Selection Sort ci ha messo {TimerSelection}");

        //Chiamata Insertion Sort + Calcolo del tempo
        Timer.Restart();
        Algoritmi.InsertionSort(CaricaContatti());
        Timer.Stop();
        TimeSpan TimerInsertion = Timer.Elapsed;

        Console.WriteLine("Array ordinato con: Insertion Sort");
        Console.WriteLine($"Il Insertion Sort ci ha messo {TimerInsertion}");

        
        //Chiamata Merge Sort + Calcolo del tempo
        Timer.Restart();
        List<string> nominativiOrdinati = Algoritmi.MergeSort(nominativi);
        Timer.Stop();
        TimeSpan TimerMerge = Timer.Elapsed;

        Console.WriteLine("Array ordinato con: Merge Sort");
        Console.WriteLine($"Il Merge Sort ci ha messo {TimerMerge}");

        //Comparazione Tempistiche di Ordinamento
        TimeSpan[] Tempi = {TimerBubble, TimerSelection, TimerInsertion, TimerMerge};
        string[] nomi = { "Bubble Sort", "Selection Sort", "Insertion Sort", "Merge Sort" };

        int indiceMinimo = 0;

        for (int i = 0; i < Tempi.Length; i++)
        {
            if (Tempi[i] < Tempi[indiceMinimo])
            {
                indiceMinimo = i;
            }
        }
        Console.WriteLine($"\n L'algoritmo di benchmark più efficiente è: {nomi[indiceMinimo]} con un tempo di: {Tempi[indiceMinimo]}");

        EsportaContatti(nominativiOrdinati);
    }


    static List<string> CaricaContatti()
    {
        List<string> nominativi = new List<string>();
        if (File.Exists(FilePath))
        {
            var righe = File.ReadAllLines(FilePath);
            foreach (var riga in righe)
            {
                var dati = riga.Split(',');
                if (dati.Length == 4)
                {
                    string nominativo = $"{dati[0]} {dati[1]}";
                    nominativi.Add(nominativo);
                    rubrica[nominativo] = new[] { dati[2], dati[3] };
                }
            }
            Console.WriteLine("Contatti caricati dalla Rubrica2.csv.");
        }
        return nominativi;
    }

        
    static void EsportaContatti(List<string>nominativi)
    {
        string fileName = "RubricaOrdinata.csv";

        var righe = new List<string>();

        foreach (var nome in nominativi)
        {
            if (rubrica.ContainsKey(nome))
            {
                string riga = $"{nome},{rubrica[nome][0]},{rubrica[nome][1]}";
                righe.Add(riga);
            }
        }
        File.WriteAllLines(fileName, righe);
        Console.WriteLine("\nContatti esportati.");
    }
}
