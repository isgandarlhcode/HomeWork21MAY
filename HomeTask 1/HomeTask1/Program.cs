using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Salam . Men HomeTask 1'em . by H.I");
            Console.WriteLine("Xahis edirik birinci ededi daxil edesiniz : ");
            int first = int.Parse(Console.ReadLine());
            Console.WriteLine("Ikinci ededi daxil edesiniz :");
            int last = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = first; i < last; i++)
            {
                sum = sum + i;
            }

            Console.WriteLine("Sizin daxil olunan 2 eded arasindaki ededlerin cemi : " + sum);
        }
    }
}
