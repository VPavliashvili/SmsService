using SmsService.Models;

namespace SmsService.Providers;

public class TwilioSmsProvider : IProvider
{
    public ProviderName Name => ProviderName.Twilio;

    public Task<SendSmsResponse> SendSms(string mobile, string text)
    {
        return Task.FromResult(new SendSmsResponse()
        {
            IsSuccessful = true,
            Message = $"Message sent successfully to {mobile}\nProvider {Name}"
        });
    }
}
