# Challenge 05: Find Duplicates

## Problem Domain
Write a function called `FindDuplicates` that accepts an array as its parameter. Without utilizing any of the built-in methods provided by the language, the function should return an array of duplicate values.

### Example
- Input: [1, 2, 3, 1, 2, 3]
  Output: [1, 2, 3]

- Input: [16, 8 ,31, 17, 15, 23, 17, 8]
  Output: [17, 8]

- Input: [5, 10, 16, 20, 10, 16]
  Output: [10, 16]

## Algorithm
The algorithm for finding duplicates in an array iterates through the array and uses a dictionary to count occurrences of each element. If an element appears more than once, it is added to the result array.

### Big O
- Time Complexity: O(n) because we iterate through the array once.
- Space Complexity: O(n) because we create a dictionary to hold the counts.

## Screenshot
![Find-Duplicates](Find Duplicates/Capture.PNG)

### Whiteboard Images

### Challenge 05: Find-Duplicates
[Find-Duplicates](Find Duplicates/Find Duplicates in Array.drawio.png)
