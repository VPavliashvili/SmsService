namespace SmsService.Models;

public class SendSmsResponse
{
    public required string Message { get; set; }
    public required bool IsSuccessful { get; set; }
}
