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

    [Fact]
    public void TestLeafSumWithPositiveValues()
    {
        BinaryTree Btree = new BinaryTree();
        Btree.Root = new Node(9);
        Btree.Root.Left = new Node(8);
        Btree.Root.Right = new Node(12);
        Btree.Root.Left.Left = new Node(3);
        Btree.Root.Left.Right = new Node(7);
        Btree.Root.Right.Left = new Node(17);
        Btree.Root.Right.Right = new Node(23);
        Btree.Root.Left.Left.Right = new Node(4);

        int result = Btree.SumOfLeafNodes();

        Assert.Equal(51, result);
    }

    [Fact]
    public void TestLeafSumWithNegativeValues()
    {
        BinaryTree Btree = new BinaryTree();
        Btree.Root = new Node(-9);
        Btree.Root.Left = new Node(-8);
        Btree.Root.Right = new Node(-12);
        Btree.Root.Left.Left = new Node(-3);
        Btree.Root.Left.Right = new Node(-7);
        Btree.Root.Right.Left = new Node(-17);
        Btree.Root.Right.Right = new Node(-23);
        Btree.Root.Left.Left.Right = new Node(-4);

        int result = Btree.SumOfLeafNodes();

        Assert.Equal(-51, result);
    }
}