using DesignPatterns.Structural.Composite;

namespace DesignPatterns.Tests.Structural;

public class CompositeTests
{
    private static DirectoryNode CreateTree() =>
        new DirectoryNode("project")
            .Add(new FileNode("README.md", 100))
            .Add(new DirectoryNode("src")
                .Add(new FileNode("Program.cs", 250))
                .Add(new DirectoryNode("empty")));

    [Fact]
    public void A_file_and_a_directory_are_used_through_the_same_interface()
    {
        IFileSystemNode[] nodes = [new FileNode("a.txt", 10), CreateTree()];

        Assert.Equal(360, nodes.Sum(node => node.SizeInBytes));
    }

    [Fact]
    public void Directory_size_includes_nested_children()
    {
        Assert.Equal(350, CreateTree().SizeInBytes);
    }

    [Fact]
    public void Removing_a_child_updates_the_size()
    {
        var tree = CreateTree();

        tree.Remove(tree.Children[0]);

        Assert.Equal(250, tree.SizeInBytes);
    }

    [Fact]
    public void Render_draws_the_whole_tree()
    {
        var expected = string.Join(Environment.NewLine,
            "project/",
            "  README.md (100 B)",
            "  src/",
            "    Program.cs (250 B)",
            "    empty/",
            string.Empty);

        Assert.Equal(expected, CreateTree().Render());
    }
}
