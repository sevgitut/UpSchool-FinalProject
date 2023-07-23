﻿using Application.Common.Interfaces;
using Domain.Dtos;
using Domain.Utilities;
using Microsoft.AspNetCore.SignalR;
using WebApi.Hubs;

namespace WebApi.Services;

public class OrderHubManager : IOrderHubService
{
    private readonly IHubContext<OrderHub> _hubContext;

    public OrderHubManager(IHubContext<OrderHub> hubContext)
    {
        _hubContext = hubContext;
    }

    public Task AddedAsync(OrderDto orderDto, CancellationToken cancellationToken)
    {
        return _hubContext.Clients.All.SendAsync(SignalRMethodKeys.Order.Added, orderDto, cancellationToken);
    }

}