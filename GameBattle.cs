using System.Text.RegularExpressions;

public class GameBattle()
{
    public void GbRun()
    {
        int hero = 10;
        int monster = 10;

        Random dice = new Random();

        do
        {
            int roll = dice.Next(1, 11);
            monster -= roll;
            Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health");

            if (monster <= 0) continue;

            roll = dice.Next(1, 11);
            hero -= roll;
            Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health");

        } while (hero > 0 && monster > 0);

        Console.WriteLine(hero > monster ? "Hero Wins!" : "Monster Wins!");

        // =========================================================================//
        int? input = null;
        bool valid = false;

        do
        {
            try
            {
                Console.WriteLine("Enter an integer value between 5 and 10: ");
                input = int.Parse(Console.ReadLine());
                if (input >= 5 && input <= 10)
                {
                    valid = true;
                    Console.WriteLine($"Your input value ({input}) has been accepted.");
                }
                else
                {
                    Console.WriteLine($"Your entered ({input}) please enter a number between 5 and 10.");
                }

            }
            catch
            {
                Console.WriteLine("Sorry, you entered an invalid number, please try again.");
            }

        } while (!valid);

        // =============================================================//
        string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad. I like you", "I like all three of the menu choices" };

        // string[] menu = myStrings[0].Split(". "); // kalo split cuma 1 karakter pake ('') kalo > 1 pake ("")

        string[] menu = Regex.Split(myStrings[0], @"\.\s");
        // Regex (singkatan dari Regular Expression) adalah pola (pattern) 
        // yang digunakan untuk mencari, mencocokkan, memvalidasi, atau memanipulasi teks

        foreach (string n in menu)
        {
            Console.WriteLine(n.Trim());
        }
        Console.WriteLine(myStrings[1]);

        //==============================================================//

        string? role = null;
        bool vld = false;

        do
        {
            try
            {
                Console.WriteLine("Enter your role name (Administrator, Manager, or User): ");
                role = Console.ReadLine().ToUpper();
                if (role == "ADMINISTRATOR" || role == "MANAGER" || role == "USER")
                {
                    vld = true;
                    Console.WriteLine($"Your input value ({role}) has been accepted.");
                }
                else
                {
                    Console.WriteLine($"The role name that you entered, \"{role}\" is not valid. Enter your role name (Administrator, Manager, or User).");
                }

            }
            catch
            {
                Console.WriteLine("Sorry, please try again.");
            }

        } while (!vld);
        
    }
}