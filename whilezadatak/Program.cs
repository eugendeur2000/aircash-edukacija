using System;

namespace whilezadatak
{
    class Program
    {

        static int faktorijal(int n)
        {
            int faktorijal = n;
            int i = n - 1;
            while (i > 0)
            {
                faktorijal = faktorijal * i;
                i = i - 1;
                
            } 
            
            return faktorijal;

        }

        static void Main(string[] args)

        {
            Console.Write("unesite n=");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}!={1}", n, faktorijal(n));
        }
    }
}
    
