﻿namespace Domain.Dtos
{
    public class ProductDto
    {
        public Guid Id { get; set; }
        public Guid OrderId { get; set; }
        public string Name { get; set; }
        public string Picture { get; set; }
        public bool IsOnSale { get; set; }
        public decimal Price { get; set; }
        public decimal SalePrice { get; set; }

        public ProductDto(Guid id, Guid orderId, string name, string pictureUrl, decimal salePrice, decimal price,
        bool ısOnSale)
        {
            Id = id;
            OrderId = orderId;
            Name = name;
            Picture = pictureUrl;
            SalePrice = salePrice;
            Price = price;
        }
    }
}
