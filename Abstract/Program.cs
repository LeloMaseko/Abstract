using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Corsa car2 = new Corsa();
            Console.WriteLine(car2.wheels);
            Console.ReadLine();
        }
    }
    abstract class Vehicle
    {
        public int wheels = 4;
    }
    class Corsa : Vehicle
    {
        public int sparewheels = 1;
    }
}
