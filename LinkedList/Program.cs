using System;
using System.Diagnostics;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            //засекаем время начала операции
            stopwatch.Start();
            // Объявляем лист
            var list = new Model.LinkedList<int>();
            list.Add(1);
            list.Add(2);    
            list.Add(3);
            list.Add(4);
            list.Add(5);

            foreach(var item in list)
            {
                Console.Write(item + " ");
            }

            list.AddInPosition(7,3);

            Console.WriteLine();

            foreach (var item in list)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();

            Console.Write(list.SearchData(4));

            Console.WriteLine();

            list.DeleteBack();

            foreach (var item in list)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();

            list.ToString();

            Console.WriteLine();

            stopwatch.Stop();

            Console.WriteLine(stopwatch.ElapsedMilliseconds + " миллисекунд");

            Console.ReadLine();

        }
    }
}
