# Binary Tree - Level with Maximum Number of Nodes

## Problem Domain
Find the level in the binary tree that contains the maximum number of nodes.

### Inputs:
- A binary tree where each node has a value and links to left and right children.

### Expected Output:
- The level number with the maximum number of nodes.

### Edge Cases:
- Empty tree: Throw an exception.
- Only one node in the tree.
- Multiple levels with the same number of nodes: Return the smallest level.

## Algorithm
1. Use BFS (level-order traversal) to traverse the binary tree.
2. Count the number of nodes at each level.
3. Track the level with the maximum number of nodes.
4. Return the level number with the maximum node count.

### Big O Complexity
- **Time Complexity**: O(n), where n is the number of nodes in the tree.
- **Space Complexity**: O(w), where w is the maximum width of the tree (max number of nodes at any level).

### Visual Representation
Let's visualize the binary tree structure and its levels.

For the tree:
```
         1
       /   \
      2     3
     / \     \
    4   5     6
   /
  7
```
Level 0: 1 node (1)
Level 1: 2 nodes (2, 3)
Level 2: 3 nodes (4, 5, 6)
Level 3: 1 node (7)
The level with the maximum number of nodes is Level 2, which has 3 nodes.

For another example:
```
         1
       /   \
      2     3
     / \     \
    4   5     6
   /   /     /
  7   8     9
```
Level 0: 1 node (1)
Level 1: 2 nodes (2, 3)
Level 2: 3 nodes (4, 5, 6)
Level 3: 3 nodes (7, 8, 9)
Here, Level 2 and Level 3 both have 3 nodes, but since we're supposed to return the smallest level, the answer is Level 2.
