using TreeImplementation;

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
            bst.Print(bst.Root);
            Console.WriteLine();

            // Mirror the tree
            bst.Mirror();

            // Display the mirrored in-order traversal
            Console.WriteLine("Mirrored InOrder Traversal:");
            bst.InOrder(bst.Root);
            Console.WriteLine();

            // Print the mirrored tree structure
            bst.Print(bst.Root);

            BinarySearchTree bstree = new BinarySearchTree();

            bstree.Add(10);
            bstree.Add(5);
            bstree.Add(20);
            bstree.Add(3);
            bstree.Add(7);
            bstree.Add(15);
            bstree.Add(25);

            Console.WriteLine("InOrder Traversal:");
            bstree.InOrder(bstree.Root);
            Console.WriteLine();

            int secondMax = bstree.FindSecondMax();
            Console.WriteLine($"Second Maximum Value: {secondMax}");
        }


    }
}
