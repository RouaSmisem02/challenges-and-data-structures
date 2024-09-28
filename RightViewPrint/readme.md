## Problem Domain:
The right view of a binary tree is the set of nodes visible when viewed from the right side. The goal is to traverse the binary tree and print the rightmost node at each level.

## Inputs and Expected Outputs:
**Input:**
A binary tree with nodes.
The binary tree could have nodes on either side or both sides (left and right).
**Example Input:**
```
    2
  /   \
 3     5
/       \
4        6
\
 7
```
**Output:** ```2 5 6 7```

**Input:**
Binary tree with nodes only on the right side.
Example Input:
```
   10
     \
     20
       \
       30
         \
         40
```
**Output:** ```10 20 30 40```

## Edge Cases:
### Empty Tree:
- Input: An empty tree (null root).
- Output: No output.
### Single Node Tree:
- Input: A tree with just one node.
- Output: The single node is printed.
### Tree with All Nodes on One Side:
- Input: A tree with nodes only on the right or left side.
- Output: The nodes of that side (right or left, but in this case focus on the right side).
  
## Visual:
The binary tree visual from the problem statement:
```
         2
       /   \
      3     5
     /       \
    4         6
     \
      7
```
**Right View Output:** ```2 5 6 7```

## Algorithm:
### Traversal Approach:
- Use level-order traversal (BFS) to traverse the tree.
- For each level of the tree, track the rightmost node.
### Steps:
- Use a queue to perform BFS.
- At each level, store the last node (rightmost node) in that level.
- Print the last node of each level.

## Real Code:
```csharp
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

            if (i == levelSize)  // Rightmost node in the current level
                Console.Write(current.Data + " ");

            if (current.Left != null)
                queue.Enqueue(current.Left);
            if (current.Right != null)
                queue.Enqueue(current.Right);
        }
    }
}
```
## Big O Time/Space Complexity:
- Time Complexity: O(n) where n is the number of nodes in the tree. Each node is visited once during the level-order traversal.
- Space Complexity: O(n) due to the space needed for the queue during traversal, which in the worst case could hold all nodes at the bottom-most level.
