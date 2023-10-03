using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace jenis
{
    using Main_data;
    using System.ComponentModel;

    class prasejarah : katalog, Action
    {
        public void setType()
        {
            Console.WriteLine("Pilih masa Prasejarah :");
            Console.WriteLine("1. paleolitikum");
            Console.WriteLine("2. mesolitikum");
            Console.WriteLine("3. neolitikum");
            Console.WriteLine("4. megalitikum");
            Console.WriteLine("\npilihan anda: ");
            int pilih = int.Parse(Console.ReadLine());
            if (pilih == 1)
            {
                this.type = "Paleolitikum";
            }
            else if (pilih == 2)
            {
                this.type = "Mesolitikum";
            }
            else if (pilih == 3)
            {
                this.type = "Neolitikum";
            }
            else if (pilih == 4)
            {
                this.type = "Megalitikum";
            }
            else
            {
                Console.WriteLine("Tidak ada pada menu, mohon ulang kembali program");

            }
            desc_class();
        }
        public void getType()
        {
            Console.WriteLine($"Zaman {this.type}");
        }
        public override void desc_class()
        {
            Console.Clear();
            if (this.type == "Paleolitikum")
            {
                getType();
                Console.WriteLine();
                Console.WriteLine("Zaman batu tua disebut juga dengan istilah paleolitikum.\r\n Alasan disebut dengan zaman batu tua karena alat-alat yang digunakan manusia purba kala itu masih berupa batu-batu besar dan juga kasar.");
            }
            else if (this.type == "Mesolitikum")
            {
                getType();
                Console.WriteLine();
                Console.WriteLine("zaman batu tengah, di sini peralatan batu yang digunakan oleh manusia purba sudah mulai ada peningkatan.\r\n Peralatan batu yang semula masih besar dan kasar kini mulai dimodifikasi oleh manusia purba menjadi lebih halus dan berukuran lebih kecil.");
            }
            else if (this.type == "Neolitikum")
            {
                getType();
                Console.WriteLine();
                Console.WriteLine("Zaman batu baru atau disebut juga dengan neolitikum. Berbagai peralatan juga semakin inovatif. \r\nUntuk kehidupan masyarakat di zaman ini juga sudah mulai berada pada fase food producing.");
            }
            else if (this.type == "Megalitikum")
            {
                getType();
                Console.WriteLine();
                Console.WriteLine("Zaman batu yang terakhir adalah zaman batu besar atau yang dikenal dengan zaman megalitikum.\r\nSalah satu ciri khas pada zaman batu ini adalah sudah mulai adanya kepercayaan dari masyarakat di masa tersebut kepada tuhan.");
            }
            Console.WriteLine("\njika anda lanjut, anda tidak dapat kembali kehalaman pengertian masing-masing zaman");
            Console.WriteLine("apakah lanjut? *ya,no,back [y/n/b]");
            string pilih = Console.ReadLine();
            if (pilih == "y")
            {
                Console.Clear();
            }
            else if (pilih == "n")
            {
                Console.Clear();
                Daftar_pustaka();
            }
            else if (pilih == "b")
            {
                Console.Clear();
                setType();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("yang anda masukkan salah");
                Console.WriteLine();
                desc_class();
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
