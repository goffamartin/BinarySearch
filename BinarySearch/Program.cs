using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace BinarySearch
{
    class Program
    {
        static Stopwatch stopwatch = new Stopwatch();
        static void Main(string[] args)
        {
            int[] intArray = new int[100000];
            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = i;
            }
            int searchedNumber = 65478;
            stopwatch.Start();
            BinarySearch(searchedNumber, intArray, 0, intArray.Length - 1);
            Console.WriteLine($@"index čísla {searchedNumber} je {index}

Hledání trvalo: 
{stopwatch.ElapsedMilliseconds} milisekund
{stopwatch.ElapsedTicks} ticks

Hloubka rekurze: {recursion}");
            Console.ReadLine();
        }
        static int recursion = 0;
        static int index = 0;

        static void BinarySearch(int searchedValue, int[] array, int indexFrom, int indexTo)
        {
            recursion++;
            if (indexFrom > indexTo)
                index = -1;
           
            int halfOfArray = indexFrom +(indexTo - indexFrom)/2;

            if (searchedValue == array[halfOfArray])
            {
                index = halfOfArray;
                stopwatch.Stop();
            }
            else if (searchedValue < array[halfOfArray])
                BinarySearch(searchedValue, array, 0, halfOfArray - 1);
            else if (searchedValue > array[halfOfArray])
                BinarySearch(searchedValue, array, halfOfArray + 1, indexTo);
        }
    }
}
