using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeProject
{
    public class Node<T> where T : IComparable
    {

       
        public T Value { get; set; }

        public Node<T> LeftChild { get; set; }

        public Node<T> RightChild { get; set; }

        public Node(T value)
        {
            Value = value;
        }
         
        public void Display(string prefixe, T parent)
        {
            
            string message = $"Parent : {parent} --> {prefixe} : {Value} ";
           
            Console.WriteLine(message);
        }
    }
}
