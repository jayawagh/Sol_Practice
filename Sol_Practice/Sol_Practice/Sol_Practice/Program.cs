using System;

namespace Sol_Practice
{
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("Hello World!");
    //    }
    //}
    public class ParentClass
    {
        public ParentClass()
        {
            Console.WriteLine("Hello from Parent Constructor.");
        }
        public ParentClass(string name)
        {
            Console.WriteLine("Jayashri FROM Parent Constructor.");
        }
        public void print()
        {
            Console.WriteLine("I'm a Parent Class.");
        }
    }
    public class ChildClass : ParentClass
    {
        public ChildClass() 
        {
            Console.WriteLine("Child Constructor..");
        }
        public static void Main()
        {
            ChildClass child = new ChildClass();
            child.print();

            int i = 1;
            
            for (i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                    Console.WriteLine(i + " fizz");
                if (i % 5 == 0)
                    Console.WriteLine(i + " buzz");
                if (i % 3 == 0 && i % 5 == 0)
                    Console.WriteLine(i + " fizz buzz");
            }
        }
    }
}
