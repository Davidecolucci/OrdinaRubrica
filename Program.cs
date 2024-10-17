
using System.Diagnostics;

public class RubricaContatti
{
    const string FilePath = "Rubrica2.csv";

    static Dictionary<string, string[]> rubrica = new Dictionary<string, string[]>();
    

    

    static void Main()
    {
        List<string> nominativi = CaricaContatti();
        
        Stopwatch Timer= new Stopwatch();
        Timer.Start();
        Algoritmi.BubbleSort(nominativi);
        Timer.Stop();
        

        Console.WriteLine("Array ordinato con: Bubblesort");
        Console.WriteLine($"Il Bubblesort ci ha messo {Timer}");

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
                    string nominativo = $"{dati[0]} {dati[1]}";               //dati[0] + dati[1];
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
