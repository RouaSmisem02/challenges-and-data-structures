namespace TreeImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree bst = new BinarySearchTree();

            bst.Add(10);
            bst.Add(5);
            bst.Add(15);
            bst.Add(7);

            Console.WriteLine("PreOrder Traversal:");
            bst.PreOrder(bst.Root);
            Console.WriteLine();

            Console.WriteLine("InOrder Traversal:");
            bst.InOrder(bst.Root);
            Console.WriteLine();

            Console.WriteLine("PostOrder Traversal:");
            bst.PostOrder(bst.Root);
            Console.WriteLine();

            Console.WriteLine("Tree Structure:");
            bst.Print(bst.Root);

            Console.WriteLine($"Contains 7: {bst.Contains(7)}");
            bst.Remove(5);
            Console.WriteLine($"Contains 5 after removal: {bst.Contains(5)}");
        }
    }

}
