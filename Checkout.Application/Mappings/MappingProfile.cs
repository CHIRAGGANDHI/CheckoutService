using AutoMapper;
using Checkout.Application.Features.Orders.Commands.CheckoutOrder;
using Checkout.Application.Features.Orders.Queries.GetOrdersList;
using Checkout.Domain.Entities;

namespace Checkout.Application.Mappings;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Order, OrdersVm>().ReverseMap();
        CreateMap<Order, CheckoutOrderCommand>().ReverseMap();
    }
}
