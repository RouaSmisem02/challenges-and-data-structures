# Minimum Depth of a Binary Tree
## Problem Domain
Given a binary tree, find its minimum depth. The minimum depth is defined as the number of nodes along the shortest path from the root node down to the nearest leaf node. A leaf node is a node with no children.

## Inputs and Expected Outputs
**Input:** A binary tree.
**Output:** An integer representing the minimum depth of the tree.
**Example 1:**
```scss
BinaryTree Btree = new BinaryTree();
Btree.Root = new Node(1);
Btree.Root.Left = new Node(2);
Btree.Root.Right = new Node(3);
Btree.Root.Left.Left = new Node(4);
Btree.Root.Left.Right = new Node(5);
```

**Visual representation of the tree:**
```
        1
      /   \
     2     3
    / \
   4   5
```
```**Output: 2**```
The minimum depth is the shortest path from the root to the nearest leaf, which is 1 -> 3.

**Example 2:**
```scss
BinaryTree Btree = new BinaryTree();
Btree.Root = new Node(1);
Btree.Root.Left = new Node(2);
Btree.Root.Right = new Node(3);
Btree.Root.Left.Right = new Node(5);
Btree.Root.Right.Right = new Node(6);
```
**Visual representation of the tree:**
```
        1
      /   \
     2     3
      \      \
       5      6
```
```**Output: 3**```
Both paths have a depth of 3, so the minimum depth is 3.

## Edge Cases
If the tree is empty, return 0.
If the tree has only one node (the root), return 1.
Visual Representation
Here's a visual explanation of the tree structure and its minimum depth calculation:

**Tree Example 1:**
```
        1
      /   \
     2     3
    / \
   4   5
```
The minimum depth is 2, as the shortest path is from root 1 to leaf 3.
**Tree Example 2:**
```
        1
      /   \
     2     3
      \      \
       5      6
```
The minimum depth is 3, as both paths have the same depth.

## Algorithm
If the tree is empty, return 0.
- Initialize a queue to perform a level-order traversal (BFS).
- Add the root node and its depth (1) to the queue.
- While the queue is not empty, do the following:
- Remove the front node from the queue. If the node is a leaf (no left and right children), return its depth.
- If it has a left child, add the left child to the queue with depth +1.
- If it has a right child, add the right child to the queue with depth +1.

## Real Code
```csharp
public int FindMinimumDepth()
{
    if (Root == null)
        return 0;

    Queue<(Node, int)> queue = new Queue<(Node, int)>();
    queue.Enqueue((Root, 1));

    while (queue.Count > 0)
    {
        var (currentNode, depth) = queue.Dequeue();

        // If it's a leaf node
        if (currentNode.Left == null && currentNode.Right == null)
            return depth;

        if (currentNode.Left != null)
            queue.Enqueue((currentNode.Left, depth + 1));

        if (currentNode.Right != null)
            queue.Enqueue((currentNode.Right, depth + 1));
    }

    return 0; // Should never reach here
}
```
## Unit Tests
### Test Cases
- Test Case 1: Binary tree with multiple nodes of varying depths.
- Test Case 2: Binary tree with a single node.
- Test Case 3: Empty tree, expected result is 0.
**Example Test for an Empty Tree**
```csharp

[Fact]
public void MinimumDepth_EmptyTree_ReturnsZero()
{
    BinaryTree Btree = new BinaryTree();
    Assert.Equal(0, Btree.FindMinimumDepth());
}
```
## Big O Complexity
- Time Complexity: O(n), where n is the number of nodes in the tree. Each node is visited once in a level-order traversal.
- Space Complexity: O(n), in the worst case, the queue could store up to n nodes (in a complete tree).

## Console Output Example
```csharp
BinaryTree Btree = new BinaryTree();
Btree.Root = new Node(1);
Btree.Root.Left = new Node(2);
Btree.Root.Right = new Node(3);
Btree.Root.Left.Left = new Node(4);
Btree.Root.Left.Right = new Node(5);

int minDepth = Btree.FindMinimumDepth();
Console.WriteLine("The minimum depth is: " + minDepth);
// Output: The minimum depth is: 2
```
