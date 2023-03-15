using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        int[] array = new int[10000];
        Random random = new Random();

        // Rastgele dizi oluşturuyoruz
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(1, 10000);
        }

        // Quick Sort işlem süresi hesaplıyoruz
        Stopwatch quickSortTimer = Stopwatch.StartNew();
        QuickSort(array, 0, array.Length - 1);
        quickSortTimer.Stop(); // ekrana yazdırıyoruz
        Console.WriteLine("Quick Sort islem süresi: " + quickSortTimer.ElapsedMilliseconds + " ms");

        // Selection Sort işlem süresi hesaplıyoruz
        Stopwatch selectionSortTimer = Stopwatch.StartNew();
        SelectionSort(array);
        selectionSortTimer.Stop();// ekrana yazdırıyoruz
        Console.WriteLine("Selection Sort islem suresi : " + selectionSortTimer.ElapsedMilliseconds + " ms");
    }

    // Quick Sort algoritmasıile diziyi sıralıyoruz
    static void QuickSort(int[] array, int left, int right)
    {
        if (left < right)
        {
            int pivot = Partition(array, left, right);
            QuickSort(array, left, pivot - 1);
            QuickSort(array, pivot + 1, right);
        }
    }

    static int Partition(int[] array, int left, int right)
    {
        int pivot = array[right];
        int i = left - 1;
        for (int j = left; j < right; j++)
        {
            if (array[j] < pivot)
            {
                i++;
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }
        int temp2 = array[i + 1];
        array[i + 1] = array[right];
        array[right] = temp2;
        return i + 1;
    }

    // Selection Sort algoritması ile diziyi sıralıyoruz (bruteforce algoritma)
    static void SelectionSort(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j] < array[minIndex])
                {
                    minIndex = j;
                }
            }
            int temp = array[minIndex];
            array[minIndex] = array[i];
            array[i]=temp;
}
}
}