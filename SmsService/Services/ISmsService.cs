using SmsService.Models;
using SmsService.Providers;

namespace SmsService.Services;

public interface ISmsService
{
    Task<SendSmsResponse> SendSms(string mobileNumber, string text);
}