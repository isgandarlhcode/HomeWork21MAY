using System;

namespace HomeTask_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("by H.I");

            bool tobecontinued = true;
            int ageLimit = 18;
            int pointLimit = 70;


            do
            {
                Console.Write("Salam eziz telebe . Xahis edirik qeydiyyat ucun yasinizi qeyd edin : ");
                int age = int.Parse(Console.ReadLine());
                if (age > ageLimit) 
                {
                    Console.WriteLine("Yasiniz bizim ucun yeterlidir . ");
                    Console.Write("Xahis edirik Ingilis dili TOEFL balinizi qeyd edin (1 - 100 ) : ");
                    int point = int.Parse(Console.ReadLine());
                    if (point > pointLimit)
                    {
                        Console.WriteLine("Sizin bizim kampusa olan qeydiyyatiniz muveffeqiyyetle tesdiq edilmisdir . ");
                    }
                    else
                    {
                        Console.WriteLine("Teesuffler olsun ki , sizin baliniz bizim kampus ucun yeterli deyil .");
                    }

                }
                else
                {
                    Console.WriteLine("Sizin yashiniz bizim kampus ucun yeterli deyil . Qeydiyyat 18 yasdan baslayir .");
                }

                Console.Write("Qeydiyyatdan kecmek isteyen basqa telebe varmi ? (beli / xeyir) :  ");
                string sual = Console.ReadLine();

                if ( sual == "beli")
                {
                    Console.WriteLine("Nobeti telebe qeydiyyati yuklenir ...");
                }
                else if (sual == "xeyir")
                {
                    tobecontinued = false;
                    Console.WriteLine("Tesekkurler :) .");
                }
                else
                {
                    Console.WriteLine("Proqrami yeniden basladib duzgun ifade islediniz .");
                    Console.WriteLine("Proqram basa qayidir ... ");

                }

            } while (tobecontinued);

        }
    }
}
