using TreeImplementation;
using Xunit;

public class BinaryTreeTests
{
    [Fact]
    public void TestPreOrderTraversal()
    {
        BinaryTree tree = new BinaryTree();
        tree.Root = new Node(1);
        tree.Root.Left = new Node(2);
        tree.Root.Right = new Node(3);

        using (var sw = new StringWriter())
        {
            Console.SetOut(sw);
            tree.PreOrder(tree.Root);
            var result = sw.ToString().Trim();
            Assert.Equal("1 2 3", result);
        }
    }

    [Fact]
    public void TestInOrderTraversal()
    {
        BinaryTree tree = new BinaryTree();
        tree.Root = new Node(1);
        tree.Root.Left = new Node(2);
        tree.Root.Right = new Node(3);

        using (var sw = new StringWriter())
        {
            Console.SetOut(sw);
            tree.InOrder(tree.Root);
            var result = sw.ToString().Trim();
            Assert.Equal("2 1 3", result);
        }
    }

    [Fact]
    public void TestPostOrderTraversal()
    {
        BinaryTree tree = new BinaryTree();
        tree.Root = new Node(1);
        tree.Root.Left = new Node(2);
        tree.Root.Right = new Node(3);

        using (var sw = new StringWriter())
        {
            Console.SetOut(sw);
            tree.PostOrder(tree.Root);
            var result = sw.ToString().Trim();
            Assert.Equal("2 3 1", result);
        }
    }
}

public class BinarySearchTreeTests
{
    [Fact]
    public void TestAddNode()
    {
        BinarySearchTree bst = new BinarySearchTree();
        bst.Add(10);
        bst.Add(5);
        bst.Add(15);

        Assert.True(bst.Contains(10));
        Assert.True(bst.Contains(5));
        Assert.True(bst.Contains(15));
    }

    [Fact]
    public void TestContainsNode()
    {
        BinarySearchTree bst = new BinarySearchTree();
        bst.Add(10);
        bst.Add(5);
        bst.Add(15);

        Assert.True(bst.Contains(5));
        Assert.False(bst.Contains(20));
    }

    [Fact]
    public void TestRemoveNode()
    {
        BinarySearchTree bst = new BinarySearchTree();
        bst.Add(10);
        bst.Add(5);
        bst.Add(15);

        bst.Remove(5);
        Assert.False(bst.Contains(5));
    }
}
