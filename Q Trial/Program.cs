using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_Trial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I am Showing you outside");
            gettingTheQ();
            Console.ReadKey();
        }


        private static void gettingTheQ()
        {
            Queue qt = new Queue();
            qt.Enqueue(1);
            qt.Enqueue(2);
            qt.Enqueue(3);
            qt.Enqueue(4);
            qt.Enqueue(5);
            qt.Enqueue(6);
            qt.Enqueue(7);
            qt.Enqueue(8);
            qt.Enqueue(9);

            foreach(Object obj in qt)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("Removing the Elements");

            while(qt.Count>0)
            {
                Console.WriteLine("Position "+qt.Count+qt.Peek());
                qt.Dequeue();
            }
            Console.WriteLine("Queue is now empty");
            Console.ReadKey();

        }

    }
}
