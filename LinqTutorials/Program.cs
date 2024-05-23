using System;
using System.Linq;

namespace LinqTutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task1");
            LinqTasks.Task1().ToList().ForEach(i => Console.Write(i + " "));
            Console.WriteLine("");

            Console.WriteLine("Task2");
            LinqTasks.Task2().ToList().ForEach(i => Console.Write(i + " "));
            Console.WriteLine("");
            
            Console.WriteLine("Task3");
            Console.Write(LinqTasks.Task3());
            Console.WriteLine("");

            Console.WriteLine("Task4");
            LinqTasks.Task4().ToList().ForEach(i => Console.Write(i + " "));
            Console.WriteLine("");
            
            Console.WriteLine("Task5");
            LinqTasks.Task5().ToList().ForEach(i => Console.Write(i + " "));
            Console.WriteLine("");
            
            Console.WriteLine("Task6");
            LinqTasks.Task6().ToList().ForEach(i => Console.Write(i + " "));
            Console.WriteLine("");
            
            Console.WriteLine("Task7");
            LinqTasks.Task7().ToList().ForEach(i => Console.Write(i + " "));
            Console.WriteLine("");
            
            Console.WriteLine("Task8 " + LinqTasks.Task8());
            Console.WriteLine("");
            
            Console.WriteLine("Task9 " + LinqTasks.Task9());
            Console.WriteLine("");
            
            Console.WriteLine("Task10");
            LinqTasks.Task10().ToList().ForEach(i => Console.Write(i + " "));
            Console.WriteLine("");
            
            Console.WriteLine("Task11");
            LinqTasks.Task11().ToList().ForEach(i => Console.Write(i + " "));
            Console.WriteLine("");
            
            Console.WriteLine("Task12");
            LinqTasks.Task12().ToList().ForEach(i => Console.Write(i + " "));
            Console.WriteLine("");
            
            int[] input = { 1,1,1,1,1,1,10,1,1,1,1 };
            Console.WriteLine("Task13 " + LinqTasks.Task13(input));
            Console.WriteLine("");
            
            Console.WriteLine("Task14");
            LinqTasks.Task14().ToList().ForEach(i => Console.Write(i + " "));
            Console.WriteLine("");
            
            Console.WriteLine("Task15");
            LinqTasks.Task15().ToList().ForEach(i => Console.Write(i + " "));
            Console.WriteLine("");
            
            Console.WriteLine("Task16");
            LinqTasks.Task16().ToList().ForEach(i => Console.Write(i + " "));
            Console.WriteLine("");
        }
    }
}
