namespace TreeImplementation
{
    public class BinarySearchTree : BinaryTree
    {
        // Method to add a node to the BST
        public void Add(int value)
        {
            Root = AddRecursive(Root, value);
        }

        private Node AddRecursive(Node current, int value)
        {
            if (current == null)
            {
                return new Node(value);
            }

            if (value < current.Data)
            {
                current.Left = AddRecursive(current.Left, value);
            }
            else if (value > current.Data)
            {
                current.Right = AddRecursive(current.Right, value);
            }

            return current;
        }
    }
}
