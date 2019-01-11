using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quick_Sort_Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int[] dizi = { 23, 398, 34, 100, 57, 67, 55, 320 };
            for (int i = 0; i < dizi.Length; i++)
            {
                //dizi[i] = r.Next(10, 100);
                Console.Write(dizi[i] + " ");
            }
            QuickSort(dizi, 0, dizi.Length - 1);

            Console.ReadKey();
        }//123456789


        public static void QuickSort(int[] dizi, int indexSol, int indexSag)
        {
            if (indexSol < indexSag)
            {
                int q = Partition(dizi, indexSol, indexSag);
                QuickSort(dizi, indexSol, q - 1);
                QuickSort(dizi, q + 1, indexSag);
            }
        }
        private static int Partition(int[] dizi, int indexSol, int indexSag)
        {
            int pivot = dizi[indexSag];
            int temp;
            int i = indexSol;
            for (int j = indexSol; j < indexSag; j++)
            {
                if (dizi[j] <= pivot)
                { temp = dizi[j]; dizi[j] = dizi[i]; dizi[i] = temp; i++; }
            }
            dizi[indexSag] = dizi[i]; dizi[i] = pivot;
            yazdir(dizi);
            return i;
        }

        public static void yazdir(int[] dizi)
        {
            Console.WriteLine();
            foreach (int sayi in dizi)
            {
                Console.Write(sayi + " ");
            }
        }

    }
}
