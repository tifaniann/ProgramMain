using System;

public class twoNumbs
{
    public int[] list_nums = new int[] { 2, 7, 11, 15 };
    public int target = 9;
    public bool found = false;
    int[] result = new int[2];
    public void twoNumbsRun()
    {
        for (int i = 0; i < list_nums.Length; i++)
        {
            for (int j = i + 1; j < list_nums.Length; j++)
            {
                if (list_nums[i] + list_nums[j] == target)
                {
                    result[0] = i;
                    result[1] = j;
                    found = true;

                }
            }
        }
        if (!found)
        {
            Console.WriteLine("No two numbers found that add up to the target.");
            return;
        }
        else
        {
            Console.WriteLine($"Output: [{result[0]}, {result[1]}]");
        }
        
    }
}