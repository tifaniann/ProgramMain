using System.Text.RegularExpressions;
public class Palindrome
{
    public static string StringReverse(string originalStr)
    {
        char[] txt_1 = originalStr.ToCharArray();
        Array.Reverse(txt_1);
        return new string(txt_1);
    }

    public void PdRun()
    {
        bool valid = false;
        string input = "";
        string reserveWord = "";

        Console.Write("Masukkan kata yang akan dicek: ");
        input = Console.ReadLine().Trim().ToLower();

        string cleanedInput = Regex.Replace(input, "[^a-z0-9]", "");

        reserveWord = StringReverse(cleanedInput);

        if (cleanedInput == reserveWord)
        {
            valid = true;
        }
        else
        {
            valid = false;
        }
        Console.WriteLine(valid);

    }
}
