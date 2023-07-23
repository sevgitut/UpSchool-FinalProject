
using Domain.Enums;

namespace Application.Features.Orders.Queries.GetAll
{
    public class OrderEventGetAllDto
    {
        public Guid Id { get; set; }
        public string UserId { get; set; }
        public int RequestedAmount { get; set; }
        public int TotalFoundAmount { get; set; }
        public ProductCrawlType ProductCrawlType { get; set; }
        public DateTimeOffset CreatedOn { get; set; }
        public string? CreatedByUserId { get; set; }
        public Guid OrderId { get; set; }
        public OrderStatus Status { get; set; }
        public bool IsDeleted { get; set; }
    }
}