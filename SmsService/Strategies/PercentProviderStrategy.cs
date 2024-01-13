using Microsoft.Extensions.Options;
using SmsService.Models;

namespace SmsService.Providers;

public class PercentProviderStrategy : ISmsProviderStrategy
{
    public ProviderStrategy StrategyName => ProviderStrategy.Percent;

    private readonly SmsProviderConfig _config;
    private readonly IEnumerable<IProvider> _providers;

    public PercentProviderStrategy(IOptions<SmsProviderConfig> options, IEnumerable<IProvider> providers)
    {
        _config = options.Value;
        _providers = providers;
    }

    public IProvider GetProvider(SendSmsRequest request)
    {
        var cfg = _config.Providers.FirstOrDefault(x => x.Percent == request.TargetPercent);

        if (cfg is null)
        {
            var msg = $"provider with requested percent value -> {request.TargetPercent} is not specified";
            throw new InvalidOperationException(msg);
        }

        var res = _providers.FirstOrDefault(x => x.Name == cfg.Name)!;

        return res;
    }
}
