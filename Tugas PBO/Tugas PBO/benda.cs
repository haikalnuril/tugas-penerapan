using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benda
{
    using Main_data;
    class benda : Action
    {
        public void display()
        {
            Console.WriteLine("Benda-Benda Prasejarah");
            Console.WriteLine("1. Paleolitikum");
            Console.WriteLine("2. Mesolitikum");
            Console.WriteLine("3. Neolitikum");
            Console.WriteLine("4. Megalitikum");
            Console.WriteLine("\napakah ingin display 1 atau 2 zaman sekaligus? [1 / 2]");
            int tampil = int.Parse(Console.ReadLine());
            if (tampil == 1)
            {
                Console.WriteLine("Zaman apa yang ingin anda pilih?");
                int input = int.Parse(Console.ReadLine());
                display(input);
            }
            else if (tampil == 2)
            {
                Console.WriteLine("masukkan zaman ke 1");
                int input1 = int.Parse(Console.ReadLine());
                Console.WriteLine("masukkan zaman ke 2");
                int input2 = int.Parse(Console.ReadLine());
                display(input1, input2);
            }
        }
        public void display(int a)
        {
            Console.Clear();
            if (a == 1)
            {
                Console.WriteLine("ZAMAN PALEOLITIKUM");
                Console.WriteLine("1. Kapak Perimbas");
                Console.WriteLine("2. Kapak Genggam");
                Console.WriteLine("3. Flakes");
            }
            else if (a == 2)
            {
                Console.WriteLine("ZAMAN MESOLITIKUM");
                Console.WriteLine("1. pebble");
                Console.WriteLine("2. Kjokkenmoddinger");
                Console.WriteLine("3. Batu Pipisan");
            }
            else if (a == 3)
            {
                Console.WriteLine("ZAMAN NEOLITIKUM");
                Console.WriteLine("1.kapak persegi");
                Console.WriteLine("2. kapak lonjong");
                Console.WriteLine("3. Pakaian Kulit Kayu");
            }
            else if (a == 4)
            {
                Console.WriteLine("ZAMAN MEGALITIKUM");
                Console.WriteLine("1. menhir");
                Console.WriteLine("2. dolmen");
                Console.WriteLine("3. sarkofagus");
                Console.WriteLine("4. waruga");
            }
            else
            {
                Console.WriteLine("yang anda masukkan salah.");
                display();
            }
            Console.WriteLine("tutup katalog? *jika n maka akan kembali menu sebelumnya [y/n]");
            string pilih = Console.ReadLine();
            if (pilih == "y")
            {
                Console.Clear();
                Daftar_pustaka();
            }
            else if (pilih == "n")
            {
                Console.Clear();
                display();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("yang anda masukkan salah");
                Console.WriteLine();
                display();
            }

        }
        public void display(int a, int b)
        {
            Console.Clear();
            if ((a == 1 && b == 2) || (a == 2 && b == 1))
            {
                Console.WriteLine("ZAMAN PALEOLITIKUM");
                Console.WriteLine("1. Kapak Perimbas");
                Console.WriteLine("2. Kapak Genggam");
                Console.WriteLine("3. Flakes");
                Console.WriteLine("\nZAMAN MESOLITIKUM");
                Console.WriteLine("1. pebble");
                Console.WriteLine("2. Kjokkenmoddinger");
                Console.WriteLine("3. Batu Pipisan");
            }
            else if ((a == 1 && b == 3) || (a == 3 && b == 1))
            {
                Console.WriteLine("ZAMAN PALEOLITIKUM");
                Console.WriteLine("1. Kapak Perimbas");
                Console.WriteLine("2. Kapak Genggam");
                Console.WriteLine("3. Flakes");
                Console.WriteLine("\nZAMAN NEOLITIKUM");
                Console.WriteLine("1.kapak persegi");
                Console.WriteLine("2. kapak lonjong");
                Console.WriteLine("3. Pakaian Kulit Kayu");
            }
            else if ((a == 1 && b == 4) || (a == 4 && b == 1))
            {
                Console.WriteLine("ZAMAN PALEOLITIKUM");
                Console.WriteLine("1. Kapak Perimbas");
                Console.WriteLine("2. Kapak Genggam");
                Console.WriteLine("3. Flakes");
                Console.WriteLine("\nZAMAN MEGALITIKUM");
                Console.WriteLine("1. menhir");
                Console.WriteLine("2. dolmen");
                Console.WriteLine("3. sarkofagus");
                Console.WriteLine("4. waruga");
            }
            else if ((a == 2 && b == 3) || (a == 3 && b == 2))
            {
                Console.WriteLine("ZAMAN MESOLITIKUM");
                Console.WriteLine("1. pebble");
                Console.WriteLine("2. Kjokkenmoddinger");
                Console.WriteLine("3. Batu Pipisan");
                Console.WriteLine("\nZAMAN NEOLITIKUM");
                Console.WriteLine("1.kapak persegi");
                Console.WriteLine("2. kapak lonjong");
                Console.WriteLine("3. Pakaian Kulit Kayu");
            }
            else if ((a == 2 && b == 4) || (a == 4 && b == 2))
            {
                Console.WriteLine("ZAMAN MESOLITIKUM");
                Console.WriteLine("1. pebble");
                Console.WriteLine("2. Kjokkenmoddinger");
                Console.WriteLine("3. Batu Pipisan");
                Console.WriteLine("\nZAMAN MEGALITIKUM");
                Console.WriteLine("1. menhir");
                Console.WriteLine("2. dolmen");
                Console.WriteLine("3. sarkofagus");
                Console.WriteLine("4. waruga");
            }
            else if ((a == 3 && b == 4) || (a == 4 && b == 3))
            {
                Console.WriteLine("ZAMAN NEOLITIKUM");
                Console.WriteLine("1.kapak persegi");
                Console.WriteLine("2. kapak lonjong");
                Console.WriteLine("3. Pakaian Kulit Kayu");
                Console.WriteLine("\nZAMAN MEGALITIKUM");
                Console.WriteLine("1. menhir");
                Console.WriteLine("2. dolmen");
                Console.WriteLine("3. sarkofagus");
                Console.WriteLine("4. waruga");
            }
            else
            {
                Console.WriteLine("yang anda masukkan salah.");
                display();
            }
            Console.WriteLine("tutup katalog? *jika n maka akan kembali menu sebelumnya [y/n]");
            string pilih = Console.ReadLine();
            if (pilih == "y")
            {
                Console.Clear();
                Daftar_pustaka();
            }
            else if (pilih == "n")
            {
                Console.Clear();
                display();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("yang anda masukkan salah");
                Console.WriteLine();
                display();
            }
        }
        public void Daftar_pustaka()
        {
            Console.WriteLine("Terima Kasih Telah Membaca Katalog Kami.\n refrensi yang kami gunakan:\n https:ditsmp.kemdikbud.go.id");
            Console.ReadLine();
            Environment.Exit(0);
        }
    }
}
