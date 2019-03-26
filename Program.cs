using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Man man = new Man
            {
                IsHandsome = true
            };
            man.PropertyChanged += (sender, element) => Console.WriteLine($"{sender} has been changed property of class {element}");
            man.IsHandsome = false;
            Console.ReadLine();
        }
    }
}
