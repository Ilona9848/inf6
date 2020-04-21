using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace inf6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 5, 4, 8, 2 };
            Stack<int> st = new Stack<int>();
            foreach (var el in a)
                st.Push(el);
            for (; st.Count() > 0;)
                Console.Write(st.Pop());
        }
    }
}
