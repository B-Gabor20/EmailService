using EmailService.Models.Dtos;
using EmailService.Service.IEmailS;
using Microsoft.AspNetCore.Mvc;
using MimeKit.Text;

namespace EmailService.Controllers
{
    [ApiController]
    [Route("email")]
    public class EmailController : ControllerBase
    {
        private readonly IEmailService emailService;
        public EmailController(IEmailService emailService)
        {
            this.emailService = emailService;
        }
        [HttpPost]
        public IActionResult SendEmail(EmailDto request)
        {
            emailService.SendEmail(request);
            return StatusCode(200, "Levél elküldve");
        }
    }
}
