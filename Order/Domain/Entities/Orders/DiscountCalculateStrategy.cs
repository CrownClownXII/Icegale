using OrderService.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderService.Domain.Entities.Orders
{
    public class DiscountCalculateStrategy : ICalculateValueStrategy
    {
        public DiscountCalculateStrategy()
        {
            Type = OrderTypeEnum.Discount;
        }

        public OrderTypeEnum Type { get; private set; }

        public decimal CalculateTotalValue(List<decimal> products)
        {
            return (products?.Sum() ?? 0) * 0.9m;
        }
    }
}
