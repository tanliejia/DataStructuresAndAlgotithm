using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baiji
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 20; i++)
            {
                for (int j = 0; j <= 33; j++)
                {
                    if ((100 - i - j) % 3 == 0)
                    {
                        if (i * 5 + j * 3 + (100 - i - j) / 3 == 100)
                        {
                            Console.WriteLine("买了公鸡{0}只,母鸡{1}只,小鸡{2}只", i, j, 100 - i - j);
                        }
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
