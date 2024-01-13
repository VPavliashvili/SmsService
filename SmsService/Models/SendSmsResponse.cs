namespace SmsService.Models;

public class SendSmsResponse
{
    public required string Message { get; set; }
    public bool IsSuccessful { get; set; }
}
