using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeTraversal_Inorder
{

    public class Node
    {
       public  Node LeftNode { get; set; }
        public Node RightNode { get; set; }
        public int Data { get; set; }

    }
    internal class BinaryTree
    {
        public Node Root { get; set; }
        public bool Add(int value)
        {
            Node before = null;
            Node after = this.Root;

            while(after != null)
            {
                before = after;
                if (value < after.Data)
                    after = after.LeftNode;
                else if (value > after.Data)
                    after = after.RightNode;
                else
                    return false;
            }

            Node newNode = new Node();
            newNode.Data = value;

            if (this.Root == null) //setting the root
                this.Root = newNode;
            else
            {
                if(value < before.Data)
                    before.LeftNode = newNode;
                else
                    before.RightNode = newNode;
            }
            return true;
        }
        public void TraversePreOrder(Node parent) // root - left - right 
        {
            if (parent != null)
            {
                Console.Write(parent.Data + " ");
                TraversePreOrder(parent.LeftNode);
                TraversePreOrder(parent.RightNode);
            }
        }

        public void TraverseInOrder(Node parent)// left - root - right 
        {
            if (parent != null)
            {
                TraverseInOrder(parent.LeftNode);
                Console.Write(parent.Data + " ");
                TraverseInOrder(parent.RightNode);
            }
        }

        public void TraversePostOrder(Node parent)//left - right - root
        {
            if (parent != null)
            {
                TraversePostOrder(parent.LeftNode);
                TraversePostOrder(parent.RightNode);
                Console.Write(parent.Data + " ");
            }
        }



    }
}
