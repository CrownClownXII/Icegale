using OrderService.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderService.Domain.Entities.Orders
{
    public partial class Order
    {
        public List<decimal> Products { get; set; }
        public OrderTypeEnum OrderType { get; set; }
    }
}
