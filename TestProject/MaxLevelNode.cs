using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class MaxLevelNode
    {
        [Fact]
        public void Test_FindMaxLevelNodes_CorrectLevel()
        {
            // Arrange
            BinaryTree tree = new BinaryTree();
            tree.Root = new Node(1);
            tree.Root.Left = new Node(2);
            tree.Root.Right = new Node(3);
            tree.Root.Left.Left = new Node(4);
            tree.Root.Left.Right = new Node(5);
            tree.Root.Right.Right = new Node(6);
            tree.Root.Left.Left.Left = new Node(7);

            // Act
            int result = tree.FindMaxLevelNodes();

            // Assert
            Assert.Equal(2, result);
        }

        [Fact]
        public void Test_FindMaxLevelNodes_MultipleMaxLevels()
        {
            // Arrange
            BinaryTree tree = new BinaryTree();
            tree.Root = new Node(1);
            tree.Root.Left = new Node(2);
            tree.Root.Right = new Node(3);
            tree.Root.Left.Left = new Node(4);
            tree.Root.Left.Right = new Node(5);
            tree.Root.Right.Right = new Node(6);
            tree.Root.Left.Left.Left = new Node(7);
            tree.Root.Left.Left.Right = new Node(8);

            // Act
            int result = tree.FindMaxLevelNodes();

            // Assert
            Assert.Equal(2, result);
        }

        [Fact]
        public void Test_FindMaxLevelNodes_EmptyTree_ThrowsException()
        {
            // Arrange
            BinaryTree tree = new BinaryTree();

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => tree.FindMaxLevelNodes());
        }
    }
}

