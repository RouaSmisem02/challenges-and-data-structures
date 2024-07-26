# Stack and Queue Implementation

## Table of Contents
- [Problem Domain](#problem-domain)
- [Inputs and Expected Outputs](#inputs-and-expected-outputs)
- [Edge Cases](#edge-cases)
- [Algorithm](#algorithm)
- [Solution](#solution)
- [Example Console Output](#example-console-output)
- [Big O Time/Space Complexity](#big-o-time-space-complexity)
- [Unit Tests](#unit-tests)
- [Submission Requirements](#submission-requirements)

## Problem Domain
Implement basic stack and queue data structures in C#.

### Stack Implementation
The `Stack` class should support methods to:
- `Push(int data)`: Add a node with the specified data to the top of the stack.
- `Pop()`: Remove and return the top node from the stack.
- `Peek()`: Return the top node from the stack without removing it.
- `IsEmpty()`: Check if the stack is empty.

### Queue Implementation
The `Queue` class should support methods to:
- `Enqueue(int data)`: Add a node with the specified data to the end of the queue.
- `Dequeue()`: Remove and return the front node from the queue.
- `Peek()`: Return the front node from the queue without removing it.
- `IsEmpty()`: Check if the queue is empty.

## Inputs and Expected Outputs
### Stack
- **Input**: `Push(10)`, `Push(5)`, `Pop()`, `Peek()`
- **Expected Output**: `10` (from `Pop()`), `5` (from `Peek()`), `IsEmpty()` should return `false`.

### Queue
- **Input**: `Enqueue(10)`, `Enqueue(5)`, `Dequeue()`, `Peek()`
- **Expected Output**: `10` (from `Dequeue()`), `5` (from `Peek()`), `IsEmpty()` should return `false`.

## Edge Cases
- Attempting to `Pop` or `Peek` from an empty stack should throw an exception.
- Attempting to `Dequeue` or `Peek` from an empty queue should throw an exception.

## Algorithm
### Stack
1. **Push**: Create a new node. Set its next reference to the current top node. Update the top node to be the new node.
2. **Pop**: Check if the stack is empty. If not, store the top node's data. Update the top node to the next node. Return the stored data.
3. **Peek**: Check if the stack is empty. If not, return the top node's data.
4. **IsEmpty**: Check if the top node is null.

### Queue
1. **Enqueue**: Create a new node. If the rear is null, set both the front and rear to the new node. Otherwise, set the rear node's next reference to the new node and update the rear to the new node.
2. **Dequeue**: Check if the queue is empty. If not, store the front node's data. Update the front node to the next node. If the front node is null, set the rear to null. Return the stored data.
3. **Peek**: Check if the queue is empty. If not, return the front node's data.
4. **IsEmpty**: Check if the front node is null.

## Big O Time/Space Complexity
### Stack
Push: O(1) time, O(1) space
Pop: O(1) time, O(1) space
Peek: O(1) time, O(1) space
IsEmpty: O(1) time, O(1) space
### Queue
Enqueue: O(1) time, O(1) space
Dequeue: O(1) time, O(1) space
Peek: O(1) time, O(1) space
IsEmpty: O(1) time, O(1) space
## Solution
### Node Class
```csharp
public class Node
{
    public int Data { get; set; }
    public Node NextNode { get; set; }

    public Node(int data)
    {
        Data = data;
        NextNode = null;
    }
}
