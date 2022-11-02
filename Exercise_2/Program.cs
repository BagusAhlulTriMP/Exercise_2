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
        }
        static void Main(string[] args)
        {
        }
    }
}
