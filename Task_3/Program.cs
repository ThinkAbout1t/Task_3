using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Flag = true;
            while (Flag == true)
            {
                try
                {
                    Console.OutputEncoding = System.Text.Encoding.UTF8;
                    Console.Write("введіть змінну типу int: ");
                    int a = Convert.ToInt32(Console.ReadLine());

                    Console.Write("введіть змінну типу double: ");
                    double b = Convert.ToDouble(Console.ReadLine());

                    Console.Write("введіть змінну типу long: ");
                    long c = Convert.ToInt64(Console.ReadLine());

                    Console.WriteLine($"a = {a}; b = {b}; c = {c}");
                    Console.ReadKey();
                }
                catch
                {
                    Flag = true;
                    Console.WriteLine("Enter correct value");
                }
            }
        }
    }
}
