using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace P15
{
    class Program
    {
        static Random rnd = new Random();
        static void Print(object i)
        {

            Console.WriteLine(i.ToString());
            Thread.Sleep(rnd.Next(1000,3000));
            Console.WriteLine($"Task №{Task.CurrentId} закончил работу");
        }
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Task.Factory.StartNew(Print, "Привет");
            }

            Console.ReadLine();
        }
    }
}
