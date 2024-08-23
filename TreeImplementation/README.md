## Min Stack Challenge

### Problem Domain
Implement a stack that supports push, pop, top, and retrieving the minimum element in constant time.

### Inputs and Outputs
- Inputs: Series of stack operations.
- Outputs: Results of stack operations, focusing on the minimum value.

### Edge Cases
- Operations on an empty stack.
- Multiple elements with the same minimum value.

### Algorithm
- Utilize two stacks: one for regular elements and another for minimum values.
- Ensure operations like Push, Pop, and GetMin maintain constant time complexity.

### Real Code
Here's the C# implementation of the MinStack class:

```csharp
// Insert your MinStack.cs code here

### Big O Time/Space Complexity
```
Push: O(1)
Pop: O(1)
Top: O(1)
GetMin: O(1)
```
# Mirror Tree Challenge
### Problem Domain
Convert a binary tree into its mirror tree, where all left and right children are swapped.

### Inputs and Expected Outputs
Inputs: A binary tree.
Outputs: The mirrored binary tree.
Edge Cases
Single-node tree.
Empty tree.
Visual

### Algorithm
MirrorTree(): Traverse the binary tree recursively and swap the left and right subtrees.
InorderTraversal(): Perform an inorder traversal to return a list of nodes in the sequence.

### Big O Time/Space Complexity
Mirror: O(n) where n is the number of nodes in the tree.
InorderTraversal: O(n) where n is the number of nodes in the tree.

# Second-Max-Value
### Expected Console Output
```
InOrder Traversal:
3 5 7 10 15 20 25

Second Maximum Value: 20
```
### Problem Domain
Find the second maximum value in a binary tree. The second maximum value is the largest value that is less than the maximum value in the tree.

### Inputs and Expected Outputs
Input: A binary tree with nodes containing integer values.
Output: The second maximum value in the binary tree.

### Example:
```
    10
   /  \
  5    20
 / \   / \
3   7 15  25
```
#### Output: 20
### Edge Cases
An empty tree (should throw an exception).
A tree with only one node (should throw an exception).
A tree with fewer than two unique values (should throw an exception).

### Visual:
```
      10
     /  \
    5    20
   / \   / \
  3   7 15  25
```
In-Order Traversal: 3, 5, 7, 10, 15, 20, 25
Maximum Value: 25
Second Maximum Value: 20
### Algorithm
Start at the root.
Traverse the tree to find the maximum value.
Track the second maximum by considering:
The parent of the maximum node if it exists.
The largest value in the left subtree of the maximum node.
Handle edge cases.
Return the second maximum value.
### Big O Time/Space Complexity
Time Complexity: O(h) where h is the height of the tree. The traversal to find the maximum and second maximum value is proportional to the height.
Space Complexity: O(1) as we only use a fixed amount of space for the parent and current nodes.
--------------------------
### Problem Domain
We want to calculate the sum of all the leaf nodes in a binary search tree. A leaf node is a node that does not have any children (i.e., both its left and right pointers are null).

### Inputs and Expected Outputs
Input: A binary search tree (BST) with nodes containing integer values.
Output: An integer representing the sum of all leaf node values in the BST.
### Example:
Given the following BST:
```
       9
     /    \
    8      12
   /  \   /   \
  3    7 17    23
   \
    4
```
Leaf Nodes: 4, 7, 17, 23
Expected Output: 4 + 7 + 17 + 23 = 51
### Edge Cases
Empty Tree: If the BST is empty (Root is null), the sum of leaf nodes should be 0.
Single Node Tree: If the BST has only one node (the root itself), and it's a leaf, the sum should be the value of the root node.
All Nodes Are Leafs: If all nodes in the BST are leaf nodes, the sum should be the sum of all node values.
No Leaf Nodes: This scenario is impossible in a valid tree structure, as any valid tree must have at least one leaf.
### Visual Representation

```
       9
     /    \
    8      12
   /  \   /   \
  3    7 17    23
   \
    4
```
Leaf Nodes: 4, 7, 17, 23
Sum of Leaf Nodes: 4 + 7 + 17 + 23 = 51
### Algorithm
Base Case: If the node is null, return 0.
Check Leaf Node: If the node has no left and right children, it is a leaf node, return its value.
Recursive Case: Recursively calculate the sum of leaf nodes for both left and right children.
Return the Sum: Return the sum of the values from the left and right subtree recursions.

## Big O Time and Space Complexity
### Time Complexity
The time complexity of the SumOfLeafNodes method is O(n), where n is the number of nodes in the binary search tree (BST).

Reasoning: The SumOfLeafNodes method traverses each node in the binary tree exactly once. For each node, it checks if the node is a leaf or not and then recursively calls the function on the left and right children. This results in a linear time complexity, O(n), since every node in the tree is visited once.
Space Complexity
The space complexity of the SumOfLeafNodes method is O(h), where h is the height of the binary search tree (BST).

Reasoning: The space complexity is determined by the maximum depth of the recursion stack, which corresponds to the height of the tree. In the worst-case scenario (if the tree is unbalanced and resembles a linked list), the height of the tree could be n, leading to O(n) space complexity. However, in a balanced binary search tree, the height is O(log n), so the space complexity would be O(log n) in this case.
### Summary
Time Complexity: O(n)
Space Complexity: O(h), where h is the height of the tree. In the worst case (unbalanced tree), O(n); in the best case (balanced tree), O(log n).
