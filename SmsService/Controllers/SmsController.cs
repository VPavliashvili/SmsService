using Microsoft.AspNetCore.Mvc;
using SmsService.Models;
using SmsService.Contexts;
using System.ComponentModel.DataAnnotations;

namespace SmsService.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
public class SmsController : ControllerBase
{
    private readonly ISmsServiceContext _smsService;

    public SmsController(ISmsServiceContext smsServiceStrategy)
    {
        _smsService = smsServiceStrategy;
    }

    [HttpPost]
    [ProducesResponseType<SuccessfulDto>(200)]
    [ProducesResponseType<FailedDto>(400)]
    public async Task<IActionResult> Send([Required] string mobileNumber, [Required] string text, ProviderStrategy providerStrategy)
    {
        try
        {
            var response = await _smsService.SendSms(mobileNumber, text, providerStrategy);

            var result = new SuccessfulDto()
            {
                Message = response.Message,
            };

            return Ok(result);
        }
        catch (Exception ex)
        {
            var err = new FailedDto()
            {
                ErrorMessage = ex.Message,
            };
            return BadRequest(err);
        }
    }
}
