using System;
using OOPsPractice;

namespace DifferentAssembly
{
    public class SportsCar : Car  // derived from other assembly
    {
        private string origin = "India";
        protected string break2 = "India"; // break1 not accessible
        internal int gear = 334;
        protected internal string h1 = "smooth"; // h is not accessible
        public int company2 = 67; //  company1 is not accessible
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car c1 = new Car(); // public class is accessible in other assembly
            Console.WriteLine(c1.company1); // public variable is accessible in other assembly
        }
    }
}
