using BinaryTreeProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeProject
{
    public class BinaryTree<T> where T : IComparable
    {
        public Node<T> Root { get; set; }
       
        public BinaryTree(Node<T> root)
        {
            Root = root;
        }

        public void AddNode(Node<T> root, Node<T> nodeToAdd)
        {
           
            if (nodeToAdd.Value.CompareTo(root.Value) < 0)
            {
                if (root.LeftChild != null)
                    AddNode(root.LeftChild, nodeToAdd);
                else
                {
                    root.LeftChild = nodeToAdd;
                    root.LeftChild.Display("Left", root.Value);
                }
            }
            else
            {
                if (nodeToAdd.Value.CompareTo(root.Value) > 0)
                {
                    if (root.RightChild != null) 
                        AddNode(root.RightChild, nodeToAdd);
                    else
                    {
                        root.RightChild = nodeToAdd;
                        root.RightChild.Display("Right", root.Value);
                    }
                }
            }
        }

        //public void DisplayTree(Node<T> root,int pad)
        //{   
            
        //    string affichage = $"{root.Value}".PadLeft(pad);
        //    string lienGauche = "/";
        //    string lienDroit = "\\";
        //    Console.Write(affichage);
        //    Console.WriteLine();
           
        //    if(root.LeftChild != null && root.RightChild != null)
        //    {
        //        Console.Write(lienGauche.PadLeft(pad-1));
        //        Console.Write(lienDroit);
        //    }
        //    Console.WriteLine();
        //    if (root.LeftChild != null)
        //    {
               
        //        DisplayTree(root.LeftChild, pad-4);
        //    }
        //    if (root.RightChild != null)
        //    {
                
        //        DisplayTree(root.RightChild, pad+4);
        //    }

           
        //}

        public void PrefixSearch(Node<T> root)
        {
            Node<T> parent = root;
            Console.Write($"{root.Value} - ");
            if (root.LeftChild != null)
            {
                PrefixSearch(root.LeftChild);
            }
            if (root.RightChild != null)
            {
                PrefixSearch(root.RightChild);
            }

        }

        public void InfixSearch(Node<T> root)
        {
            Node<T> parent = root;

            if (root.LeftChild != null)
            {
                InfixSearch(root.LeftChild);
            }
            Console.Write($"{root.Value} - ");
           

            if (root.RightChild != null)
            {
                InfixSearch(root.RightChild);
            }

        }

        public void PostfixSearch(Node<T> root)
        {
            if (root.LeftChild != null)
            {
                PostfixSearch(root.LeftChild);
            }
            if (root.RightChild != null)
            {
                PostfixSearch(root.RightChild);
            }
            Console.Write($"{root.Value} - ");
        }
    }
}
