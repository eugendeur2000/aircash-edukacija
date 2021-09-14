using System;

namespace airCashEducation
{
    class Program
    {
        static void Main(string[] args)
        {
            int rb = 6;
            int b = 7;
            Console.WriteLine(rb);
            Console.WriteLine(b);
            Console.Write("unesite realni broj");
            int realniBroj = int.Parse(Console.ReadLine());

            switch(realniBroj)
            {
                case 1:
                    Console.WriteLine("zbrajanje");
                    break;
                case 2:
                    Console.WriteLine("oduzimanje");
                    break;
                case 3:
                    Console.WriteLine("množenje");
                    break;
                case 4:
                    Console.WriteLine("dijeljenje");
                    break;
            }
            Console.WriteLine("kraj programa");
        }
    }
}
