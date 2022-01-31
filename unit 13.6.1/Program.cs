using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.IO;

// Наша задача — сравнить производительность вставки в List<T> и LinkedList<T>.
// Для этого используйте уже знакомый вам StopWatch.
// На примере этого текста, выясните, какие будут различия между этими коллекциями.

namespace unit_13._6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\CSharp\unit13.6.1\Text1.txt";
            MethodA(path); // List<T>
            MethodB(path); // LinkedList<T>
        }

        public static void MethodA(string path)
        {
            var timer = new Stopwatch();

            timer.Start();

            string[] readText = File.ReadAllLines(path);

            //Console.WriteLine(readText[3]); // проверка

            var list = new List<string>();

            var sumMilliseconds = 0;
            foreach (var i in readText)
            {
                list.Add(i);
                timer.Stop();
                sumMilliseconds += (int)timer.ElapsedMilliseconds;
            }

            Console.WriteLine($"Производительность вставки в List<T>: {sumMilliseconds}");
        }

        public static void MethodB(string path)
        {
            var timer = new Stopwatch();

            timer.Start();

            string[] readText = File.ReadAllLines(path);

            //Console.WriteLine(readText[3]); // проверка

            var list = new List<string>();

            var linkedLisr = new LinkedList<string>();

            var sumMilliseconds = 0;
            foreach (var i in readText)
            {
                linkedLisr.AddLast(i);
                timer.Stop();
                sumMilliseconds += (int)timer.ElapsedMilliseconds;
            }

            Console.WriteLine($"Производительность вставки в LinkedList<T>: {sumMilliseconds}");
        }
    }
}



