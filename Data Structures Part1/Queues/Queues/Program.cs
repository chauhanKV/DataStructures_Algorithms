using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using java.util;

namespace Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayQueue obj = new ArrayQueue(5);
            obj.enqueue(10);
            obj.enqueue(20);
            obj.enqueue(30);

            var item = obj.dequeue();
            Console.WriteLine("Item removed was: " + item);
            Console.WriteLine(obj.ToString());

            obj.enqueue(40);
            obj.enqueue(50);

            var item1 = obj.dequeue();
            Console.WriteLine("Item removed was: " + item1);
            Console.WriteLine(obj.ToString());

            var item2 = obj.dequeue();
            Console.WriteLine("Item removed was: " + item2);
            Console.WriteLine(obj.ToString());

            obj.enqueue(60);
            obj.enqueue(70);
            obj.enqueue(80);

            //obj.enqueue(90);

            Console.WriteLine(obj.ToString());



            //------------------------------------//

            QueueUsingTwoStack queue = new QueueUsingTwoStack();
            queue.enqueue(200);
            queue.enqueue(300);
            queue.enqueue(400);

            var first = queue.dequeue();
            Console.WriteLine("Item first removed from QueueWithTwoStack is " + first);

            var second = queue.dequeue();
            Console.WriteLine("Item second removed from QueueWithTwoStack is " + second);

            var third = queue.dequeue();
            Console.WriteLine("Item third removed from QueueWithTwoStack is " + third);

            //var fourth = queue.dequeue();
            //Console.WriteLine("Item first removed from QueueWithTwoStack is " + fourth);


            //--------------------------------------/
            PriorityQueue pq = new PriorityQueue(6);
            pq.addItems(5);
            pq.addItems(3);
            pq.addItems(6);
            pq.addItems(8);
            pq.addItems(2);
            pq.addItems(4);

            var pq1 = pq.remove();
            Console.WriteLine("Item removed from PriorityQueue is : " + pq1.ToString());

            var pq2 = pq.remove();
            Console.WriteLine("Item removed from PriorityQueue is : " + pq2.ToString());

            Console.WriteLine("Values in PriorityQueue are : " + pq.ToString());


            //------------------------------------------//
            QueueReverser qr = new QueueReverser();
            qr.add(1);
            qr.add(2);
            qr.add(3);
            qr.add(4);
            qr.add(5);

            qr.ReverseTillK(3);

            Console.WriteLine(qr.ToString());

            Console.ReadLine();
        }
    }
}
