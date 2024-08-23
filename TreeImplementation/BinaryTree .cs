namespace TreeImplementation
{
    public class BinaryTree
    {
        public Node Root { get; set; }

        public BinaryTree()
        {
            Root = null;
        }

        // Method to mirror the tree
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

        // Public method to call MirrorTree from the root
        public void Mirror()
        {
            MirrorTree(Root);
        }

        // InOrder traversal to print nodes
        public void InOrder(Node node)
        {
            if (node == null) return;

            InOrder(node.Left);
            Console.Write($"{node.Data} ");
            InOrder(node.Right);
        }

        // Print tree structure
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

        // Method to find the second maximum value in the binary tree
        public int FindSecondMax()
        {
            if (Root == null)
            {
                throw new InvalidOperationException("The tree is empty.");
            }

            Node parent = null;
            Node current = Root;

            // Find the maximum node
            while (current.Right != null)
            {
                parent = current;
                current = current.Right;
            }

            // Case 1: The maximum node has a left subtree
            if (current.Left != null)
            {
                Node temp = current.Left;
                while (temp.Right != null)
                {
                    temp = temp.Right;
                }
                return temp.Data;
            }

            // Case 2: The maximum node has no left subtree
            if (parent != null)
            {
                return parent.Data;
            }

            // If there is no second maximum (tree has one node)
            throw new InvalidOperationException("The tree does not have a second maximum value.");
        }

        // Method to sum all leaf nodes in the binary tree
        public int SumOfLeafNodes()
        {
            return SumOfLeafNodes(Root);
        }

        // Helper method to calculate the sum of leaf nodes recursively
        private int SumOfLeafNodes(Node node)
        {
            if (node == null)
                return 0;

            // Check if it is a leaf node
            if (node.Left == null && node.Right == null)
                return node.Data;

            // Recursive call for left and right children
            int leftSum = SumOfLeafNodes(node.Left);
            int rightSum = SumOfLeafNodes(node.Right);

            return leftSum + rightSum;
        }
    }
}
