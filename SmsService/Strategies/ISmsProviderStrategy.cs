using SmsService.Models;

namespace SmsService.Providers;

public interface ISmsProviderStrategy
{
    ProviderStrategy StrategyName { get; }
    IProvider GetProvider(SendSmsRequest request);
}
