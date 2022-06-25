using System;

namespace TreeTraversal_Inorder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Inroduction on Trees");
           
            BinaryTree tree = new BinaryTree();
            tree.Add(10);
            tree.Add(1);
            tree.Add(2);
            tree.Add(7);
            tree.Add(3);
            tree.Add(10);
            tree.Add(5);
            tree.Add(8);
            Console.WriteLine("Inorder traversal");
            tree.TraverseInOrder(tree.Root);
            Console.WriteLine();
            Console.WriteLine("PreOrder traversal");
            tree.TraversePreOrder(tree.Root);
            Console.WriteLine();
            Console.WriteLine("Postorder traversal");
            tree.TraversePostOrder(tree.Root);

        }
    }
}
