using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTreeToBST
{
    public class BinaryTree
    {
        public Node Root { get; set; }

        // Convert to BST
        public void ConvertToBST()
        {
            // Step 1: Collect values in in-order traversal
            List<int> values = new List<int>();
            InOrderTraversal(Root, values);

            // Step 2: Sort the values to fulfill BST ordering
            values.Sort();

            // Step 3: Reassign values back to nodes in in-order traversal
            int index = 0;
            AssignValuesInOrder(Root, values, ref index);
        }

        private void InOrderTraversal(Node node, List<int> values)
        {
            if (node == null) return;
            InOrderTraversal(node.Left, values);
            values.Add(node.Value);
            InOrderTraversal(node.Right, values);
        }

        private void AssignValuesInOrder(Node node, List<int> values, ref int index)
        {
            if (node == null) return;
            AssignValuesInOrder(node.Left, values, ref index);
            node.Value = values[index++];
            AssignValuesInOrder(node.Right, values, ref index);
        }

        // Helper method to print the tree for console output
        public void PrintTree(Node node, string indent = "", bool isLeft = true)
        {
            if (node != null)
            {
                Console.WriteLine(indent + (isLeft ? "L--" : "R--") + node.Value);
                PrintTree(node.Left, indent + (isLeft ? "|   " : "    "), true);
                PrintTree(node.Right, indent + (isLeft ? "|   " : "    "), false);
            }
        }
    }

}
