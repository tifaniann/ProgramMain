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
                    cekAngka m_cekAngka = new cekAngka();
                    m_cekAngka.AngkaRun();
                }

                else if (pilihan_user == 2)
                {
                    Gajikry m_gaji = new Gajikry();
                    m_gaji.GajiRun();
                }
                else if (pilihan_user == 3)
                {
                    calcu m_calcu = new calcu();
                    m_calcu.calcuRun();
                }
                else if (pilihan_user == 4)
                {
                    faktor m_faktor = new faktor();
                    m_faktor.faktorRun();
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

    }

}
