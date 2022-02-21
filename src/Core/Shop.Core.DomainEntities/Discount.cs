using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.DomainEntities
{
    public class Discount
    {
        public int Id { get; set; }
        public decimal Value { get; set; }
        public int DiscountTypeId { get; set; }
    }
}
