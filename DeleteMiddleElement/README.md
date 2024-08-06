# Delete Middle Element of a Stack

## Problem Domain
Implement a method to delete the middle element of a stack in C#. If the stack has an even number of elements, remove the lower middle element.

## Inputs and Expected Outputs
- Input: Stack with elements [7, 14, 3, 8, 5]
- Output: Stack with middle element removed [7, 14, 8, 5]

## Edge Cases
- Stack is empty
- Stack has only one element

## Algorithm
1. Calculate the middle position of the stack.
2. Use a temporary stack to hold elements while traversing to the middle.
3. Remove the middle element.
4. Push back the elements from the temporary stack to the original stack.

## Real Code
```csharp
public void DeleteMiddle()
{
    if (this.Count == 0)
    {
        throw new InvalidOperationException("Stack is empty.");
    }

    int middleIndex = (this.Count - 1) / 2;
    Stack<int> tempStack = new Stack<int>();

    for (int i = 0; i < middleIndex; i++)
    {
        tempStack.Push(this.Pop());
    }

    this.Pop();

    while (tempStack.Count > 0)
    {
        this.Push(tempStack.Pop());
    }
}
```
### Big O Time/Space Complexity
````O(1)+O(n)+O(1)+O(n)=O(n)````

-Time Complexity: O(n)

-Space Complexity: O(n)

### Expected Output
```
Initial Stack: Stack: Top -> 5 -> 8 -> 3 -> 14 -> 7
After deleting middle element (odd-sized stack): Stack: Top -> 5 -> 8 -> 14 -> 7
Stack after adding more elements: Stack: Top -> 11 -> 9 -> 2 -> 5 -> 8 -> 14 -> 7
After deleting middle element (even-sized stack): Stack: Top -> 11 -> 9 -> 2 -> 8 -> 14 -> 7
```

### Unit Tests
Test deleting the middle element of an odd-sized stack.
Test deleting the middle element of an even-sized stack.
Test edge cases: empty stack, single element stack.