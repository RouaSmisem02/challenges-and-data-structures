# Binary Tree and Binary Search Tree Implementation

## Problem Domain

In this challenge, we are required to implement two fundamental data structures: Binary Tree and Binary Search Tree (BST). These data structures are essential for various computer science applications, including searching, sorting, and hierarchical data storage.

### Binary Tree

A Binary Tree is a tree data structure where each node has at most two children, referred to as the left child and the right child. The tree supports traversal methods such as PreOrder, InOrder, and PostOrder.

### Binary Search Tree (BST)

A Binary Search Tree (BST) is a type of Binary Tree where the nodes are organized in a manner such that:
- The left subtree of a node contains only nodes with values less than the node’s value.
- The right subtree of a node contains only nodes with values greater than the node’s value.
- Both the left and right subtrees are also binary search trees.

The BST supports operations like adding a node, checking if a node exists, and removing a node while maintaining the BST properties.

## Input and Output Examples

### Example 1: Binary Search Tree Operations

```csharp
BinarySearchTree bst = new BinarySearchTree();

// Adding nodes to the BST
bst.Add(10);
bst.Add(5);
bst.Add(15);
bst.Add(7);

// Check if a node exists
bool contains7 = bst.Contains(7); // Output: true

// Remove a node
bst.Remove(5);

// Check if the node is removed
bool contains5 = bst.Contains(5); // Output: false
```
### Edge Cases Considered
Empty Tree: Handle cases where the tree is empty, and operations like traversal or removal are attempted.
Duplicate Values: Ensure that duplicate values are not added to the BST.
Removing Non-Existent Node: Handle attempts to remove a node that doesn't exist in the tree.
Single Node Tree: Operations on a tree with only one node, especially removal.
Visual Diagram of the Tree
Here’s a visual representation of the Binary Search Tree after adding the nodes 10, 5, 15, 7:
```
        10
       /  \
      5    15
       \
        7
```
After removing the node 5, the tree looks like this:
```
        10
       /  \
      7    15
```
### The Algorithm Used
Adding a Node in BST
Start at the root.
If the new value is less than the current node’s value, move to the left child.
If the new value is greater than the current node’s value, move to the right child.
If the correct position is found (i.e., null), insert the new node.
### Removing a Node in BST
If the node to be removed has no children, simply remove it.
If the node has one child, remove it and replace it with its child.
If the node has two children, find the smallest node in the right subtree, replace the current node with it, and remove the smallest node.
### Traversal Methods
PreOrder: Visit Root, Left, Right.
InOrder: Visit Left, Root, Right.
PostOrder: Visit Left, Right, Root.

### Big O Analysis
Time Complexity
Add Node: O(log n) in the best case for a balanced tree, O(n) in the worst case for a skewed tree.
Contains Node: O(log n) in the best case for a balanced tree, O(n) in the worst case for a skewed tree.
Remove Node: O(log n) in the best case for a balanced tree, O(n) in the worst case for a skewed tree.
Traversal Methods (PreOrder, InOrder, PostOrder): O(n) since each node is visited once.
### Space Complexity
Add Node, Contains Node, Remove Node: O(1) for iterative implementations. O(h) for recursive implementations, where h is the height of the tree.
Traversal Methods: O(n) in the worst case due to recursion stack.
