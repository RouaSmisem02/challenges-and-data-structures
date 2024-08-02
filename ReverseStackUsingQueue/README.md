# Reverse Stack Using Queue

## Problem Domain
Implement a method to reverse a stack using a queue in C#.

## Inputs and Expected Outputs
- **Input Stack**: Top -> 5 -> 4 -> 3 -> 2 -> 1
- **Reversed Stack**: Top -> 1 -> 2 -> 3 -> 4 -> 5

## Edge Cases
- Empty stack
- Stack with a single element

## Visual
```
Initial Stack: 5 -> 4 -> 3 -> 2 -> 1 (Top)
Queue after Pop: 1 -> 2 -> 3 -> 4 -> 5
Reversed Stack: 1 -> 2 -> 3 -> 4 -> 5 (Top)
```

## Algorithm
1. Pop elements from the stack and enqueue them into a queue.
2. Dequeue elements from the queue and push them back into the stack.

## Real Code
Refer to `StackWithReverse.cs` for the implementation.

## Big O Complexity
- **Time Complexity**: O(n)
- **Space Complexity**: O(n)