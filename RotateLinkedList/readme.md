## Problem Domain
Rotate a singly linked list by k positions to the left, meaning that after rotating, the node which was originally at position k will become the head of the list, and the remaining nodes will follow.

## Inputs and Expected Outputs
**Input 1:**
Linked List: 1 -> 2 -> 3 -> 4 -> 5 -> 6 -> Null
**k = 2**
**Output:** 3 -> 4 -> 5 -> 6 -> 1 -> 2 -> Null
**Input 2:**
Linked List: 10 -> 20 -> 30 -> 40 -> 50 -> Null
**k = 3**
**Output:** 40 -> 50 -> 10 -> 20 -> 30 -> Null
**Input 3:**
Linked List: 5 -> 10 -> 15 -> 20 -> Null
k = 1
**Output:** 10 -> 15 -> 20 -> 5 -> Null

## Edge Cases
k = 0: The list remains unchanged.
k > length of the list: Use modulo operation (k % length) to handle the case where k exceeds the length of the list.
Empty List: If the linked list is empty, no rotation should occur.

## Visual
**Before Rotation ```(k = 2)```:**
```Head -> 1 -> 2 -> 3 -> 4 -> 5 -> 6 -> Null``

**After Rotation ```(k = 2)```:**
```Head -> 3 -> 4 -> 5 -> 6 -> 1 -> 2 -> Null```

## Algorithm
1. Calculate Length: Traverse the list to find its length.
2. Connect Tail to Head: Make the linked list circular by connecting the last node to the head.
3. Find New Head: Move to the (length - k)th node.
4. Update Head: Make the next node the new head, and break the circular connection.

## Real Code
```
public void RotateLeft(int k)
{
    if (head == null || k == 0) return;

    // Step 1: Calculate the length of the linked list
    Node current = head;
    int length = 1;
    while (current.next != null)
    {
        current = current.next;
        length++;
    }

    // Step 2: Make the list circular
    current.next = head;

    // Step 3: Find the new head
    k = k % length;
    for (int i = 0; i < length - k; i++)
    {
        current = current.next;
    }

    // Step 4: Set new head and break the circular connection
    head = current.next;
    current.next = null;
}
```

## Big O Time/Space Complexity
1. Time Complexity: O(n) — We traverse the list to calculate its length, and then another traversal to rotate the list.
2. Space Complexity: O(1) — We only use a few pointers, no additional data structures are required.
