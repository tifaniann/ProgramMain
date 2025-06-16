public class Testing
{
    public static int Rekursif(int baseNum, int exponent)
    {

        double hasil = Math.Pow(baseNum, exponent);
        return (int)hasil;
    }

    public void RkRun()
    {
        int angka = Rekursif(2, 3);
        Console.WriteLine(angka);

        List<String> input = new List<string>() { "hi", "hello", "world", "a", "yes" };
        var grouped = input.GroupBy(x => x.Length).OrderBy(x => x.Key);

        foreach (var txt in grouped)
        {
            Console.Write($"{txt.Key}: ");
            // Console.Write("[");
            foreach (var kata in txt)
            {
                Console.WriteLine($"[\"{kata}\"],  ");
            }
            

        }
        
    }
}