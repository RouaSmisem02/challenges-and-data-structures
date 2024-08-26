using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestLevelValue
{
    public class Node
    {
        public int Value;
        public Node Left;
        public Node Right;

        public Node(int value)
        {
            Value = value;
            Left = null;
            Right = null;
        }
    }

    public class BinaryTree
    {
        public Node Root;

        public List<int> LargestValueEachLevel()
        {
            List<int> result = new List<int>();

            if (Root == null) return result;

            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(Root);

            while (queue.Count > 0)
            {
                int levelSize = queue.Count;
                int maxAtLevel = int.MinValue;

                for (int i = 0; i < levelSize; i++)
                {
                    Node currentNode = queue.Dequeue();

                    if (currentNode.Value > maxAtLevel)
                    {
                        maxAtLevel = currentNode.Value;
                    }

                    if (currentNode.Left != null)
                    {
                        queue.Enqueue(currentNode.Left);
                    }

                    if (currentNode.Right != null)
                    {
                        queue.Enqueue(currentNode.Right);
                    }
                }

                result.Add(maxAtLevel);
            }

            return result;
        }
    }
}
