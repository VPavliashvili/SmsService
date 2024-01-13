using SmsService.Models;

namespace SmsService.Contexts;

public interface ISmsServiceContext
{
    Task<SendSmsResponse> SendSms(string mobileNumber, string text, ProviderStrategy requestedStrategy);
}