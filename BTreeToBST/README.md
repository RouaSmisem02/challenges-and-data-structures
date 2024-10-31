# Binary Tree to Binary Search Tree

## Problem Domain

The goal is to convert a given Binary Tree into a Binary Search Tree (BST) while maintaining the original structure of the Binary Tree. This means the resulting BST should have the same shape as the Binary Tree, but with values rearranged to follow the properties of a BST.

## Requirements

- Implement a `ConvertToBST()` method that transforms a Binary Tree into a BST with the same structure.
- Ensure that, for each node:
  - The left subtree contains values less than the node’s value.
  - The right subtree contains values greater than the node’s value.
- Handle potential exceptions gracefully and include meaningful console output for demonstration.
- Write unit tests with xUnit to validate the solution.
  
## Example

### Input: Binary Tree
```
       40
      /  \
     10   50
    /  \    \
   5   30   60
      /  \
     20   35
```

### Expected Output: Binary Search Tree
```
       35
      /  \
     20   50
    /  \    \
   10   40  60
  /
 5
```

## Solution Approach

1. **In-Order Traversal**:
   - Collect all node values from the Binary Tree using an in-order traversal and store them in a list.
  
2. **Sorting**:
   - Sort the collected values, as a sorted list will allow us to assign values to the BST in the correct order.

3. **Reassignment**:
   - Reassign each node’s value in an in-order traversal, which guarantees that the values are assigned in increasing order to follow BST properties.

### Algorithm Steps

1. Perform an in-order traversal of the Binary Tree and collect values into a list.
2. Sort the values to arrange them in ascending order.
3. Traverse the Binary Tree again (in-order), and reassign the values from the sorted list to each node.

### Big O Complexity

- **Time Complexity**: \(O(n \log n)\) due to the sorting step.
- **Space Complexity**: \(O(n)\) for storing the list of values.

## Edge Cases

- **Empty Tree**: No conversion needed.
- **Single Node Tree**: The node remains unchanged.
- **Skewed Trees**: The method should handle trees with nodes only on one side (e.g., left or right skewed trees).

## Code Implementation

The solution code is available in the `BinaryTree.cs` file within the `BTreeToBST` folder of the `TreeImplementation` project.

### Main Code Snippet

```csharp
public class BinaryTree
{
    public Node Root { get; set; }

    // Convert to BST
    public void ConvertToBST()
    {
        List<int> values = new List<int>();
        InOrderTraversal(Root, values);

        values.Sort();
        int index = 0;
        AssignValuesInOrder(Root, values, ref index);
    }

    private void InOrderTraversal(Node node, List<int> values)
    {
        if (node == null) return;
        InOrderTraversal(node.Left, values);
        values.Add(node.Value);
        InOrderTraversal(node.Right, values);
    }

    private void AssignValuesInOrder(Node node, List<int> values, ref int index)
    {
        if (node == null) return;
        AssignValuesInOrder(node.Left, values, ref index);
        node.Value = values[index++];
        AssignValuesInOrder(node.Right, values, ref index);
    }
}
```

## Tests

The solution includes xUnit tests to validate different scenarios:

1. **Test the given example**: Ensure the correct output when converting the provided Binary Tree to a BST.
2. **Single Node Tree**: Verify that a single-node tree remains the same after conversion.
3. **Left-Skewed Tree**: Test trees with nodes only on the left side.
4. **Right-Skewed Tree**: Test trees with nodes only on the right side.

### Sample Unit Test Code

```csharp
[Fact]
public void ConvertToBST_ShouldConvertTreeCorrectly()
{
    BinaryTree Btree = new BinaryTree();
    Btree.Root = new Node(40);
    Btree.Root.Left = new Node(10);
    Btree.Root.Right = new Node(50);
    Btree.Root.Left.Left = new Node(5);
    Btree.Root.Left.Right = new Node(30);
    Btree.Root.Right.Right = new Node(60);
    Btree.Root.Left.Right.Left = new Node(20);
    Btree.Root.Left.Right.Right = new Node(35);

    Btree.ConvertToBST();

    List<int> expected = new List<int> { 5, 10, 20, 30, 35, 40, 50, 60 };
    List<int> result = new List<int>();
    Btree.InOrderTraversal(Btree.Root, result);

    Assert.Equal(expected, result);
}
```

## Visual Representation (Whiteboard)
## Console Output
![Uploading BTtoBST.png…]()

### Before Conversion (Binary Tree):
```
L--40
|   L--10
|   |   L--5
|   |   R--30
|   |       L--20
|   |       R--35
R--50
    R--60
```

### After Conversion (Binary Search Tree):
```
L--35
|   L--20
|   |   L--10
|   |   R--30
|   R--50
R--60
```

## Submission Steps

1. Push all files, including implementation, tests, and README, to the `BTree-to-BST` branch.
2. Update the root `README.md` file’s Table of Contents with a link to this README.
3. Create a pull request from `BTree-to-BST` to the `main` branch and merge.
4. Provide the pull request link as your submission.

## Screenshot


---
