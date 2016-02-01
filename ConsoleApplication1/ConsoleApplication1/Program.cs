using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Aircraft aircraft1 = new Aircraft(50, 1000);
           // aircraft1.Print();
            aircraft1.Remove(52);
            aircraft1.Print();
            Console.ReadLine();
        }
    }
}
