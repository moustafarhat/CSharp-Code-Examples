using System.Text;

namespace DesignPatterns.Structural.Composite;

/// <summary>
/// The common interface lets clients treat a single file and a whole directory tree the same way.
/// </summary>
public interface IFileSystemNode
{
    string Name { get; }

    long SizeInBytes { get; }

    void Render(StringBuilder output, int depth);
}

public sealed class FileNode(string name, long sizeInBytes) : IFileSystemNode
{
    public string Name { get; } = name;

    public long SizeInBytes { get; } = sizeInBytes;

    public void Render(StringBuilder output, int depth) =>
        output.Append(' ', depth * 2).Append(Name).Append(" (").Append(SizeInBytes).AppendLine(" B)");
}

public sealed class DirectoryNode(string name) : IFileSystemNode
{
    private readonly List<IFileSystemNode> _children = [];

    public string Name { get; } = name;

    public IReadOnlyList<IFileSystemNode> Children => _children;

    // A directory's size is the sum of its children, however deeply they are nested.
    public long SizeInBytes => _children.Sum(child => child.SizeInBytes);

    public DirectoryNode Add(IFileSystemNode node)
    {
        _children.Add(node);
        return this;
    }

    public bool Remove(IFileSystemNode node) => _children.Remove(node);

    public void Render(StringBuilder output, int depth)
    {
        output.Append(' ', depth * 2).Append(Name).AppendLine("/");
        foreach (var child in _children)
        {
            child.Render(output, depth + 1);
        }
    }

    public string Render()
    {
        var output = new StringBuilder();
        Render(output, 0);
        return output.ToString();
    }
}
