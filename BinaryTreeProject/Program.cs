using System;
using System.Collections.Generic;

namespace BinaryTreeProject
{



   
    class program
    {
        static void Main()
        {
            BinaryTree<int> tree = new BinaryTree<int>(new Node<int>(17));
           
            tree.AddNode(tree.Root, new Node<int>(8));
            tree.AddNode(tree.Root, new Node<int>(5));
            tree.AddNode(tree.Root, new Node<int>(18));
            tree.AddNode(tree.Root, new Node<int>(42));
            tree.AddNode(tree.Root, new Node<int>(1));
            tree.AddNode(tree.Root, new Node<int>(21));
            tree.AddNode(tree.Root, new Node<int>(7));

            Console.WriteLine("\nParcours Prefixe : ");
            tree.PrefixSearch(tree.Root);
            Console.WriteLine("\nParcours Postfixe : ");
            tree.PostfixSearch(tree.Root);
            Console.WriteLine("\nParcours Infixe : ");
            tree.InfixSearch(tree.Root);
            Console.ReadKey(); 
        }
    }


}
