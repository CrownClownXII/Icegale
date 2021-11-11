using OrderService.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderService.Domain.Entities.Orders
{
    public class SimpleCalculateValueStrategy : ICalculateValueStrategy
    {
        public SimpleCalculateValueStrategy()
        {
            Type = OrderTypeEnum.Simple;
        }

        public OrderTypeEnum Type { get; private set; }

        public decimal CalculateTotalValue(List<decimal> products)
        {
            return products?.Sum() ?? 0;
        }
    }
}
