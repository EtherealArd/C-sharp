using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train
{
    class Node
    {
        public int data;
        public Node right;
        public Node left;
        public Node(int val)
        {
            this.data = val;
        }
        
        
    }
    

    class Program
    {
        static void Main(string[] args)
        {

            Node root;
            Tree(root, 1, 10);
            Console.WriteLine("azaza");
        }

        public static void Tree(Node node,int num,int count)
        {
            if (count <= 0)
                return;

            if (node == null)
                node = new Node(num);

            num++;
            node = new Node(num);
            Tree(node.left, num, count);

            num++;
            node = new Node(num);
            Tree(node.right, num, count);
        }

      
    }
}