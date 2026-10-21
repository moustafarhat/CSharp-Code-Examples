namespace DesignPatterns.Creational.Prototype;

/// <summary>
/// A registry of pre-configured prototypes. New customers are created by cloning
/// a template instead of repeating its setup.
/// </summary>
public sealed class CustomerTemplates
{
    private readonly Dictionary<string, Customer> _templates = new(StringComparer.OrdinalIgnoreCase);

    public void Register(Customer template) => _templates[template.Type] = template;

    public Customer Create(string type) =>
        _templates.TryGetValue(type, out var template)
            ? template.Clone()
            : throw new KeyNotFoundException($"No customer template is registered for '{type}'.");
}
