using SmsService.Models;

namespace SmsService.Providers;

public interface ISmsProviderStrategy
{
    ProviderStrategy Name { get; }
    Task<SendSmsResponse> SendSms(string mobile, string text);
}

public class RandomProviderStrategy : ISmsProviderStrategy
{
    public ProviderStrategy Name => ProviderStrategy.Random;

    public Task<SendSmsResponse> SendSms(string mobile, string text)
    {
        throw new NotImplementedException();
    }
}

public class PercentProviderStrategy : ISmsProviderStrategy
{
    public ProviderStrategy Name => ProviderStrategy.Percent;

    public Task<SendSmsResponse> SendSms(string mobile, string text)
    {
        throw new NotImplementedException();
    }
}

public class OtherProviderStrategy : ISmsProviderStrategy
{
    public ProviderStrategy Name => ProviderStrategy.Other;

    public Task<SendSmsResponse> SendSms(string mobile, string text)
    {
        throw new NotImplementedException();
    }
}