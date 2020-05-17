using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVLTrees
{
    class AVLTree
    {
        private AVLNode root;

        public void insert(int value)
        { 
            root = push(root, value);
        }

        private AVLNode push(AVLNode root, int value)
        {

            if (root == null)
               return root = new AVLNode(value);

            if (value > root.Value)
            {
                root.RightChild = push(root.RightChild, value);
                //root.Height += 1;
            }

            if (value < root.Value)
            {
                root.LeftChild = push(root.LeftChild, value);
                //root.Height += 1;
            }

            //int leftHeight;
            //int rightHeight;

            //leftHeight = root.LeftChild == null ? 0 : root.LeftChild.Height;
            //rightHeight = root.RightChild == null ? 0 : root.RightChild.Height;

            //root.Height = Math.Max(leftHeight, rightHeight) + 1;


            //root.Height = Math.Max(height(root.LeftChild), height(root.RightChild)) + 1;
            setHeight(root);
            return balance(root);
        }

        private AVLNode balance(AVLNode node)
        {
            //balance Factor
            // BalanceFactor = height(L) - height(R)
            // > 1 => Tree is Left Heavy
            // < -1 => Tree is Right Heavy
            //int balanceFactor = balanceFactor(root);

            if (isLeftHeavy(node))
            {
                Console.WriteLine(node.Value + " is left heavy");
                if (balanceFactor(node.LeftChild) < 0)
                {
                    //Console.WriteLine("LeftRotate({0})", node.LeftChild.Value);
                    node.LeftChild = leftRotate(node.LeftChild);
                }

                //Console.WriteLine("RightRotate({0})", node.Value);
                return rightRotate(node);
            }
            else if (isRightHeavy(node))
            {
                Console.WriteLine(node.Value + " is right heavy");
                if (balanceFactor(node.RightChild) > 0)
                {
                    //Console.WriteLine("RightRotate({0})", node.RightChild.Value);
                    node.RightChild = rightRotate(node.RightChild);
                }

                //Console.WriteLine("LeftRotate({0})", node.Value);
                return leftRotate(node);
            }
            return node;
        }

        private void setHeight(AVLNode node)
        {
            node.Height = Math.Max(height(node.LeftChild), height(node.RightChild)) + 1;
        }

        private AVLNode leftRotate(AVLNode node)
        {
            AVLNode newRoot = node.RightChild;

            node.RightChild = newRoot.LeftChild;
            newRoot.LeftChild = node;

            setHeight(node);
            setHeight(newRoot);

            return newRoot;
        }

        private AVLNode rightRotate(AVLNode node)
        {
            AVLNode newRoot = node.LeftChild;

            node.LeftChild = newRoot.RightChild;
            newRoot.RightChild = node;

            setHeight(node);
            setHeight(newRoot);

            return newRoot;
        }

        private int balanceFactor(AVLNode node)
        {
            return node == null ? 0 : height(node.LeftChild) - height(node.RightChild);
        }

        private bool isLeftHeavy(AVLNode node)
        {
            return balanceFactor(node) > 1;
        }

        private bool isRightHeavy(AVLNode node)
        {
            return balanceFactor(node) < -1;
        }

        private int height(AVLNode node)
        {
            return node == null ? -1 : node.Height;
        }

        public bool isBalanced()
        {
            return isBalanced(root);
        }

        private bool isBalanced(AVLNode node)
        {
            if (node == null)
                return true;

            return (Math.Abs(balanceFactor(node)) <=1) && isBalanced(node.LeftChild) && isBalanced(node.RightChild);
        }

        private bool isLeaf(AVLNode node)
        {
            return node.LeftChild == null && node.RightChild == null;
        }

        public int size()
        {
            return size(root);
        }

        private int size(AVLNode root)
        {
            if (root == null)
                return 0;

            if (isLeaf(root))
                return 1;

            return 1 + size(root.LeftChild) + size(root.RightChild);
        }
        public bool isPerfect()
        {
            int sizeOfAVLTree = size(root);
            return isPerfect(root);
        }

        private bool isPerfect(AVLNode node)
        {
            if (isLeaf(node))
                return true;

            if ((node.LeftChild == null && node.RightChild != null) ||
                (node.LeftChild != null && node.RightChild == null))
                return false;

            if ((node.LeftChild.Height == node.RightChild.Height) && (size(node.LeftChild) == size(node.RightChild)))
                return true;

            return isPerfect(node.LeftChild) && isPerfect(node.RightChild);
        }


    }
}
