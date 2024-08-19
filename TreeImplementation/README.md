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
