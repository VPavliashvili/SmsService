using SmsService.Models;

namespace SmsService.Providers;

public interface ISmsProvider
{
    Task<SendSmsResponse> SensSms(string mobile, string text);
}

public class RandomProvider : ISmsProvider
{
    public Task<SendSmsResponse> SensSms(string mobile, string text)
    {
        throw new NotImplementedException();
    }
}

public class PercentProvider : ISmsProvider
{
    public Task<SendSmsResponse> SensSms(string mobile, string text)
    {
        throw new NotImplementedException();
    }
}