using SmsService.Models;
using SmsService.Providers;

namespace SmsService.Services;

public class SmsService : ISmsService
{
    private ISmsProvider _smsProvider;

    public SmsService()
    {

    }

    public async Task<SendSmsResponse> SendSms(string mobileNumber, string text)
    {
        var res = await _smsProvider.SensSms(mobileNumber, text);

        return res;
    }
}
