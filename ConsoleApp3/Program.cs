using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //static bool ()
            
            int num = 7;
           
               
            for (int i = 2; i<= num; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine("not prime");
                }
                else { Console.WriteLine("is prime"); }
                     
            }
            





        }
    }
}
