using SmsService.Models;
using SmsService.Providers;

namespace SmsService.Contexts;

public class SmsServiceContext : ISmsServiceContext
{
    private readonly IEnumerable<ISmsProviderStrategy> _strategies;

    public SmsServiceContext(IEnumerable<ISmsProviderStrategy> strategies)
    {
        _strategies = strategies;
    }

    public async Task<SendSmsResponse> SendSms(SendSmsRequest request)
    {
        var strategy = _strategies.SingleOrDefault(x => x.StrategyName == request.RequiredStrategy)
                                ?? throw new InvalidOperationException();

        var provider = strategy.GetProvider(request);

        var res = await provider.SendSms(request.MobileNumber, request.Text);

        return res;
    }
}
