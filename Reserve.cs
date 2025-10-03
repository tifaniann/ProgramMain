using System;

public class Reserve
{
    public string words = "";
    // public string[] wordArray;
    public string reversedWords = "";
    public void reserveRun()
    {
        Console.Write("Masukkan kalimat: ");
        words = Console.ReadLine();
        string[] wordArray = words.Split(' ');

        // for (int i = wordArray.Length - 1; i >= 0; i--)
        // {
        //     reversedWords += wordArray[i] + " ";
        // }

        foreach (var w in wordArray)
        {
            reversedWords = "";
            for (int i = w.Length - 1; i >= 0; i--)
            {
                reversedWords += w[i];
            }
            // reversedWords += reversedWords + " ";
        }
        Console.WriteLine(reversedWords.Trim());

    }
}