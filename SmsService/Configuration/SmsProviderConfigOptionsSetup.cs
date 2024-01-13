using Microsoft.Extensions.Options;
using SmsService.Models;

namespace SmsService.Configuration;

public class SmsProviderConfigOptionsSetup : IConfigureOptions<SmsProviderConfig>
{
    private const string sectionName = nameof(SmsProviderConfig);
    private readonly IConfiguration _configuration;

    public SmsProviderConfigOptionsSetup(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public void Configure(SmsProviderConfig options)
    {
        _configuration.GetSection(sectionName).Bind(options);
    }
}
