public class Gajikry()
{
    public void GajiRun()
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
}