public class faktor()
{
    public void faktorRun()
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