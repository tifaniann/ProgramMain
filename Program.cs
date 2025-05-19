using System;
using System.Diagnostics;

namespace ConsoleAppRobot
{
    class Program
    {
        static void Main(string[] args)
        {
            // int firstValue = 500;
            // int secondValue = 600;
            // int largerValue;
            // largerValue = Math.Max(firstValue, secondValue);
            // Console.WriteLine(largerValue);

            Console.WriteLine(@"Selamat datang di mesin C# Tifani!
            Silahkan pilih menu
            1. Mengecek angka
            2. Perhitungan gaji karyawan
            3. kalkulator
            4. Perhitungan faktorial");

            int pilihan_user;
            try
            {
                Console.Write("Pilihan: ");
                pilihan_user = int.Parse(Console.ReadLine());
                if (pilihan_user == 1)
                {
                    cekAngka();
                }
                else if (pilihan_user == 2)
                {
                    Gajikry();
                }
                else if (pilihan_user == 3)
                {
                    calcu();
                }
                else if (pilihan_user == 4)
                {
                    faktor();
                }
                else
                {
                    Console.WriteLine("pilihan tidak tersedia");
                }

            }
            catch (System.Exception)
            {
                Console.WriteLine("pilihan tidak tersedia");
                throw;
            }
            // int.Parse(Console.ReadLine());

            Console.WriteLine("terima kasih");
            Console.ReadLine(); // agar terminal tidak langsung close
        }

        static void cekAngka()
        {
            primaBilangan b = new primaBilangan();
            bilangan_gg gg = new bilangan_gg();
            cek_array Arracek = new cek_array();

            bool ulangilagi = true;
            while (ulangilagi)
            {
                Console.WriteLine("silahkan pilih menu pengecekan");
                Console.WriteLine("1. cek bilangan prima");
                Console.WriteLine("2. cek bilangan ganjil/genap");
                Console.WriteLine("3. cek array");
                Console.Write("pilihan: ");

                int pilihan;
                bool cek_pil = false;

                try
                {
                    pilihan = int.Parse(Console.ReadLine());
                    if (pilihan == 1)
                    {
                        cek_pil = true;
                        Console.WriteLine("PRIMA");
                    }
                    else if (pilihan == 2)
                    {
                        cek_pil = true;
                        Console.WriteLine("GANJIL/GENAP");
                    }
                    else if (pilihan == 3)
                    {
                        cek_pil = true;
                        Console.WriteLine("ARRAY(mengecek jumlah bilangan genap dalam sebuah list angka)");
                    }
                    else
                    {
                        Console.WriteLine("pilihan tersebut tidak tersedia");
                    }

                    if (cek_pil)
                    {
                        Console.Write("masukan angka yang akan dicek: ");
                        try
                        {
                            if (pilihan == 1)
                            {
                                b.nilai = int.Parse(Console.ReadLine());
                                b.IsPrime();
                            }
                            else if (pilihan == 2)
                            {
                                gg.angka_gg = int.Parse(Console.ReadLine());
                                gg.cek_gg();
                            }
                            else if (pilihan == 3)
                            {
                                Console.WriteLine("masukkan 5 angka");
                                for (int i = 0; i < Arracek.list_angka.Length; i++)
                                {
                                    Arracek.list_angka[i] = int.Parse(Console.ReadLine());
                                }
                                Arracek.isi_array();
                            }
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("HARUS ANGKA!");
                        }
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("pilihan tersebut tidak tersedia");
                }

                Console.WriteLine("Ingin mengecek lagi (y/n)?");
                string jawaban = Console.ReadLine();
                if (jawaban.ToLower() != "y")
                {
                    ulangilagi = false;
                }
            }
        }

        static void Gajikry()
        {
            gaji_komisi gk = new gaji_komisi();

            Console.Write("nama pegawai: ");
            gk.nama = Console.ReadLine();
            Console.Write("gaji pokok (contoh: 1000000): ");
            gk.gajipokok = double.Parse(Console.ReadLine());
            Console.Write("total penjualan (contoh: 1000000): ");
            gk.ttl_penjualan = double.Parse(Console.ReadLine());

            gk.perhitungan_gk();
        }

        static void calcu()
        {
            calculator_mesin cm = new calculator_mesin();

            try
            {
                Console.WriteLine("Selamat datang di mesin kalkulator");
                Console.Write("Masukan angka pertama: ");
                cm.angka1 = int.Parse(Console.ReadLine());

                Console.Write("Masukkan operator (+, -, *, /): ");
                cm.op = char.Parse(Console.ReadLine());

                Console.Write("Masukkan angka kedua: ");
                cm.angka2 = int.Parse(Console.ReadLine());

                cm.mesin_hitung();
            }
            catch (Exception)
            {
                Console.WriteLine("Angka/operator Tidak valid!!!!!");
            }
        }

        static void faktor()
        {
            faktorial ff = new faktorial();

            try
            {
                Console.WriteLine("Mesin faktorial");
                Console.Write("Masukkan Angka: ");
                int angka = int.Parse(Console.ReadLine());

                int? hasil = ff.Mesinfakt(angka);
                if (hasil != null)
                {
                    Console.WriteLine($"Faktorial dari {angka} adalah {hasil}");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Tidak valid");
            }
        }
    }

    public class primaBilangan
    {
        public int nilai;

        public void IsPrime()
        {
            if (nilai <= 1)
            {
                Console.WriteLine($"{nilai} bukan bilangan prima.");
                return;
            }

            bool prima = true;

            for (int i = 2; i <= Math.Sqrt(nilai); i++)
            {
                if (nilai % i == 0)
                {
                    prima = false;
                    break;
                }
            }

            if (prima)
            {
                Console.WriteLine($"{nilai} adalah bilangan prima");
            }
            else
            {
                Console.WriteLine($"{nilai} bukan bilangan prima");
            }
        }
    }

    public class bilangan_gg
    {
        public int angka_gg;

        public void cek_gg()
        {
            if (angka_gg % 2 == 0)
            {
                Console.WriteLine($"{angka_gg} adalah bilangan genap");
            }
            else
            {
                Console.WriteLine($"{angka_gg} adalah bilangan ganjil");
            }
        }
    }

    public class cek_array
    {
        public int[] list_angka = new int[5];
        public int countgenap;

        public void isi_array()
        {
            countgenap = 0;
            for (int i = 0; i < list_angka.Length; i++)
            {
                if (list_angka[i] % 2 == 0)
                {
                    countgenap++;
                }
            }
            Console.WriteLine($"jumlah bilangan genap adalah {countgenap}");
        }
    }

    public class gaji_komisi
    {
        public double gajipokok;
        public double ttl_penjualan;
        public double komisi;
        public string nama;
        public double penghasilan;

        public void perhitungan_gk()
        {
            if (ttl_penjualan >= 50000000)
            {
                komisi = ttl_penjualan * 0.05;
            }
            else
            {
                komisi = 0;
            }

            penghasilan = gajipokok + komisi;

            Console.WriteLine($"total penghasilan {nama} sebesar {penghasilan}");
        }
    }

    public class calculator_mesin
    {
        public int angka1;
        public int angka2;
        public char op;
        public int hasil;
        public bool valid_v = true;

        public void mesin_hitung()
        {
            switch (op)
            {
                case '+':
                    hasil = angka1 + angka2;
                    break;
                case '-':
                    hasil = angka1 - angka2;
                    break;
                case '/':
                    if (angka2 == 0)
                    {
                        Console.WriteLine("tidak bisa dibagi dengan 0");
                        valid_v = false;
                    }
                    else
                    {
                        hasil = angka1 / angka2;
                    }
                    break;
                case '*':
                    hasil = angka1 * angka2;
                    break;
                default:
                    Console.WriteLine("Operator tidak tersedia");
                    valid_v = false;
                    break;
            }

            if (valid_v)
            {
                Console.WriteLine($"Hasil dari {angka1} {op} {angka2} adalah {hasil}");
            }
            else
            {
                Console.WriteLine("Silahkan coba lagi");
            }
        }
    }

    public class faktorial
    {
        public int? Mesinfakt(int n)
        {
            if (n < 0)
            {
                Console.WriteLine("Faktorial tidak terdefinisi untuk angka negatif.");
                return null;
            }
            else if (n == 0 || n == 1)
            {
                return 1;
            }
            else
            {
                int? hasil = n * Mesinfakt(n - 1);
                return hasil;
            }
        }
    }
}
