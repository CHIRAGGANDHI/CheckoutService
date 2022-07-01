using Checkout.Application.Models;

namespace Checkout.Application.Contracts.Infrastructure;

public interface IEmailService
{
    Task<bool> SendEmail(Email email);
}
