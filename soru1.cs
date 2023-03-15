using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        const int diziboyut = 10000;
        const int aranandeger = 9999;
        int[] array = new int[diziboyut];
        Random random = new Random();

        // Rastgele sayılar dizisi oluşturuyoruz
        for (int k = 0; k < diziboyut; k++)
        {
            array[k] = random.Next(10000);
        }

        // linear search algortiması  (bruteforce algoritma)
        Stopwatch linearWatch = Stopwatch.StartNew();
        int linearIndex = LinearSearch(array, aranandeger);
        linearWatch.Stop();

        // binary search algoritması süresi
        Array.Sort(array);
        Stopwatch binaryWatch = Stopwatch.StartNew();
        int binaryIndex = BinarySearch(array, aranandeger);
        binaryWatch.Stop();

        // Sonuçları yazdırıyoruz
        Console.WriteLine($"Dogrusal arama algoritmasi sonucu: {linearWatch.Elapsed}\n");
        Console.WriteLine($"ikili arama algoritmasi sonucu: {binaryWatch.Elapsed}");
    }
//linear search algoritması istenilen elemanı arama
    static int LinearSearch(int[] array, int value)
    {
        for (int k = 0; k < array.Length; k++)
        {
            if (array[k] == value)
            {
                return k;
            }
        }
        return -1;
    }
    
// binary search algoritması istenilen elemanı arama
    static int BinarySearch(int[] array, int value)
    {
        int minimum = 0;
        int maximum = array.Length - 1;

        while (minimum <= maximum)
        {
            int mid = (minimum + maximum) / 2;
            if (array[mid] == value)
            {
                return mid;
            }
            else if (array[mid] < value)
            {
                minimum = mid + 1;
            }
            else
            {
                maximum = mid - 1;
            }
        }
        return-1;
}
}