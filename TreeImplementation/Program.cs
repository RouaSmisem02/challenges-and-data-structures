namespace TreeImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree bst = new BinarySearchTree();

            bst.Add(4);
            bst.Add(8);
            bst.Add(7);
            bst.Add(12);
            bst.Add(9);

            Console.WriteLine("Original InOrder Traversal:");
            bst.InOrder(bst.Root); // This calls the InOrder method from BinaryTree
            Console.WriteLine();

            bst.Print(bst.Root);
            Console.WriteLine();

            bst.Mirror();

            Console.WriteLine("Mirrored InOrder Traversal:");
            bst.InOrder(bst.Root);
            Console.WriteLine();

            bst.Print(bst.Root);
        }
    }
}
