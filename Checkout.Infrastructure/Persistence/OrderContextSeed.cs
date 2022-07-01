using Checkout.Domain.Entities;
using Microsoft.Extensions.Logging;

namespace Checkout.Infrastructure.Persistence;

public class OrderContextSeed
{
    public static async Task SeedAsync(OrderContext orderContext, ILogger<OrderContextSeed> logger)
    {
        if (!orderContext.Orders.Any())
        {
            orderContext.Orders.AddRange(GetPreconfiguredOrders());
            await orderContext.SaveChangesAsync();
            logger.LogInformation("Seed database associated with context {DbContextName}", typeof(OrderContext).Name);
        }
    }

    private static IEnumerable<Order> GetPreconfiguredOrders()
    {
        return new List<Order>
        {
            new Order() {
                UserName = "gandhick",
                FirstName = "Chirag",
                LastName = "Gandhi",
                EmailAddress = "gandhi.ck@gmail.com",
                AddressLine = "Bangalore",
                Country = "India",
                TotalPrice = 350 }
        };
    }
}
