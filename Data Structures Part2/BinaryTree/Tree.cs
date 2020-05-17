using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Tree
    {
        private Node root;


        public void insert(int value)
        {
            var node = new Node(value);
            if (root == null)
            {
                root = node;
                return;
            }

            var current = root;
            while (true)
            {

                if (value > current.Value)
                {
                    if (current.RightChild == null)
                    {
                        current.RightChild = node;
                        break;
                    }
                    current = current.RightChild;
                }
                else
                {
                    if (current.LeftChild == null)
                    {
                        current.LeftChild = node;
                        break;
                    }
                    current = current.LeftChild;
                }

            }
        }

        public bool find(int value)
        {
            var current = root;

            while (current != null)
            {
                if (value > current.Value)
                    current = current.RightChild;
                else if (value < current.Value)
                    current = current.LeftChild;
                else
                    return true;
            }

            return false;


            //if (current.Value == value)
            //    return true;

            //while (true)
            //{
            //    if (value > current.Value)
            //    {
            //        if (value == current.Value)
            //            return true;

            //        if (current.RightChild == null)
            //            return false;

            //        current = current.RightChild;
            //    }
            //    else
            //    {
            //        if (value == current.Value)
            //            return true;

            //        if (current.LeftChild == null)
            //            return false;

            //        current = current.LeftChild;
            //    }
            //}

            // false;
        }


        public void traversalPreOrder()
        {
            traversalPreOrder(root);
        }

        private void traversalPreOrder(Node root)
        {
            if (root == null)
                return;

            Console.WriteLine(root.Value);
            traversalPreOrder(root.LeftChild);
            traversalPreOrder(root.RightChild);
        }

        public void traversalInOrder()
        {
            traversalInOrder(root);
        }

        private void traversalInOrder(Node root)
        {
            if (root == null)
                return;

            traversalInOrder(root.LeftChild);
            Console.WriteLine(root.Value);
            traversalInOrder(root.RightChild);
        }

        public void traversalPostOrder()
        {
            traversalPostOrder(root);
        }

        private void traversalPostOrder(Node root)
        {
            if (root == null)
                return;

            traversalPostOrder(root.LeftChild);
            traversalPostOrder(root.RightChild);
            Console.WriteLine(root.Value);
        }


        public int height()
        {
           return height(root);
        }

        private int height(Node root)
        {
            if (root == null)
                return -1;

            if (isLeaf(root))
                return 0;

            return (1 + Math.Max(height(root.LeftChild), height(root.RightChild)));
        }

        private bool isLeaf(Node root)
        {
            return root.LeftChild == null && root.RightChild == null;
        }

        public int minValueOfBinaryTree()
        {
            return minValueOfBinaryTree(root);
        }

        //O(n) -> Because we have to visit all the nodes in the tree
        private int minValueOfBinaryTree(Node root)
        {
            if (root == null)
                throw new Exception("Tree is empty");

            if (isLeaf(root))
                return root.Value;

            var left = minValueOfBinaryTree(root.LeftChild);
            var right = minValueOfBinaryTree(root.RightChild);

            return Math.Min(Math.Min(left,right), root.Value);
        }

        //o(log n) -> Because we are narrowing down to subtrees in each recusrion
        public int minValueofBinarySearchTree()
        {
            if (root == null)
                throw new Exception("Tree is empty");

            var current = root;
            var last = root;
            while (current != null)
            {
                last = current;
                current = current.LeftChild;
            }

            return last.Value;
        }

        public bool equals(Tree other)
        {
            if (other == null)
                return false;

            return ifEquals(root, other.root);
        }
        
        // Pre-order traversal -> first we visit root and then left and right nodes.
        private bool ifEquals(Node first, Node second)
        {
            if (first == null && second == null)
                return true;

            if (first != null && second != null)
                return first.Value == second.Value //root
                       && ifEquals(first.LeftChild, second.LeftChild) //left
                       && ifEquals(first.RightChild, second.RightChild); //right

            return false;  
        }

        public bool isBinarySearchTree()
        {
            return isBinarySearchTree(root, int.MinValue, int.MaxValue);
        }

        private bool isBinarySearchTree(Node root, int min, int max)
        {
            if (root == null)
                return true;

            if (root.Value < min || root.Value > max)
                return false;

            return isBinarySearchTree(root.LeftChild, min, root.Value - 1)
                && isBinarySearchTree(root.RightChild, root.Value + 1, max);
        }

        public void swapRoot()
        {
            var temp = root.LeftChild;
            root.LeftChild = root.RightChild;
            root.RightChild = temp;
        }


        public void nodesAtDistance(int distance)
        {
            nodesAtDistance(root, distance);
        }

        private void nodesAtDistance(Node root, int distance)
        {

            if (root == null)
                throw new Exception("Tree is empty");

            if (distance == 0)
            {
                Console.WriteLine(root.Value);
                return;
            }

            nodesAtDistance(root.LeftChild, distance - 1);
            nodesAtDistance(root.RightChild, distance - 1);
        }

        public void traversalLevelOrder()
        {
            for (int i = 0; i <= height(); i++)
            {
                nodesAtDistance(i);
            }
        }

        public int size()
        {
            return size(root);
        }

        private int size(Node root)
        {
            if (root == null)
                return 0;

            if (isLeaf(root))
                return 1;

            return 1 + size(root.LeftChild) + size(root.RightChild);
        }

        public int countLeaves()
        {
            return countLeaves(root);
        }

        private int countLeaves(Node root)
        {
            if (root == null)
                return 0;

            if (isLeaf(root))
                return 1;

            return countLeaves(root.LeftChild)  + countLeaves(root.RightChild);
        }

        public int maxOfBinarySearchTree()
        {
            return maxOfBinarySearchTree(root);
        }

        private int maxOfBinarySearchTree(Node root)
        {
            if (root == null)
                return 0;

            if (root.RightChild == null)
                return root.Value;

            return maxOfBinarySearchTree(root.RightChild);

        }

        public bool contains(int value)
        {
            return contains(root, value);
        }

        private bool contains(Node root, int value)
        {
            if (root == null)
                return false;

            if (root.Value == value)
                return true;

            return contains(root.LeftChild, value) || contains(root.RightChild, value);
        }

        public bool areSibling(int firstValue, int secondValue)
        {
            return areSibling(root, firstValue, secondValue);
        }

        private bool areSibling(Node root, int firstValue, int secondValue)
        {
            if (root == null)
                return false;

            if (isLeaf(root))
                return false;

            if ((root.LeftChild.Value == firstValue && root.RightChild.Value == secondValue)||
                (root.RightChild.Value == firstValue && root.LeftChild.Value == secondValue))
                return true;

            return areSibling(root.LeftChild, firstValue, secondValue) ||
                   areSibling(root.RightChild, firstValue, secondValue);
        }

        public void getAncestors(int value)
        {
            List<int> listOfAncestors = new List<int>();
            getAncestors(root, value, listOfAncestors);

            foreach (int ancestor in listOfAncestors)
                Console.WriteLine(ancestor);
        }

        private bool getAncestors(Node root, int value, List<int> listOfAncestors)
        {
            if (root == null)
                return false;

            if (root.Value == value)
                return true;

            if (getAncestors(root.LeftChild, value, listOfAncestors) ||
               getAncestors(root.RightChild, value, listOfAncestors))
            {
                listOfAncestors.Add(root.Value);
                return true;
            }
            return false;

        }




    }
}
