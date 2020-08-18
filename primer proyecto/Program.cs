using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primer_proyecto
{
    class Program
    {
        static void Main(string[] args)
        {
            int miliseg = DateTime.Now.Millisecond; int dado = miliseg % 99 + 1;
            Console.WriteLine("El numero del dado es {0}", dado);
            Console.ReadKey();

        }
    }
}
