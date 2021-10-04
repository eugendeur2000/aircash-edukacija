using System;

namespace airCashEducation
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 4;
            int y = 5;
            //Console.WriteLine("x=");
            //Console.WriteLine("unesite y");
            Console.Write("unesite case");
            int operacije = int.Parse(Console.ReadLine());

            switch(operacije)
            {
                case 1:
                    var suma = x + y;
                    Console.WriteLine($"x+y={suma}");
                    Console.WriteLine("zbrajanje");
                    break;
                case 2:
                    var subtraction = x - y;
                    Console.WriteLine($"x-y={subtraction}");
                    Console.WriteLine("oduzimanje");
                    break;
                case 3:
                    var reproduction = x * y;
                    Console.WriteLine($"x*y={reproduction}");
                    Console.WriteLine("množenje");
                    break;
                case 4:
                    var division = x / y;
                    Console.WriteLine($"x/y={division}");
                    Console.WriteLine("dijeljenje");
                    break;
            }
            Console.WriteLine("kraj programa");
        }
    }
}
