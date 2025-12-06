using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("argc = " + args.Length);

        for (int i = 0; i < args.Length; i++)
        {
            Console.WriteLine($"argv[{i}] = {args[i]}");
        }
    }
}
