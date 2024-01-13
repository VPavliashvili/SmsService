using Microsoft.AspNetCore.Mvc;

namespace SmsService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SmsController : ControllerBase
    {
        [HttpPost]
        public Task<IActionResult> SendSms()
        {
            throw new NotImplementedException();
        }
    }
}
