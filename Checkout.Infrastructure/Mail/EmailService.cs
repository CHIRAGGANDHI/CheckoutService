using Checkout.Application.Contracts.Infrastructure;
using Checkout.Application.Models;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Checkout.Infrastructure.Mail;

public class EmailService : IEmailService
{
    public EmailSettings _emailSettings { get; }
    public ILogger<EmailService> _logger { get; }

    public EmailService(IOptions<EmailSettings> mailSettings, ILogger<EmailService> logger)
    {
        _emailSettings = mailSettings.Value;
        _logger = logger;
    }

    public async Task<bool> SendEmail(Email email)
    {
        _logger.LogInformation("Email sent.");
        return await Task.FromResult(true);
    }
}
