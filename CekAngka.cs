using System;

public class cekAngka
{
    public int nilai;
    public bool prima = true;
    public void IsPrime()
    {


        if (nilai <= 1)
        {
            Console.WriteLine($" {nilai} bukan bilangan prima");
            return;
        }
    }
}