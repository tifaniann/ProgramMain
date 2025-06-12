using System.Security.Cryptography.X509Certificates;
using System.Globalization;


public class test()
{
    public int total;
    public void testRun()
    {
        int[] numbers = { 4, 8, 15, 16, 23, 42 };
        bool found = false;

        foreach (int n in numbers)
        {
            total += n;

            if (n == 42)
            {
                found = true;
            }

        }
        if (found)
        {
            Console.WriteLine("set contains 42");
        }
        Console.WriteLine($"Total {total}");

        // =========================//
        int employeeLevel;
        string empName;
        string title = "";

        Console.Write("What's your employee level: ");
        employeeLevel = int.Parse(Console.ReadLine());

        Console.Write("What's your name: ");
        empName = Console.ReadLine().ToUpper();

        switch (employeeLevel)
        {
            case 100:
                title = "Junior Associate";
                break;
            case 200:
                title = "Senior Associate";
                break;
            case 300:
                title = "Manager";
                break;
            case 400:
                title = "Senior Manager";
                break;
            default:
                title = "Associate";
                break;
        }

        Console.WriteLine($"Employee Information");
        Console.WriteLine("-----------------------");
        Console.WriteLine($"{"Name".PadRight(20)}Title");
        Console.WriteLine($"{empName.PadRight(20)}{title}");


        // ==================================================//
        // SKU = Stock Keeping Unit. 
        // SKU value format: <product #>-<2-letter color code>-<size code>
        string sku = "";


        Console.Write("Input SKU (format 01-MN-L): ");
        sku = Console.ReadLine().ToUpper();
        string[] product = sku.Split('-');
        string type = "";
        string color = "";
        string size = "";

        if (product.Length != 3)
        {
            Console.WriteLine("Format SKU tidak valid. Gunakan format seperti 01-MN-L.");
            return;
        }

        switch (product[0])
        {
            case "01":
                type = "Sweat Shirt";
                break;
            case "02":
                type = "T-Shirt";
                break;
            case "03":
                type = "Sweat Pants";
                break;
            default:
                type = "Other";
                break;
        }

        switch (product[1])
        {
            case "MN":
                color = "Maroon";
                break;
            case "BL":
                color = "Black";
                break;
            case "WT":
                color = "White";
                break;
            default:
                color = "Other";
                break;
        }

        switch (product[2])
        {
            case "S":
                size = "Small";
                break;
            case "M":
                size = "Medium";
                break;
            case "L":
                size = "Large";
                break;
            default:
                size = "One Size Fits All";
                break;
        }

        Console.WriteLine("--- Product Information ---");
        Console.WriteLine("----------------------------");
        Console.WriteLine($"{"Size".PadRight(20)}{"Color".PadRight(20)}Type");
        Console.WriteLine($"{size.PadRight(20)}{color.PadRight(20)}{type}");


        //================================================//
        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine(i);
        }

    }
}