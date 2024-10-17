using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Algoritmi
{

    //RubricaContatti Oggettorubrica = new RubricaContatti();




    //METODO DI ORDINAMENTO BUBLESORT
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

    

    ////METODO DI ORDINAMENTO SELECTIONSORT

    //static void SelectionSort(int[] arr)
    //{
    //    int n = arr.Length;

    //    for (int i = 0; i < n - 1; i++)
    //    {
    //        // Find the index of the minimum element in the unsorted part
    //        int minIndex = i;
    //        for (int j = i + 1; j < n; j++)
    //        {
    //            if (arr[j] < arr[minIndex])
    //            {
    //                minIndex = j;
    //            }
    //        }

    //        // Swap the found minimum element with the first element
    //        if (minIndex != i)
    //        {
    //            Swap(ref arr[minIndex], ref arr[i]);
    //        }
    //    }
    //}

    //static void Swap(ref int a, ref int b)
    //{
    //    int temp = a;
    //    a = b;
    //    b = temp;
    //}

    //static void PrintArray(int[] arr)
    //{
    //    foreach (int value in arr)
    //    {
    //        Console.Write(value + " ");
    //    }
    //    Console.WriteLine();
    //}

    ////METODO DI ORDINAMENTO INSERTIONSORT
    //static void InsertionSort(int[] arr)
    //{
    //    int n = arr.Length;

    //    for (int i = 1; i < n; i++)
    //    {
    //        int key = arr[i];
    //        int j = i - 1;

    //        // Move elements of arr[0..i-1], that are greater than key,
    //        // to one position ahead of their current position
    //        while (j >= 0 && arr[j] > key)
    //        {
    //            arr[j + 1] = arr[j];
    //            j--;
    //        }
    //        arr[j + 1] = key;
    //    }
    //}

    ///*
    //static void PrintArray2(int[] arr)
    //{
    //    foreach (int value in arr)
    //    {
    //        Console.Write(value + " ");
    //    }
    //    Console.WriteLine();
    //}
    //*/

    ////METODO DI ORDINAMENTO INSERTIONSORT
    //   
    //        int[] array = { 64, 25, 12, 22, 11 };

    //        Console.WriteLine("Original array:");
    //        PrintArray(array);

    //        MergeSort(array, 0, array.Length - 1);

    //        Console.WriteLine("Sorted array:");
    //        PrintArray(array);
    //    }

    //    static void MergeSort(int[] arr, int left, int right)
    //    {
    //        if (left < right)
    //        {
    //            int mid = (left + right) / 2;

    //            // Recursively sort the first half
    //            MergeSort(arr, left, mid);
    //            // Recursively sort the second half
    //            MergeSort(arr, mid + 1, right);
    //            // Merge the sorted halves
    //            Merge(arr, left, mid, right);
    //        }
    //    

    //    static void Merge(int[] arr, int left, int mid, int right)
    //    {
    //        int n1 = mid - left + 1;
    //        int n2 = right - mid;

    //        // Create temporary arrays
    //        int[] L = new int[n1];
    //        int[] R = new int[n2];

    //        // Copy data to temporary arrays
    //        Array.Copy(arr, left, L, 0, n1);
    //        Array.Copy(arr, mid + 1, R, 0, n2);

    //        // Merge the temporary arrays back into arr[left..right]
    //        int i = 0, j = 0, k = left;

    //        while (i < n1 && j < n2)
    //        {
    //            if (L[i] <= R[j])
    //            {
    //                arr[k] = L[i];
    //                i++;
    //            }
    //            else
    //            {
    //                arr[k] = R[j];
    //                j++;
    //            }
    //            k++;
    //        }

    //        // Copy remaining elements of L[] if any
    //        while (i < n1)
    //        {
    //            arr[k] = L[i];
    //            i++;
    //            k++;
    //        }

    //        // Copy remaining elements of R[] if any
    //        while (j < n2)
    //        {
    //            arr[k] = R[j];
    //            j++;
    //            k++;
    //        }
        

    //    /*
    //    static void PrintArray(int[] arr)
    //    {
    //        foreach (int value in arr)
    //        {
    //            Console.Write(value + " ");
    //        }
    //        Console.WriteLine();
    //    }*/
    //    }




}



