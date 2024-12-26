using System;

class Program
{
    static void Main (string[] args)
    {
        Console.WriteLine("Square Root Program");
        if (args.Length > 0)
        {
            try{
                int myx = int.Parse(args[0]);
                Solution s = new();
                Console.WriteLine(s.MySqrt(myx));
            }
            catch{
                //throw new Exception ($"{args[0]} Not a number");
                Console.WriteLine("Sorry, that is not a valid entry");
            }
        }
    }
}

public class Solution {
    public int MySqrt(int x) {
        int val = 0;
        int sub = 1;

        if (x < 0)
        { throw new ArgumentException ($"{x} is a negative number"); }

        while (x >= sub)
        {
            x -= sub;
            sub += 2;
            val ++;
        }

        return val;
    }
}