using EmailService.Models.Dtos;

namespace EmailService.Service.IEmailS
{
    public interface IEmailService
    {
        void SendEmail(EmailDto request);
    }
}
