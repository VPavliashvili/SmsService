using SmsService.Models;

namespace SmsService.Providers;

public interface IProvider
{
    Task<SendSmsResponse> SendSms(string mobile, string text);
    ProviderName Name { get; }
}
