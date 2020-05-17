using System.Text;

namespace LinkedList
{
    public class MyLinkedList
    {
        private class Node
        {
            private int value;
            private Node next;

            public Node(int value)
            {
                this.Value = value;
            }

            public Node Next { get => next; set => next = value; }
            public int Value { get => value; set => this.value = value; }
        }

        private Node first;
        private Node last;
        private int size;

        //addFirst

        public void addFirst(int item)
        {
            var node = new Node(item);
            if (first == null)
            {
                first = last = node;
            }
            else
            {
                node.Next = first;
                first = node;
            }
            size++;
        }

        //addLast
        public void addLast(int item)
        {
            var node = new Node(item);

            if (first == null)
            {
                first = last = node;
            }
            else
            {
                last.Next = node;
                last = node;
            }
            size++;
        }


        //deleteFirst
        public void DeleteFirst()
        {
            if (first == null)
                throw new System.Exception("Cannot delete first item as the List is empty.");

            if (first == last)
                first = last = null;
            else
            {

                //My solution
                var deleteRow = first;
                first = first.Next;
                deleteRow.Next = null;

                ////Mosh solution
                //var second = first.Next;
                //first.Next = null;
                //first = second;
            }
            size--;
        }

        private bool isEmpty()
        {
            return first == null;
        }

        //deleteLast

        public void DeleteLast()
        {
            if(isEmpty())
                throw new System.Exception("Cannot delete last item as the List is empty.");

            if (first == last)
                first = last = null;
            else
            {
                var previousNode = getPreviousNode(last);
                last = previousNode;
                last.Next = null;
            }
            size--;
        }

        private Node getPreviousNode(Node node)
        {
            var current = first;
            while (current != null)
            {
                if (current.Next == last) return current;

                current = current.Next;
            }
            return null;
        }


        //contains

        public bool contains(int item)
        {
            return (indexOf(item) >= 0);
        }

        //indexOf

        public int indexOf(int item) 
        {
            int index = 0;
            var current = first;
            while (current != null)
            {
                if (current.Value == item) return index;
                current = current.Next;
                index++;
            }
            return -1;
        }

        public int getSize()
        {
            return size;
        }

        public int[] toArray(MyLinkedList list)
        {
            int[] array = new int[size];
            int index = 0;
            var current = first;
            while (current != null)
            {
                array[index] = current.Value;
                current = current.Next;
                index++;
            }
            return array;
        }

        public StringBuilder printArray(int[] array)
        {
            StringBuilder str = new StringBuilder();

            if (array.Length == 0) return str.Append("Array empty");
         
            for (int i = 0; i < array.Length; i++)
            {
                str.Append(array[i]);
                str.Append(" ");
            }

            return str;
        }


        public void Reverse(MyLinkedList List)
        {
            if (isEmpty()) return;

            var previous = first;
            var current = first.Next;
            while (current != null)
            {
                var next = current.Next;
                current.Next = previous;
                previous = current;
                current = next;
            }

            last = first;
            last.Next = null;
            first = previous;
        }

        public StringBuilder printLinkedList(MyLinkedList list)
        {
            var current = first;
            StringBuilder str = new StringBuilder();
            while (current != null)
            {
                str.Append(current.Value.ToString());
                str.Append(' ');
             
                current = current.Next;
            }
            return str;
        }

        public int getKthFromTheEnd(int k)
        {
            var a = first;
            var b = first;
            for (var i = 0; i < (k - 1); i++)
            {
                b = b.Next;
                if (b == null)
                {
                    throw new System.Exception("Illegal value exception");
                }
            }
            while (b != last)
            {
                a = a.Next;
                b = b.Next;
            }
            return a.Value;
        }

        public string printMiddle(MyLinkedList list)
        {
            var a = first;
            var b = first;

            while (b != last && b.Next != last)
            {
                b = b.Next.Next;
                a = a.Next;
            }

            if (b == last)
                return "'" + a.Value + "'";
            else
                return a.Value + " " + a.Next.Value;
            
        }

        public bool hasLoop()
        {
            var slow = first;
            var fast = first;

            while (fast != null && fast.Next != null)
            {
                slow = slow.Next;
                fast = fast.Next.Next;

                if (slow == fast)
                    return true;
            }
            return false;
        }

        public MyLinkedList CreateListWithLoop()
        {
            var list = new MyLinkedList();
            list.addLast(10);
            list.addLast(20);
            list.addLast(30);
            list.addLast(40);

            var node = list.last;

            list.addLast(50);
            list.addLast(60);

            list.last.Next = node;
            return list;

        }



    }
}