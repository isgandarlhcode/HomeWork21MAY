using System;

namespace HomeTask_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Salam . Men HomeTask 2 . by H.I");
            Console.WriteLine("Ededi ortalamasini almaq istediyiniz araliqdaki baslangic ededi daxil edin : ");
            int first = int.Parse(Console.ReadLine());
            Console.WriteLine("Ededi ortalamasini almaq istediyiniz araliqdaki son ededi daxil edin : ");
            int last = int.Parse(Console.ReadLine());

            int sum = 0;
            int count = 0;
            float avg = 0;

            for (int i = first; i < last; i++)
            {
                sum = sum + i;
                count++;

            }

            avg = sum / count;
            Console.WriteLine("Alinan ededi orta : " + avg);
        }
    }
}
