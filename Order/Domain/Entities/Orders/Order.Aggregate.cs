using OrderService.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderService.Domain.Entities.Orders
{
    public partial class Order
    {
        public Order(List<decimal> products)
        {
            Products = products;
        }

        public decimal CalculateTotalValue()
        {
            return ResolveStrategy().CalculateTotalValue(Products);
        }

        private ICalculateValueStrategy ResolveStrategy()
        {
            if(OrderType == OrderTypeEnum.Simple)
            {
                return new SimpleCalculateValueStrategy();
            }

            if(OrderType == OrderTypeEnum.Discount)
            {
                return new DiscountCalculateStrategy();
            }

            throw new Exception("Non existing strategy");
        }
    }
}
