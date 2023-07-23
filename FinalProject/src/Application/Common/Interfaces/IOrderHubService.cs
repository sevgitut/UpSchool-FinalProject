using Domain.Dtos;

namespace Application.Common.Interfaces;

public interface IOrderHubService
{
    Task AddedAsync(OrderDto orderDto, CancellationToken cancellationToken);

   
}