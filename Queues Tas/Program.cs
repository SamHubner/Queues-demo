using System;

namespace Queues_Tas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Queue one = new Queue();

            one.add("one");
            one.add("two");
            one.add("three");
            one.add("four");
            one.add("five");
            one.add("six");
            one.add("seven");
            one.add("eight");

    

            one.pop();
            one.pop();
            one.add("three");
            one.add("four");



            one.Print();
        }
    }
}
