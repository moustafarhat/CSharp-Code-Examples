using System.Collections.Concurrent;

using DesignPatterns.Creational.Singleton;

namespace DesignPatterns.Tests.Creational;

public class SingletonTests
{
    [Fact]
    public void Instance_always_returns_the_same_object()
    {
        Assert.Same(SequenceGenerator.Instance, SequenceGenerator.Instance);
    }

    [Fact]
    public async Task Concurrent_callers_share_one_instance_and_never_get_duplicate_numbers()
    {
        var instances = new ConcurrentBag<SequenceGenerator>();
        var numbers = new ConcurrentBag<long>();

        await Task.WhenAll(Enumerable.Range(0, 50).Select(_ => Task.Run(() =>
        {
            var generator = SequenceGenerator.Instance;
            instances.Add(generator);
            for (var i = 0; i < 100; i++)
            {
                numbers.Add(generator.Next());
            }
        })));

        Assert.Single(instances.Distinct());
        Assert.Equal(numbers.Count, numbers.Distinct().Count());
    }
}
