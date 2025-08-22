using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp44
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 18;
            if (a < 0)
            {
                WriteLine($"O numero  {a} é negativo!");
            }
            else if (a > 0 && a < 10)
            {
                WriteLine($"O numero {a} esta entre o - 10!");
            }

            else
            {
                WriteLine($"O Numero {a} é maior que 10!");

                ReadKey();
            }
        }
    }
}