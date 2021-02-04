using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class GenericList<T>
    {
        Stack<T> stack = new Stack<T>();
        public void Push(T input)
        {
            stack.Push(input);          
        }
        public T Peek()
        {
            var res =  stack.Peek();
            return res;
        }
        public int Count()
        {
            return stack.Count;
        }
        public void Pop()
        {
            stack.Pop();
        }
        public void Write()
        {
            var array = stack.ToArray();
            foreach (var item in array)
            {                
                Console.WriteLine(item);
            }
        }
    }
    class Program
    {
        private class ExampleClass
        {
            public string name { get; set; }
        }
        static void Main(string[] args)
        {
            GenericList<int> list1 = new GenericList<int>();
            list1.Push(1);
            list1.Push(2);
            Console.WriteLine("int");
            list1.Write();

            GenericList<string> list2 = new GenericList<string>();
            list2.Push("test");
            list2.Push("test2");
            Console.WriteLine("String");
            list2.Write();

            GenericList<ExampleClass> list3 = new GenericList<ExampleClass>();
            var obj = new ExampleClass();

            var name = "Artyr";
            obj.name = name;
            list3.Push(obj);
            var name2 = "Andrew";
            obj.name = name2;
            list3.Push(obj);
            Console.WriteLine("obj");
            list3.Write();

            Console.WriteLine("Poop list int");
            list1.Pop();

            Console.WriteLine("Poop result");
            list1.Write();

            Console.WriteLine($"Stack count  strings: {list2.Count() }");
            Console.WriteLine($"Pekk list strings: {list2.Peek()}");
            Console.WriteLine($"Peek test");
            list2.Write();

            Console.ReadLine();
        }
    }
}