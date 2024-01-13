namespace SmsService.Models;

public class SendSmsRequest
{
    public required string MobileNumber { get; set; }
    public required string Text { get; set; }

    public ProviderStrategy RequiredStrategy { get; set; }
    public decimal? TargetPercent { get; set; }
}