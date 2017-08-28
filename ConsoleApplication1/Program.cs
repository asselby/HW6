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
            ArrayIndexer array = new ArrayIndexer();
            array[2] = 10;
            Console.WriteLine("array[2]-{0}", array[2]);
            Console.ReadLine();
        }
    }
}
