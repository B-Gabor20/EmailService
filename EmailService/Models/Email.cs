namespace EmailService.Models
{
    public class Email
    {
        public Guid id { get; set; }
        public string To { get; set; } = null!;
        public string Body { get; set; } = null!;
    }
}
