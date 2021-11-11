using OrderService.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderService.Domain.Entities.Orders
{
    public interface ICalculateValueStrategy
    {
        OrderTypeEnum Type { get;  }
        decimal CalculateTotalValue(List<decimal> products);
    }
}
