using System;

namespace Perhitungan
{
    class Home
    {
        static void Main(string[] args)
        {
            Menu.menu();
            int pilih = Convert.ToInt32(Console.ReadLine());

            if (pilih == 1)
            {
                Console.Clear();
                Nilai.jalurPrestasi();
            }
            else if (pilih == 2)
            {
                Console.Clear();
                Nilai.jalurUTBK();
            }
            else
            {
                Console.WriteLine("Pilihan tidak valid");
            }
        }
    }
       
    class Menu
    {
        public static void menu()
        {
            Console.WriteLine("Pilih Menu:");
            Console.WriteLine("1. Jalur Prestasi");
            Console.WriteLine("2. Jalur UTBK");
            Console.Write("Masukan angka antara 1/2:");
        }
    }

    class Nilai
    {
        public static void jalurPrestasi()
        {
            int nilaiTka = 280;

            Console.Write("Masukan Nilai MTK: ");
            int nilaiMtk = Convert.ToInt32(Console.ReadLine());

            while(nilaiMtk > 100)
            {
                Console.WriteLine("Batas Maksimal memasukan nilai yaitu 100");
                Console.Write("Masukan Ulang Nilai MTK: ");
                nilaiMtk = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Masukan Nilai Bahasa Inggrish: ");
            int nilaiBahasaInggrish = Convert.ToInt32(Console.ReadLine());
            while (nilaiBahasaInggrish > 100)
            {
                Console.WriteLine("Batas Maksimal memasukan nilai yaitu 100");
                Console.Write("Masukan Ulang Nilai Bahasa Inggrish: ");
                nilaiBahasaInggrish = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Masukan Nilai Mapel Pilihan: ");
            int nilaiMapelPilihan = Convert.ToInt32(Console.ReadLine());
            while (nilaiMapelPilihan > 100)
            {
                Console.WriteLine("Batas Maksimal memasukan nilai yaitu 100");
                Console.Write("Masukan Ulang Nilai Mapel Pilihan: ");
                nilaiMapelPilihan = Convert.ToInt32(Console.ReadLine());
            }

            Console.Clear();
            int totalNilai = nilaiMtk + nilaiBahasaInggrish + nilaiMapelPilihan;
            Console.WriteLine("Total Nilai Anda: " + totalNilai);

            if (totalNilai >= nilaiTka)
            {
                Console.WriteLine("Selamat Anda Lulus");
            }
            else
            {
                Console.WriteLine("Maaf Anda Tidak Lulus");
            }
        }

        public static void jalurUTBK()
        {
            Console.WriteLine("Masukan Nilai UTBK Anda: ");
            Console.WriteLine();
            Console.Write("Masukan Nilai Subtest 1: ");
            double sub1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukan Nilai Subtest 2: ");
            double sub2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukan Nilai Subtest 3: ");
            double sub3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukan Nilai Subtest 4: ");
            double sub4 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukan Nilai Subtest 5: ");
            double sub5 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukan Nilai Subtest 6: ");
            double sub6 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukan Nilai Subtest 7: ");
            double sub7 = Convert.ToDouble(Console.ReadLine());

            double nilaiUTBK = sub1 + sub2 + sub3 + sub4 + sub5 + sub6 + sub7;

            double nilaiRataRataUTBK = Math.Round(nilaiUTBK / 7, 1);

            Console.Clear();

            Console.WriteLine("Masukan Nilai TKA Anda: ");
            Console.WriteLine();
            Console.Write("Masukan Nilai MTK: ");
            int nilaiMtk = Convert.ToInt32(Console.ReadLine());

            while (nilaiMtk > 100)
            {
                Console.WriteLine("Batas Maksimal memasukan nilai yaitu 100");
                Console.Write("Masukan Ulang Nilai MTK: ");
                nilaiMtk = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Masukan Nilai Bahasa Inggrish: ");
            int nilaiBahasaInggrish = Convert.ToInt32(Console.ReadLine());
            while (nilaiBahasaInggrish > 100)
            {
                Console.WriteLine("Batas Maksimal memasukan nilai yaitu 100");
                Console.Write("Masukan Ulang Nilai Bahasa Inggrish: ");
                nilaiBahasaInggrish = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Masukan Nilai Mapel Pilihan: ");
            int nilaiMapelPilihan = Convert.ToInt32(Console.ReadLine());
            while (nilaiMapelPilihan > 100)
            {
                Console.WriteLine("Batas Maksimal memasukan nilai yaitu 100");
                Console.Write("Masukan Ulang Nilai Mapel Pilihan: ");
                nilaiMapelPilihan = Convert.ToInt32(Console.ReadLine());
            }

            int totalTKA = nilaiMtk + nilaiBahasaInggrish + nilaiMapelPilihan;
            double nilaiAkhirTKA = totalTKA * 0.3;

            double nilaiAkhir = Math.Round(nilaiRataRataUTBK + nilaiAkhirTKA, 1);

            Console.Clear();
            Console.WriteLine("Total Nilai UTBK Anda: " + nilaiUTBK);
            Console.WriteLine("Rata-rata Nilai UTBK Anda: " + nilaiRataRataUTBK);
            Console.WriteLine("Nilai Semua Mapel TKA Anda: " + totalTKA);
            Console.WriteLine("Nilai Akhir TKA Anda: " + nilaiAkhirTKA);
            Console.WriteLine("Nilai Akhir Gabungan Anda: " + nilaiAkhir);

            if (nilaiAkhir > 600)
            {
                Console.WriteLine("Selamat Anda Lulus");
            }
            else
            {
                 Console.WriteLine("Maaf Anda Tidak Lulus");
            }
        }
    }
}