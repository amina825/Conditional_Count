using System;
using System.Diagnostics.Metrics;

namespace program
{
    class Program
    {
        static void Main(string[] args)
        {
            int count; int i = 0; int measurement;
            do
            {
                if (!( int.TryParse(Console.ReadLine(),out count)&& count <= 100 && count >= 1))
                {
                    Console.WriteLine();   
                }
            } while (count > 100 || count < 1);
            
            int number = 0;
            for (i = 0; i < count;)
            {
                
                if (!(int.TryParse(Console.ReadLine(), out measurement) && measurement <= 1000 && measurement >= 0))
                {
                    Console.WriteLine();
                }
                else if (measurement <= 1000 && measurement >= 0)
                {
                    i++;

                    if (measurement <= 1000 && measurement > 0)
                    {
                        number++;
                    }
                    
                }
                
            }
            Console.WriteLine(number);
        }
    }
}