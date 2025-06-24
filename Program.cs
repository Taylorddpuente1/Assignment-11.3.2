//return the majority elemnt 
using System;


public class Program
{
    public static void Main()
    {
        int[] nums = { 2, 2, 1, 1, 1, 2, 2 };
        int result = MajorityElement(nums);

        Console.WriteLine(result);
    }

    public static int MajorityElement(int[] nums)
    {
        int count = 0;
        int candidate = 0;

        foreach (int num in nums)
        {
            if (count == 0)
            {
                candidate = num;
            }

            if (num == candidate)
            {
                count++;
            }
            else
            {
                count--;
            }
        }

        return candidate;
    }
}