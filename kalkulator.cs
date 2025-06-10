using System;

public class calcu()
{
    public void calcuRun()
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
}