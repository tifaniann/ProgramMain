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
            9. Pet Characteristics  10. Palindrome
            11. Test                12. Pet Character
            13. Student Data        14. Two Numbs
            15. Reserve Words");

            int pilihan_user;
            try
                {
                    Console.Write("Pilihan: ");
                    pilihan_user = int.Parse(Console.ReadLine());

                    switch (pilihan_user)
                    {
                        case 1:
                            cekAngka m_cekAngka = new cekAngka();
                            m_cekAngka.AngkaRun();
                            break;
                        case 2:
                            Gajikry m_gaji = new Gajikry();
                            m_gaji.GajiRun();
                            break;
                        case 3:
                            calcu m_calcu = new calcu();
                            m_calcu.calcuRun();
                            break;
                        case 4:
                            faktor m_faktor = new faktor();
                            m_faktor.faktorRun();
                            break;
                        case 5:
                            Grades m_grade = new Grades();
                            m_grade.gradeRun();
                            break;
                        case 6:
                            test m_test = new test();
                            m_test.testRun();
                            break;
                        case 7:
                            FizzBuzz m_FizzBuzz = new FizzBuzz();
                            m_FizzBuzz.FBRun();
                            break;
                        case 8:
                            GameBattle m_GameBattle = new GameBattle();
                            m_GameBattle.GbRun();
                            break;
                        case 9:
                            PetCharacter m_PetCharacter = new PetCharacter();
                            m_PetCharacter.PetRun();
                            break;
                        case 10:
                            Palindrome m_Palindrome = new Palindrome();
                            m_Palindrome.PdRun();
                            break;
                        case 11:
                            Testing m_Testing = new Testing();
                            m_Testing.RkRun();
                            break;
                        case 13:
                            Student m_Student = new Student();
                            m_Student.studentRun();
                            break;
                        case 14:
                            twoNumbs m_tn = new twoNumbs();
                            m_tn.twoNumbsRun();
                            break;
                        case 15:
                            Reserve m_resv = new Reserve();
                            m_resv.reserveRun();
                            break;
                        default:
                            Console.WriteLine("Pilihan tidak tersedia");
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Pilihan tidak tersedia");
                    throw;
                }

            // int.Parse(Console.ReadLine());

            Console.WriteLine("terima kasih");
            Console.ReadLine(); // agar terminal tidak langsung close
        }

    }

}
