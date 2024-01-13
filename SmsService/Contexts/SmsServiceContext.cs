using SmsService.Models;
using SmsService.Providers;

namespace SmsService.Contexts;

public class SmsServiceContext : ISmsServiceContext
{
    private readonly IEnumerable<ISmsProviderStrategy> _providers = [];

    public SmsServiceContext(IEnumerable<ISmsProviderStrategy> providers)
    {
        _providers = providers;
    }

    public async Task<SendSmsResponse> SendSms(string mobileNumber, string text, ProviderStrategy requestedStrategy)
    {
        var strategy = _providers.SingleOrDefault(x => x.Name == requestedStrategy)
                                ?? throw new NullReferenceException();

        var res = await strategy.SendSms(mobileNumber, text);

        return res;
    }
}
