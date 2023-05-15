using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(300, 300);
            Console.Title = "Moja 1 apka";
            Console.BackgroundColor= ConsoleColor.Green;
            Console.ForegroundColor= ConsoleColor.Blue; 
            Console.WriteLine("Klasa 2 P");
            Console.WriteLine("Mechaniak");
            Console.WriteLine(Console.CapsLock);
            Console.Beep();
            Console.Clear();
            Console.ReadKey();
            
        }
    }
}
