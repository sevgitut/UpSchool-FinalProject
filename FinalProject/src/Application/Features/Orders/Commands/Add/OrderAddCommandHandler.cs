using Application.Common.Interfaces;
using Domain.Common;
using Domain.Entities;
using MediatR;

namespace Application.Features.Orders.Commands.Add
{
    public class OrderAddCommandHandler : IRequestHandler<OrderAddCommand, Response<Guid>>
    {
        private readonly IApplicationDbContext _applicationDbContext;
        private readonly ICurrentUserService _currentUserService;

        public OrderAddCommandHandler(IApplicationDbContext applicationDbContext, ICurrentUserService currentUserService = null)
        {
            _applicationDbContext = applicationDbContext;
            _currentUserService = currentUserService;
        }

        public async Task<Response<Guid>> Handle(OrderAddCommand request, CancellationToken cancellationToken)
        {
            var order = new Order()
            {
                Id = request.Id,
                RequestedAmount = request.RequestedAmount,
                TotalFoundAmount = request.TotalFoundAmount,
                UserId = _currentUserService.UserId,
                ProductCrawlType = request.ProductCrawlType,
            };

            await _applicationDbContext.Orders.AddAsync(order, cancellationToken);
            await _applicationDbContext.SaveChangesAsync(cancellationToken);

            return new Response<Guid>("The new product was successfully added to the db.", order.Id);
        }
    }
}