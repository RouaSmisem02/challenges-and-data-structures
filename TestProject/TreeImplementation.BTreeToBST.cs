using Xunit;
using System.Collections.Generic;

namespace TreeImplementation.BTreeToBST.Tests
{
    public class BinaryTreeTests
    {
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

            // Expected in-order sequence after conversion
            List<int> expected = new List<int> { 5, 10, 20, 30, 35, 40, 50, 60 };
            List<int> result = new List<int>();
            Btree.InOrderTraversal(Btree.Root, result);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void ConvertToBST_ShouldHandleSingleNodeTree()
        {
            BinaryTree Btree = new BinaryTree();
            Btree.Root = new Node(42);

            Btree.ConvertToBST();

            Assert.Equal(42, Btree.Root.Value);
        }

        [Fact]
        public void ConvertToBST_ShouldHandleLeftSkewedTree()
        {
            BinaryTree Btree = new BinaryTree();
            Btree.Root = new Node(10);
            Btree.Root.Left = new Node(20);
            Btree.Root.Left.Left = new Node(30);

            Btree.ConvertToBST();

            List<int> result = new List<int>();
            Btree.InOrderTraversal(Btree.Root, result);

            Assert.Equal(new List<int> { 10, 20, 30 }, result);
        }
    }
}
