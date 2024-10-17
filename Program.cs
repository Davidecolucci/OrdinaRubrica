
using System.Diagnostics;

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
        Algoritmi.BubbleSort(nominativi);
        Timer.Stop();

        Console.WriteLine("Array ordinato con: Bubble Sort");
        Console.WriteLine($"Il Bubble Sort ci ha messo {Timer}");

        //Chiamata Selection Sort + Calcolo del tempo
        Timer.Restart();
        Algoritmi.SelectionSort(nominativi);
        Timer.Stop();

        Console.WriteLine("Array ordinato con: Selection Sort");
        Console.WriteLine($"Il Selection Sort ci ha messo {Timer}");

        //Chiamata Insertion Sort + Calcolo del tempo
        Timer.Restart();
        Algoritmi.InsertionSort(nominativi);
        Timer.Stop();

        Console.WriteLine("Array ordinato con: Insertion Sort");
        Console.WriteLine($"Il Insertion Sort ci ha messo {Timer}");

        
        //Chiamata Merge Sort + Calcolo del tempo
        Timer.Restart();
        Algoritmi.MergeSort(nominativi);
        Timer.Stop();

        Console.WriteLine("Array ordinato con: Merge Sort");
        Console.WriteLine($"Il Merge Sort ci ha messo {Timer}");
        

        EsportaContatti(nominativi);
    }



    static List<string> CaricaContatti()
    {
        List<string> nominativi = [];
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
        string fileName = "RubricaOrdinata1.csv";

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
        Console.WriteLine("Contatti esportati.");
    }
    
}
