using System;

public class cekAngka
{
    public void AngkaRun()
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
}