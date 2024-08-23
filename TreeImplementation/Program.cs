using System;

namespace TreeImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree bst = new BinarySearchTree();

            // Adding nodes to the BST
            bst.Add(4);
            bst.Add(8);
            bst.Add(7);
            bst.Add(12);
            bst.Add(9);

            // Display the original in-order traversal
            Console.WriteLine("Original InOrder Traversal:");
            bst.InOrder(bst.Root);
            Console.WriteLine();

            // Print the original tree structure
            Console.WriteLine("Original Tree Structure:");
            bst.Print(bst.Root);
            Console.WriteLine();

            // Mirror the tree
            bst.Mirror();

            // Display the mirrored in-order traversal
            Console.WriteLine("Mirrored InOrder Traversal:");
            bst.InOrder(bst.Root);
            Console.WriteLine();

            // Print the mirrored tree structure
            Console.WriteLine("Mirrored Tree Structure:");
            bst.Print(bst.Root);
            Console.WriteLine();

            // Create a new binary search tree for second maximum value
            BinarySearchTree bstree = new BinarySearchTree();

            // Adding nodes to the BST
            bstree.Add(10);
            bstree.Add(5);
            bstree.Add(20);
            bstree.Add(3);
            bstree.Add(7);
            bstree.Add(15);
            bstree.Add(25);
            Console.WriteLine();


            // Display the in-order traversal
            Console.WriteLine("InOrder Traversal:");
            bstree.InOrder(bstree.Root);
            Console.WriteLine();

            // Find and display the second maximum value
            int secondMax = bstree.FindSecondMax();
            Console.WriteLine($"Second Maximum Value: {secondMax}");
            Console.WriteLine();
            // Calculate and display the sum of leaf nodes
            int sumOfLeaves = bstree.SumOfLeafNodes();
            Console.WriteLine($"Sum of Leaf Nodes: {sumOfLeaves}");
        }
    }
}
