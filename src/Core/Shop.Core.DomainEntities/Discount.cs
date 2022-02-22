namespace Shop.Core.DomainEntities;
    public class Discount
    {
        public int Id { get; set; }
        public decimal Value { get; set; }
        public int DiscountTypeId { get; set; }
    }

