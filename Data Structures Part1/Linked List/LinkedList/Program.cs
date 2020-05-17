using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {

            MyLinkedList list = new MyLinkedList();
            
            list.addLast(10);
            list.addLast(20);
            list.addLast(30);
            list.addLast(40);
            list.addLast(50);
            list.addLast(60);
            list.addLast(70);

            Console.WriteLine("Middle node is :" + list.printMiddle(list));

            Console.WriteLine("index is " + list.indexOf(40));
            Console.WriteLine("index is " + list.indexOf(300));
            Console.WriteLine("contains " + list.contains(300));


            Console.WriteLine(list.getSize());
            var arrays = list.toArray(list);
            Console.WriteLine("toArray :" + list.printArray(arrays));


            list.Reverse(list);
            Console.WriteLine("Reverse :" + list.printLinkedList(list));


            list.DeleteFirst();

            Console.WriteLine("Kth node from end " +list.getKthFromTheEnd(4));

            Console.WriteLine("Does old list has loop ? " + list.hasLoop());

            var newList = list.CreateListWithLoop();
            Console.WriteLine("Does new list has loop ? " + newList.hasLoop());


            //-----------------LinkedListQueue ---------------------------//

            LinkedListQueue lq = new LinkedListQueue();
            lq.enqueue(10);
            lq.enqueue(20);
            lq.enqueue(30);

            var removedItem = lq.dequeue();
            Console.WriteLine("Item removed from LinkedListQueue is :" + removedItem);

            Console.WriteLine("Item to peek from LinkedListQueue is :" + lq.peek());

            Console.WriteLine("Is LinkedListQueue empty?: " + lq.isEmpty());

            Console.ReadLine();
         

        }
    }
}
