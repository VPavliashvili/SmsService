using Microsoft.AspNetCore.Mvc;
using SmsService.Models;
using SmsService.Services;
using System.ComponentModel.DataAnnotations;

namespace SmsService.Controllers;

[ApiController]
[Route("[controller]")]
public class SmsController : ControllerBase
{
    private readonly ISmsService _smsService;

    public SmsController(ISmsService smsService)
    {
        _smsService = smsService;
    }

    [HttpPost]
    [ProducesResponseType<SuccessfulDto>(200)]
    [ProducesResponseType<FailedDto>(400)]
    public async Task<IActionResult> SendSms([Required] string mobileNumber, [Required] string text)
    {
        try
        {
            var response = await _smsService.SendSms(mobileNumber, text);

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
