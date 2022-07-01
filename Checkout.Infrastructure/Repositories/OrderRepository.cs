using Checkout.Application.Contracts.Persistence;
using Checkout.Domain.Entities;
using Checkout.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Checkout.Infrastructure.Repositories;

public class OrderRepository : RepositoryBase<Order>, IOrderRepository
{
    public OrderRepository(OrderContext dbContext) : base(dbContext)
    {
    }

    public async Task<IEnumerable<Order>> GetOrdersByUserName(string userName)
    {
        var orderList = await _dbContext.Orders
                            .Where(o => o.UserName == userName)
                            .ToListAsync();
        return orderList;
    }
}
