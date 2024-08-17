using System;

namespace TreeImplementation
{
    public class BinaryTree
    {
        public Node Root { get; set; }

        public BinaryTree()
        {
            Root = null;
        }

        // Existing methods...

        public void MirrorTree(Node node)
        {
            if (node == null) return;

            // Swap the left and right children
            Node temp = node.Left;
            node.Left = node.Right;
            node.Right = temp;

            // Recursively mirror the left and right subtrees
            MirrorTree(node.Left);
            MirrorTree(node.Right);
        }

        // Add a method to call MirrorTree from the root
        public void InOrder(Node node)
        {
            if (node == null) return;

            InOrder(node.Left);
            Console.Write($"{node.Data} ");
            InOrder(node.Right);
        }

        public void Print(Node node, string indent = "", bool last = true)
        {
            if (node != null)
            {
                Console.Write(indent);
                if (last)
                {
                    Console.Write("R----");
                    indent += "     ";
                }
                else
                {
                    Console.Write("L----");
                    indent += "|    ";
                }

                Console.WriteLine(node.Data);

                Print(node.Left, indent, false);
                Print(node.Right, indent, true);
            }
        }

        public void Mirror()
        {
            MirrorTree(Root);
        }
    }
}
