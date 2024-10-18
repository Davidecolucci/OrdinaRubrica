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
    public static void InsertionSort(List<string> lista)
    {
        int n = lista.Count;
        for (int i = 1; i < n; i++)
        {
            string chiave = lista[i];
            int j = i - 1;

            // Sposta gli elementi di lista[0..i-1] che sono maggiori di chiave
            // a una posizione davanti alla loro posizione attuale
            while (j >= 0 && string.Compare(lista[j], chiave) > 0)
            {
                lista[j + 1] = lista[j];
                j--;
            }
            lista[j + 1] = chiave;
        }
    }


    //METODO DI ORDINAMENTO MERGE SORT
    public static List<string> MergeSort(List<string> lista)
    {
        if (lista.Count <= 1)
        {
            return lista;
        }

        int mid = lista.Count / 2;

        // Ordina la prima metà
        var leftList = MergeSort(lista.GetRange(0, mid));
        // Ordina la seconda metà
        var rightList = MergeSort(lista.GetRange(mid, lista.Count - mid));

        // Unisci le due metà
        return Merge(leftList, rightList);
    }

    static List<string> Merge(List<string> leftList, List<string> rightList)
    {
        List<string> mergedList = new List<string>();
        int i = 0, j = 0;

        while (i < leftList.Count && j < rightList.Count)
        {
            if (string.Compare(leftList[i], rightList[j]) <= 0)
            {
                mergedList.Add(leftList[i++]);
            }
            else
            {
                mergedList.Add(rightList[j++]);
            }
        }

        // Copia gli elementi rimanenti, se ce ne sono
        while (i < leftList.Count)
        {
            mergedList.Add(leftList[i++]);
        }

        while (j < rightList.Count)
        {
            mergedList.Add(rightList[j++]);
        }

        return mergedList;
    }
}









