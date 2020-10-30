using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @delegate
{
    class Program
    {
       
        public int Add(int a, int b)
        {
            Console.WriteLine(a * b);
            return a * b;
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            Func<int,int> f = p.Add;
            int res = f(4, 6);
            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}
