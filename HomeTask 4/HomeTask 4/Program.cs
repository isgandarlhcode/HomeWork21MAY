using System;

namespace HomeTask_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("                       by I.H                                   ");
            Console.WriteLine("Bu proqram 2 eded arasindaki tek ededlerin cemini hesablayir .. ");

            Console.Write("Baslangic ededi daxil edin : ");
            int first = int.Parse(Console.ReadLine());
            Console.Write("Son ededi daxil edin : ");
            int last = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = first; i < last; i++)
            {
                if (i % 2 != 0)
                {
                    sum = sum + i;

                }

            }

            Console.WriteLine("Tek ededlerin cemi : " + sum);
        }
    }
}
