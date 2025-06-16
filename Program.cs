using System;
using System.Diagnostics;

namespace ConsoleAppRobot
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(@"Selamat datang di mesin C# Tifani!
            Silahkan pilih menu
            1. Mengecek angka       2. Perhitungan gaji karyawan
            3. kalkulator           4. Perhitungan faktorial
            5. Grades               6. Testing
            7. FizzBuzz             8. Game Battle
            9. Pet Characteristics  10. Palindrome");

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
                else if (pilihan_user == 5)
                {
                    Grades m_grade = new Grades();
                    m_grade.gradeRun();
                }
                else if (pilihan_user == 6)
                {
                    test m_test = new test();
                    m_test.testRun();
                }
                else if (pilihan_user == 7)
                {
                    FizzBuzz m_FizzBuzz = new FizzBuzz();
                    m_FizzBuzz.FBRun();
                }
                else if (pilihan_user == 8)
                {
                    GameBattle m_GameBattle = new GameBattle();
                    m_GameBattle.GbRun();
                }
                else if (pilihan_user == 9)
                {
                    PetCharacter m_PetCharacter = new PetCharacter();
                    m_PetCharacter.PetRun();
                }
                else if (pilihan_user == 10)
                {
                    Palindrome m_Palindrome = new Palindrome();
                    m_Palindrome.PdRun();
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
