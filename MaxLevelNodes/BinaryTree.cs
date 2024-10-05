using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxLevelNodes
{
    public class BinaryTree
    {
        public Node Root;

        public BinaryTree()
        {
            Root = null;
        }

        // Method to find the level with the maximum number of nodes
        public int FindMaxLevelNodes()
        {
            if (Root == null)
            {
                throw new InvalidOperationException("The tree is empty.");
            }

            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(Root);

            int maxLevel = 0;
            int maxNodeCount = 0;
            int currentLevel = 0;

            while (queue.Count > 0)
            {
                int levelNodeCount = queue.Count; // Number of nodes at current level

                if (levelNodeCount > maxNodeCount)
                {
                    maxNodeCount = levelNodeCount;
                    maxLevel = currentLevel;
                }

                // Process all nodes at the current level
                for (int i = 0; i < levelNodeCount; i++)
                {
                    Node currentNode = queue.Dequeue();
                    if (currentNode.Left != null) queue.Enqueue(currentNode.Left);
                    if (currentNode.Right != null) queue.Enqueue(currentNode.Right);
                }

                currentLevel++;
            }

            return maxLevel;
        }
    }
}
