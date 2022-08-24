using System;

// Access Modifiers => Private, Proctected, Internal, Protected Internal, Public

namespace OOPsPractice
{
    public class Car
    {
        private string origin = "India";
        protected string break1 = "India";
        internal int gear = 334;
        protected internal string h = "smooth";
        public int company1 = 67;
        private static int counter;

        private Car()
        {
            counter = 10;
        }

        public Car(int counter)
        {
            Car.counter += counter;
        }

        //public decimal speed = 90;
        public decimal CalculateAvg(int s1, int s2)
        {
            return (s1 + s2)/2 ;
        } 

    }
    public class LuxuryCar : Car
    {
        int luxuryCarCounter;
        public LuxuryCar(int counter):base(counter)
        {
            luxuryCarCounter = counter;
        }
        public decimal CalculateAvg(decimal s1, int s2) // method overloading
        {
            return (s1 + s2) / 2;
        }
    }
    class BaseClass
    {
        public virtual void Method1()
        {
            Console.WriteLine("Base - Method1");
        }
        public void Method2()
        {
            Console.WriteLine("Base - Method2");
        }
    }

    class DerivedClass : BaseClass
    {
        public override void Method1()
        {
            Console.WriteLine("Base - Method1");
        }
        public new void Method2()
        {
            Console.WriteLine("Derived - Method2");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass bc = new BaseClass();
            DerivedClass dc = new DerivedClass();
            BaseClass bcdc = new DerivedClass();

            bc.Method1();       // Base - Method1
            dc.Method1();       // Base - Method1
            dc.Method2();       // Derived - Method2
            bcdc.Method1();     // Base - Method1

            bc.Method2();       // Base - Method2 
            bcdc.Method2();     // Base - Method2 

        }
    }
}
