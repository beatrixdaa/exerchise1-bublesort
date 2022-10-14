using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise1beatrix
{
    class program
    {
        //Deklarasi array int dengan ukuran 21
        private int[] beatrix = new int[21];

        //Deklarasi variabel int untuk menyimpan banyaknya data pada array
        private int n;

        // Fungsi / Method untuk menerima masukan
        public void read()
        {

            //menerima angka untuk menentukan banyaknya data yang disimpan pada
            while (true)
            {
                Console.Write("Masukkan banyaknya elemen pada Array: ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 21)
                    break;
                else
                    Console.WriteLine("\nArray dapat mempunyai maksimal 21 elemen.\n");
            }
            Console.WriteLine("");
            Console.WriteLine("******************************");
            Console.WriteLine(" Masukkan Jumlah Elemen Array ");
            Console.WriteLine("******************************");

            // Pengguna memasukkan elemen pada array
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("<" + (i + 1) + "> ");
                string s1 = Console.ReadLine();
                beatrix[i] = Int32.Parse(s1);
            }
        }
        public void display()
        {
            //Menampilkan array yang tersusun
            Console.WriteLine("");
            Console.WriteLine("***********************************");
            Console.WriteLine(" Element Array yang telah tersusun ");
            Console.WriteLine("***********************************");
            for (int j = 0; j < n; j++)
            {
                Console.WriteLine(beatrix[j]);
            }
            Console.WriteLine("");

        }
        public void sortarray()
        {
            //Step 1
            //Repeat steps 2 and 3 varying BA from 0 to n - 2
            for (int BA = 0; BA < n - 1; BA++)
            {

                //Step 2
                //Deklarasi variabel int untuk membuat temperatur dan min_index
                int temp, min_index;

                // a. Set min_index = BA
                min_index = BA;

                // b. Repeat step c varying i from BA + 1 to n - 1
                for (int i = BA + 1; i < n; i++)
                {

                    // c. if beatrix[i] < beatrix[min_index]. min_index = i
                    if (beatrix[i] < beatrix[min_index])
                    {
                        min_index = i;
                    }

                }

                // Step 3
                //Menukar elemen beatrix[min_index] dengan temp 
                temp = beatrix[min_index];
                //Menukar elemen beatrix[min_index] dengan beatrix[BA]
                beatrix[min_index] = beatrix[BA];
                //Menukar elemen beatrix[BA] dengan temp
                beatrix[BA] = temp;
            }
        }
        static void Main(string[] args)
        {   // membuat object class sorting array
            program myList = new program();

            //  Pemanggilann fungsi untuk menerima  array
            myList.read();
            //Pemanggilan funsi untuk mengurutkan array
            myList.sortarray();
            // Pemanggilan fungsi untuk menampilkan array yang tersusun
            myList.display();
            // Exit
            Console.WriteLine("\n\nTekan Tombol Apa saja untuk keluar.");
            Console.Read();
        }
    }
}