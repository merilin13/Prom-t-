﻿namespace püramid_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sisesta püramiidi suurus");
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            int Space, Number;
            
            for (int i = 1; i <= n; i++)  
            {
                for (Space = 1; Space <= (n - i); Space++)  
                    Console.Write(" ");
                for (Number = 1; Number <= i; Number++)  
                    Console.Write(Number);
                for (Number = (i - 1); Number >= 1; Number--)  
                    Console.Write(Number);
                Console.WriteLine();
            }
        }

    }
}
