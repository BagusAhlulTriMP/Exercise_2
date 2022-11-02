using System;
using System.Collections.Generic;
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
        static void Main(string[] args)
        {
        }
    }
}
