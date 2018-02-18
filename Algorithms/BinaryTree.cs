using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainCode
{

    class Node
    {
        public int data;
        public Node left;
        public Node right;

        public Node(int data)
        {
            this.data = data;
        }

        public void AddNode(Node node)
        {
            if (this.data > node.data)
            {
                if (this.left == null)
                {
                    this.left = node;
                }
                else
                {
                    this.left.AddNode(node);
                }
            }
            if (this.data < node.data)
            {
                if (this.right == null)
                {
                    this.right = node;
                }
                else
                {
                    this.right.AddNode(node);
                }
            }
        }
        public void Traverse()
        {
            if (this.left != null)
                this.left.Traverse();

            Console.WriteLine(this.data);

            if (this.right != null)
                this.right.Traverse();
        }
    }


    class Tree
    {
        public Node root;

        public void AddValue(int value)
        {
            Node node = new Node(value);
            if (root == null)
            {
                root = node;
            }
            else
            {
                root.AddNode(node);
            }
        }
        public void Print()
        {
            this.root.Traverse();
        }

    }

    class Program
    {
        public static Random r;
        static void Main(string[] args)
        {
            r = new Random();
            Tree tree = new Tree();
            tree.AddValue(50);
            for (int i = 1; i <= 99;i++)
            {
                tree.AddValue(r.Next(1, 100));
            }

            tree.Print();

            Console.WriteLine("Done");
        }   
    }
}
