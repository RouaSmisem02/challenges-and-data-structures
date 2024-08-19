using System;
using Xunit;
using TreeImplementation;

public class BinaryTreeTests2
{
    [Fact]
    public void FindSecondMax_ShouldReturnSecondMaxValue()
    {
        // Arrange
        BinarySearchTree bst = new BinarySearchTree();
        bst.Add(10);
        bst.Add(5);
        bst.Add(20);
        bst.Add(3);
        bst.Add(7);
        bst.Add(15);
        bst.Add(25);

        // Act
        int secondMax = bst.FindSecondMax();

        // Assert
        Assert.Equal(20, secondMax);
    }

    [Fact]
    public void FindSecondMax_ShouldThrowException_WhenTreeHasOneNode()
    {
        // Arrange
        BinarySearchTree bst = new BinarySearchTree();
        bst.Add(10);

        // Act & Assert
        Assert.Throws<InvalidOperationException>(() => bst.FindSecondMax());
    }

    [Fact]
    public void FindSecondMax_ShouldHandleNegativeValues()
    {
        // Arrange
        BinarySearchTree bst = new BinarySearchTree();
        bst.Add(-10);
        bst.Add(-20);
        bst.Add(-5);

        // Act
        int secondMax = bst.FindSecondMax();

        // Assert
        Assert.Equal(-10, secondMax);
    }
}
