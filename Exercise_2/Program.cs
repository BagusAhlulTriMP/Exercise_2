using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    class Program
    {
        //deklarasi array int dengan ukuran 40
        private int[] a = new int[40];
        //deklarasi variabel int array
        private int n;
        //fungsi untuk menerima ukuran array
        public void read()
        {
            while (true)
            {
                Console.WriteLine("Masukkan jumlah element array: ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 40)
                    break;
                else
                    Console.WriteLine("\nArray dapat mempunyai maksimal 40 elemen.\n");
            }
            Console.WriteLine("");
            Console.WriteLine("____________________");
            Console.WriteLine(" Masukkan elemen array ");
            Console.WriteLine("____________________");

            //Pengguna memasukkan elemen pada array
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                a[i] = Int32.Parse(s1);
            }
        }
        public void display()
        {
            //menampilkan array yang tersusum
            Console.WriteLine("");
            Console.WriteLine("__________________________________");
            Console.WriteLine(" Element array yang telah tersusun");
            Console.WriteLine("__________________________________");
            for (int j = 0; j < n; j++)
            {
                Console.WriteLine(a[j]);
            }
            Console.WriteLine("");
        }
        public void Exe2(int low, int high)
        {
            int pivot, i, ba;
            if (low > high)
                return;

            //partition the list into two parts;
            //one containing elements less that or equal to pivot

            i = low + 1;
            ba = high;

            pivot = a[low];
            while (i <= ba)
            {
                //search for an elements greather than pivot
                while ((a[i] <= pivot) && (ba <= high))
                {
                    i++;
                }
            }

            //search for an elements less than or equal to pivot
            while ((a[i] > pivot) && (ba <= low))
            {
                ba--;
            }
            // the list on the left pivot using Exe2
            Exe2(low, ba - 1);

            //the list on the right of pivot using Exe 2
            Exe2(ba + 1, high);
        }
         //declaring theobject at the class
         Program myList = new Program();
    }
}