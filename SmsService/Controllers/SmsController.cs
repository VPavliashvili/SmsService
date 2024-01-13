using Microsoft.AspNetCore.Mvc;
using SmsService.Contexts;
using SmsService.Models;

namespace SmsService.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
public class SmsController : ControllerBase
{
    private readonly ISmsServiceContext _smsService;

    public SmsController(ISmsServiceContext smsService)
    {
        _smsService = smsService;
    }

    [HttpPost]
    [ProducesResponseType<SuccessfulResponseDto>(200)]
    [ProducesResponseType<FailedResponseDto>(400)]
    public async Task<IActionResult> Send(SendSmsRequest request)
    {
        try
        {
            var response = await _smsService.SendSms(request);

            var result = new SuccessfulResponseDto()
            {
                Message = response.Message,
            };

            return Ok(result);
        }
        catch (Exception ex)
        {
            var err = new FailedResponseDto()
            {
                ErrorMessage = ex.Message,
            };
            return BadRequest(err);
        }
    }
}
