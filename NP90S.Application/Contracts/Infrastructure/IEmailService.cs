using NP90S.Application.Models.Mail;

namespace NP90S.Application.Contracts.Infrastructure
{
    public interface IEmailService
    {
        Task<bool> SendEmail(Email email);
    }
}
