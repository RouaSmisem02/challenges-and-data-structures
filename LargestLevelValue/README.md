# Largest Level Value

## Problem Domain
Using your binary tree implementation, find the largest value at each level of the binary tree.

## Inputs and Expected Outputs
- **Input**: A binary tree.
- **Output**: A list of the largest values at each level of the binary tree.

## Edge Cases
- An empty tree should return an empty list.

## Algorithm
1. Use a queue to perform a level-order traversal.
2. At each level, find the maximum value.
3. Add the maximum value to the result list.
4. Repeat until all levels are traversed.

## Real Code
See the `LargestLevelValue.cs` file.

## Big O Time/Space Complexity
- **Time Complexity**: O(N), where N is the number of nodes in the binary tree.
- **Space Complexity**: O(M), where M is the maximum number of nodes at any level in the binary tree.

## Visual Representation of the Binary Tree
```
         5
       /   \
     13      7
    /  \    /  \
   3    7  12   20
  / \        \
 1   4        11
```
## Level-wise Representation:
Level 0: 5
Level 1: 13, 7
Level 2: 3, 7, 12, 20
Level 3: 1, 4, 11
