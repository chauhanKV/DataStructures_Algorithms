using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree();
            tree.insert(7);
            tree.insert(4);
            tree.insert(9);
            tree.insert(1);
            tree.insert(6);
            tree.insert(8);
            tree.insert(10);

            Console.WriteLine("Is value 1 present ? :" + tree.find(1));
            Console.WriteLine("Is value 0 present ? :" + tree.find(0));
            Console.WriteLine("Is value 34 present ? :" + tree.find(34));
            Console.WriteLine("Is value 117 present ? :" + tree.find(117));
            Console.WriteLine("Is value 17 present ? :" + tree.find(17));

            //----------------Traversals--------------------//

            //Depth First -> Pre-order -> Root|Left|Right
            Console.WriteLine("Depth First -> Pre Order");
            tree.traversalPreOrder();

            //Depth First -> In-Order -> Left|Root|Right
            Console.WriteLine("Depth First -> In Order");
            tree.traversalInOrder();

            //Depth First -> Post-Order -> Left|Right|Root
            Console.WriteLine("Depth First -> Post Order");
            tree.traversalPostOrder();

            //Tree Height
            Console.WriteLine("Tree Height: " + tree.height());

            //Tree Min value of Binary Tree
            Console.WriteLine("Min value of Binary Tree: " + tree.minValueOfBinaryTree());

            //Tree Min value of Binary Search Tree
            Console.WriteLine("Min value of Binary Search Tree: " + tree.minValueofBinarySearchTree());

            //Check if Tree is equal other tree
            Tree tree2 = new Tree();
            tree2.insert(7);
            tree2.insert(4);
            tree2.insert(9);
            tree2.insert(1);
            tree2.insert(6);
            tree2.insert(8);
            tree2.insert(10);

            Console.WriteLine("Is Current tree equals other tree? "+ tree.equals(tree2));

            //tree.swapRoot();
            Console.WriteLine("Is this a binary search tree? " + tree.isBinarySearchTree());

            //Get nodes at distance K
            Console.WriteLine("Node value at distance :");
            tree.nodesAtDistance(1);

            Console.WriteLine("Traversal Level Order(Breadth First) :");
            tree.traversalLevelOrder();

            //Size of tree
            Console.WriteLine("Size of tree is : " + tree.size());

            //Count leaf nodes in tree
            Console.WriteLine("Count of leaf node in tree are : " + tree.countLeaves());

            //Max of Binary search tree
            Console.WriteLine("Get the max of Binary search tree : " + tree.maxOfBinarySearchTree());

            //Check if Binary tree contains given value
            Console.WriteLine("Check whether Binary Tree contains 10 : " + tree.contains(10));

            //Check if two values are sibling
            Console.WriteLine("Check to see if 2 values are sibling : " + tree.areSibling(4,9));

            //Get List of Ancestors of value passed
            tree.getAncestors(1);

            Console.ReadLine();
        }
    }
}
