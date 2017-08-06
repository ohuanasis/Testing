using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpSpeedCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> fruits = new List<string>();
            fruits.Add("Apple");
            fruits.Add("Banana");
            fruits.Add("Bilberry");
            fruits.Add("Blackberry");
            fruits.Add("Blackcurrant");
            fruits.Add("Blueberry");
            fruits.Add("Cherry");
            fruits.Add("Coconut");
            fruits.Add("Cranberry");
            fruits.Add("Date");
            fruits.Add("Fig");
            fruits.Add("Grape");
            fruits.Add("Guava");
            fruits.Add("Jack-fruit");
            fruits.Add("Kiwi fruit");
            fruits.Add("Lemon");
            fruits.Add("Lime");
            fruits.Add("Lychee");
            fruits.Add("Mango");
            fruits.Add("Melon");
            fruits.Add("Olive");
            fruits.Add("Orange");
            fruits.Add("Papaya");
            fruits.Add("Plum");
            fruits.Add("Pineapple");
            fruits.Add("Pomegranate");

            regular_foreach(fruits);

            parallel_foreach(fruits);

            Console.Read();

        }

        private static void regular_foreach(List<string> f1)
        {
            Console.WriteLine("Printing list using foreach loop\n");

            Stopwatch swClock1 = Stopwatch.StartNew();
            foreach (string fruit in f1)
            {
                Console.WriteLine("Fruit Name: {0}, Thread Id = {1}", fruit, Thread.CurrentThread.ManagedThreadId);
            }

            Console.WriteLine("foreach loop execution time = {0} seconds\n", swClock1.Elapsed.TotalSeconds);

        }

        private static void parallel_foreach(List<string> f2)
        {
            Console.WriteLine("Printing list using Parallel.ForEach");

            Stopwatch swClock2 = Stopwatch.StartNew();
            Parallel.ForEach(f2, fruit2 => {

                Console.WriteLine("Fruit Name: {0}, Thread Id= {1}", fruit2, Thread.CurrentThread.ManagedThreadId);
            });

            Console.WriteLine("Parallel.ForEach() execution time = {0} seconds", swClock2.Elapsed.TotalSeconds);

        }
    }
}
