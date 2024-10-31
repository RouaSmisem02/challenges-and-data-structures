namespace BTreeToBST
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree Btree = new BinaryTree();
            Btree.Root = new Node(40);
            Btree.Root.Left = new Node(10);
            Btree.Root.Right = new Node(50);
            Btree.Root.Left.Left = new Node(5);
            Btree.Root.Left.Right = new Node(30);
            Btree.Root.Right.Right = new Node(60);
            Btree.Root.Left.Right.Left = new Node(20);
            Btree.Root.Left.Right.Right = new Node(35);

            Console.WriteLine("Before Conversion (Binary Tree):");
            Btree.PrintTree(Btree.Root);

            Btree.ConvertToBST();

            Console.WriteLine("\nAfter Conversion (Binary Search Tree):");
            Btree.PrintTree(Btree.Root);
        }
    }
}
