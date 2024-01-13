namespace SmsService.Models;

public class SmsProviderConfig
{
    public required IEnumerable<ProviderCfg> Providers { get; set; }

    public class ProviderCfg
    {
        public required ProviderName Name { get; set; }
        public required decimal Percent { get; set; }
    }
}
