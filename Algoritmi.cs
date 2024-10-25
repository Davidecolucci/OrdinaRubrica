using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Algoritmi
{
        
    //METODO DI ORDINAMENTO BUBBLESORT
    public static void BubbleSort(List<string> Nominativi)
    {
        int n = Nominativi.Count;
        bool swapped;

        for (int i = 0; i < n - 1; i++)
        {
            swapped = false;
            for (int j = 0; j < n - i - 1; j++)
            {
                // Confronta le stringhe
                if (string.Compare(Nominativi[j], Nominativi[j + 1]) > 0)
                {
                    // Scambia se sono nell'ordine sbagliato
                    string temp = Nominativi[j];
                    Nominativi[j] = Nominativi[j + 1];
                    Nominativi[j + 1] = temp;
                    swapped = true;
                }
            }
            // Se non ci sono stati scambi, l'array è già ordinato
            if (!swapped)
                break;
        }
    }


    //METODO DI ORDINAMENTO SELECTIONSORT
    public static void SelectionSort(List<string> Nominativi)
    {
        int n = Nominativi.Count;

        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;

            for (int j = i + 1; j < n; j++)
            {
                // Confronta le stringhe
                if (string.Compare(Nominativi[j], Nominativi[minIndex]) < 0)
                {
                    minIndex = j;
                }
            }

            // Scambia l'elemento corrente con il minimo trovato
            if (minIndex != i)
            {
                string temp = Nominativi[i];
                Nominativi[i] = Nominativi[minIndex];
                Nominativi[minIndex] = temp;
            }
        }
    }
        

    //METODO DI ORDINAMENTO INSERTION SORT
    public static void InsertionSort(List<string> Nominativi)
    {
        int n = Nominativi.Count;
        for (int i = 1; i < n; i++)
        {
            string chiave = Nominativi[i];
            int j = i - 1;
            while (j >= 0 && string.Compare(Nominativi[j], chiave) > 0)
            {
                Nominativi[j + 1] = Nominativi[j];
                j--;
            }
            Nominativi[j + 1] = chiave;
        }
    }


    //METODO DI ORDINAMENTO MERGE SORT
    public static List<string> MergeSort(List<string> Nominativi)
    {
        if (Nominativi.Count <= 1)
        {
            return Nominativi;
        }

        int mid = Nominativi.Count / 2;

        // Ordina la prima metà
        var LeftListNominativi = MergeSort(Nominativi.GetRange(0, mid));
        // Ordina la seconda metà
        var RightListNominativi = MergeSort(Nominativi.GetRange(mid, Nominativi.Count - mid));

        // Unisci le due metà
        return Merge(LeftListNominativi, RightListNominativi);
    }

    static List<string> Merge(List<string> LeftListNominativi, List<string> RightListNominativi)
    {
        List<string> mergedList = new List<string>();
        int i = 0, j = 0;

        while (i < LeftListNominativi.Count && j < RightListNominativi.Count)
        {
            if (string.Compare(LeftListNominativi[i], RightListNominativi[j]) <= 0)
            {
                mergedList.Add(LeftListNominativi[i++]);
            }
            else
            {
                mergedList.Add(RightListNominativi[j++]);
            }
        }

        // Copia gli elementi rimanenti, se ce ne sono
        while (i < LeftListNominativi.Count)
        {
            mergedList.Add(LeftListNominativi[i++]);
        }

        while (j < RightListNominativi.Count)
        {
            mergedList.Add(RightListNominativi[j++]);
        }

        return mergedList;
    }
}









