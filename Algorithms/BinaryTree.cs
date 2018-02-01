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
        public void AddNode(Node node)
        {
            if (node.data < this.data)
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
            else if (node.data > this.data)
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
        public void Visit()
        {
            if (this.left != null)
            {
                this.left.Visit();
            }
            Console.WriteLine(this.data);

            if (this.right != null)
            {
                this.right.Visit();
            }

        }
        public Node Search(int val)
        {
            if (this.data == val)
            {
                return this;
            }
            else if (val < this.data && this.left != null)
            {
                return this.left.Search(val);
            }
            else if (val > this.data && this.right != null)
            {
                return this.right.Search(val);
            }
            return null;
        }
    }
    class Tree
    {
        Node root;
        public void AddValue(int val)
        {
            Node node = new Node(val);
            if (this.root == null)
            {
                this.root = node;
            }
            else
            {
                this.root.AddNode(node);
            }

        }
        public void Traverse()
        {
            this.root.Visit();
        }

        public void Search(int val)
        {
            Node found = root.Search(val);
            if(found!=null)
                Console.WriteLine("Found");
            else
                Console.WriteLine("Not found");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Tree tree = new Tree();
            tree.AddValue(500);
            tree.AddValue(400);
            tree.AddValue(600);
            tree.AddValue(700);
            tree.AddValue(300);
            tree.AddValue(511);
            tree.AddValue(434);
            tree.AddValue(564);
            tree.AddValue(70);
            tree.AddValue(301);
            tree.Traverse();
            tree.Search(70);

            Console.WriteLine("azaza");
        }

      
    }
}