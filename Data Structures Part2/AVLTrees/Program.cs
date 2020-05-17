using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVLTrees
{
    class Program
    {
        static void Main(string[] args)
        {
            AVLTree avlTree = new AVLTree();

            //avlTree.insert(1);
            //avlTree.insert(5);
            //avlTree.insert(10);
            //avlTree.insert(2);
            //avlTree.insert(21);
            //avlTree.insert(6);

            //avlTree.insert(10);
            //avlTree.insert(20);
            //avlTree.insert(15);
            //avlTree.insert(30);

            avlTree.insert(7);
            avlTree.insert(4);
            avlTree.insert(9);
            avlTree.insert(1);
            avlTree.insert(6);
            avlTree.insert(8);
            avlTree.insert(10);

            //Check to see if Tree is balanced
            Console.WriteLine("Is AVLTree balanced? " + avlTree.isBalanced());

            //Size of AVL Tree
            Console.WriteLine("Size of the AVL Tree is : " + avlTree.size());

            //Is the tree Perfect?
            Console.WriteLine("Is the tree perfect? " + avlTree.isPerfect());

            Console.ReadLine();
        }
    }
}
