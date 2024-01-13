using SmsService.Models;

namespace SmsService.Providers;

public interface IProvider
{
    Task<SendSmsResponse> SendSms(string mobile, string text);
}

public class MagtiSmsProvider : IProvider
{
    public Task<SendSmsResponse> SendSms(string mobile, string text)
    {
        return Task.FromResult(new SendSmsResponse()
        {
            IsSuccessful = true,
            Message = $"Message sent successfully to {mobile}\nProvider Magti"
        });
    }
}

public class TwilioSmsProvider : IProvider
{
    public Task<SendSmsResponse> SendSms(string mobile, string text)
    {
        return Task.FromResult(new SendSmsResponse()
        {
            IsSuccessful = true,
            Message = $"Message sent successfully to {mobile}\nProvider Twilio"
        });
    }
}

public class GeocellSmsProvider : IProvider
{
    public Task<SendSmsResponse> SendSms(string mobile, string text)
    {
        return Task.FromResult(new SendSmsResponse()
        {
            IsSuccessful = true,
            Message = $"Message sent successfully to {mobile}\nProvider Geocell"
        });
    }
}