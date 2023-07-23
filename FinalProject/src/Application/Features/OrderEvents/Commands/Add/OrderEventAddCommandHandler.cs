using Application.Common.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.OrderEvents.Commands.Add
{
    public class OrderEventAddCommandHandler
    {
        private readonly IApplicationDbContext _dbContext;

        public OrderEventAddCommandHandler(IApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Handle(OrderEventAddCommand command)
        {
            var orderEvent = new OrderEvent
            {
                OrderId = command.OrderId,
                Status = command.Status
            };

            _dbContext.OrderEvents.Add(orderEvent);
            _dbContext.SaveChanges();
        }
    }
}