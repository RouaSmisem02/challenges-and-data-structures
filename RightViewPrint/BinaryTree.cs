using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RightViewPrint
{
    public class BinaryTree
    {
        public Node Root;

        public void PrintRightView()
        {
            if (Root == null) return;

            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(Root);

            while (queue.Count > 0)
            {
                int levelSize = queue.Count;

                for (int i = 1; i <= levelSize; i++)
                {
                    Node current = queue.Dequeue();

                    // If it's the rightmost node of this level
                    if (i == levelSize)
                        Console.Write(current.Data + " ");

                    if (current.Left != null)
                        queue.Enqueue(current.Left);
                    if (current.Right != null)
                        queue.Enqueue(current.Right);
                }
            }
        }
    }
}
