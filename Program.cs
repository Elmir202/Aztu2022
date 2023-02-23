using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {

            int n1 = 0;
            int n2 = 1;
            int n3 ;
            int number=9;
            for(int i=n2;i<number;++i)
            {
                n3 = n1 + n2;
                n1 = n2;
                n2 = n3;
                if (n3 < number)
                {
                    Console.WriteLine(n3);
                }
            }
            

        }
    }
}
