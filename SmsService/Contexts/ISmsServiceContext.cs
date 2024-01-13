using SmsService.Models;

namespace SmsService.Contexts;

public interface ISmsServiceContext
{
    Task<SendSmsResponse> SendSms(SendSmsRequest request);
}