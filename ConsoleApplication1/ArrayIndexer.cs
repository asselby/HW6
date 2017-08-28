using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class ArrayIndexer
    {
        int[] array = new int[100];
        public int this[int i]
        {
            get { return array[i]; }
            set { array[i] = value * value; }
        }

    }
}
