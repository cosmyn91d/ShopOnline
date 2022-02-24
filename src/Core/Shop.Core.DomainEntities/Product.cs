namespace Shop.Core.DomainEntities;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Code { get; set; } = string.Empty;
    public int CategoryId { get; set; }
    public decimal Price { get; set; }
    public int Stock { get; set; }
    public string Description { get; set; } = string.Empty;
    public DateTime CreateTime { get; set; }
    public DateTime ModifyTime { get; set; }
    public bool IsDisabled { get; set; }
    public bool IsDeleted { get; set; }
    public ICollection<Attachment> Attachments { get; set; } = new List<Attachment>();
}