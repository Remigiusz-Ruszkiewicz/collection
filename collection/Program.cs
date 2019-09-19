using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collection
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] names = { {"Rafał", "Anna","kasia" },{ "Rafał", "Anna","joanna" } };
            //for (int i = 0; i < names.Length; i++)
            //{
            //    for (int y = 0; y < names[i].Length; y++)
            //    {
            //        Console.WriteLine(names[i,y]);
            //    }
            //}
            for (int i = 0; i < names.GetLength(0); i++)
            {
                for (int y = 0; y < 3; y++)
                {
                    Console.Write(names[i,y]);
                }
            }
            Console.Read();
        }
    }
}
