namespace MinimumDepth
{
        class Program
        {
            static void Main(string[] args)
            {
                // Example 1
                BinaryTree Btree1 = new BinaryTree();
                Btree1.Root = new Node(1);
                Btree1.Root.Left = new Node(2);
                Btree1.Root.Right = new Node(3);
                Btree1.Root.Left.Left = new Node(4);
                Btree1.Root.Left.Right = new Node(5);

                Console.WriteLine("Tree 1:");
                PrintTree(Btree1.Root);
                int minDepth1 = Btree1.FindMinimumDepth();
                Console.WriteLine($"Minimum Depth of Tree 1: {minDepth1}");

                Console.WriteLine();

                // Example 2
                BinaryTree Btree2 = new BinaryTree();
                Btree2.Root = new Node(1);
                Btree2.Root.Left = new Node(2);
                Btree2.Root.Right = new Node(3);
                Btree2.Root.Left.Right = new Node(5);
                Btree2.Root.Right.Right = new Node(6);

                Console.WriteLine("Tree 2:");
                PrintTree(Btree2.Root);
                int minDepth2 = Btree2.FindMinimumDepth();
                Console.WriteLine($"Minimum Depth of Tree 2: {minDepth2}");
            }

            /// <summary>
            /// Prints the binary tree to the console in a readable format.
            /// </summary>
            /// <param name="node">Current node.</param>
            /// <param name="indent">Indentation string.</param>
            /// <param name="last">Boolean indicating if it's the last child.</param>
            static void PrintTree(Node? node, string indent = "", bool last = true)
            {
                if (node != null)
                {
                    Console.Write(indent);
                    if (last)
                    {
                        Console.Write("└─ ");
                        indent += "   ";
                    }
                    else
                    {
                        Console.Write("├─ ");
                        indent += "|  ";
                    }
                    Console.WriteLine(node.Value);
                    PrintTree(node.Left, indent, false);
                    PrintTree(node.Right, indent, true);
                }
            }
        }
}
