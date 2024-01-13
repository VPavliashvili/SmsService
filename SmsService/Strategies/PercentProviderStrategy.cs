using SmsService.Models;

namespace SmsService.Providers;

public class PercentProviderStrategy : ISmsProviderStrategy
{
    public ProviderStrategy StrategyName => ProviderStrategy.Percent;

    public IProvider GetProvider()
    {
        throw new NotImplementedException();
    }
}
