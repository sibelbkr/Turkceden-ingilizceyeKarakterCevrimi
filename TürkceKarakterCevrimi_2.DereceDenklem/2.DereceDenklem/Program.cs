using System;

namespace _2.DereceDenklem
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            double delta;
            double x1, x2;
            double cyedek;

            Console.WriteLine("ax2+bx+c türündeki 2.dereceden denklemin a,b,c değerlerini giriniz");

            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("a=" + (double)a);
            Console.WriteLine("b=" + (double)b);
            Console.WriteLine("c=" + (double)c);


            delta = (Math.Pow((double)b, (double)2)) - (4 * a * c);

            Console.WriteLine("delta=" + delta);


            if (delta < 0)
            {
                Console.WriteLine("DENKLEMİN REEL KÖKÜ YOKTUR");
            }
            else if (delta == 0)
            {
                cyedek = Math.Abs(c);
                x1 = Math.Sqrt(cyedek);
                Console.WriteLine("DENKLEMİN KÖKLERİ X1,X2 SIRASIYLA=" + x1 + "," + x1);
            }
            else
            {
                x1 = ((+b) + (Math.Sqrt((double)delta))) / (2 * a);
                x2 = ((-b) - (Math.Sqrt((double)delta))) / (2 * a);
                Console.WriteLine("DENKLEMİN KÖKLERİ X1,X2 SIRASIYLA=" + x1 + "," + x2);

            }



            Console.ReadKey();
        }
    }
}
