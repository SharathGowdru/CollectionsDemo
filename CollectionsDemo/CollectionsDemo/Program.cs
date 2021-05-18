﻿using System;
using System.Collections.Generic;

namespace CollectionsDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to C# Collections");
            //doSetDemo();
            //doListDemo();
            //doQueueDemo();
            //doDictionaryDemo();
            //doStackDemo();
            //doListDemo()
            Console.ReadKey();
        }
        public static void doSetDemo()
        {
            Console.WriteLine("\n In doSetDemo");
            var set = new HashSet<string>();
            set.Add("Ravi");
            set.Add("VIjay");
            set.Add("Ravi");
            set.Add("Ajay");
            HashSet<string>.Enumerator enumerator = set.GetEnumerator();
            while(enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }
        private static void doQueueDemo()
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Amit Sharma");
            queue.Enqueue("Vijay RAj");
            queue.Enqueue("Jaishankar");
            queue.Enqueue("Raj");
            Console.WriteLine("Head : " + queue.Peek());
            Console.WriteLine("\n Iterating the queue Elements: ");
            foreach (var element in queue)
            {
                Console.WriteLine(element);
            }
            string deque = queue.Dequeue();
            Console.WriteLine("Deque element : " + deque);
            Console.WriteLine("\n Iterating the queue elements after dequeue one element :");
            Queue<string>.Enumerator enumerator = queue.GetEnumerator();
            while(enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }
        private static void doDictionaryDemo()
        {
            Console.WriteLine("\nIn doStackDemo");
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(100, "Amit");
            dictionary.Add(101, "Rahul");
            dictionary.Add(102, "Vijay");
            Console.WriteLine("Access value using key(key=100) : " + dictionary[100]);
            Console.WriteLine("\nIterating Dictionary : ");
            foreach (var element in dictionary)
            {
                Console.WriteLine("key=" + element.Key + "& Value=" + element.Value);
            }
        }
        private static void doStackDemo()
        {
            Console.WriteLine("\n In doStackDemo");
            Stack<string> stack = new Stack<string>();
            stack.Push("Ayush");
            stack.Push("Garvit");
            stack.Push("Amit");
            stack.Push("Ashish");
            stack.Push("Garina");
            string pop = stack.Pop();
            foreach (var element in stack)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("poped element :" + pop);
        }
        private static void doListDemo()
        {
            Console.WriteLine("\nIn doListDemo");
            List<string> list = new List<string>();
            list.Add("Ravi");
            list.Add("Vijay");
            list.Add("Ravi");
            list.Add("Ajay");
            foreach(var element in list)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine(list[2]);
        }
    }
}
