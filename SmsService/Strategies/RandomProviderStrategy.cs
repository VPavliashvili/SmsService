using SmsService.Models;

namespace SmsService.Providers;

public class RandomProviderStrategy : ISmsProviderStrategy
{
    private readonly List<IProvider> _providers;

    public ProviderStrategy StrategyName => ProviderStrategy.Random;

    public RandomProviderStrategy(IEnumerable<IProvider> providers)
    {
        _providers = providers.ToList();
    }

    public IProvider GetProvider()
    {
        var rnd = new Random();
        var index = rnd.Next(0, _providers.Count);
        var res = _providers[index];

        return res;
    }
}
