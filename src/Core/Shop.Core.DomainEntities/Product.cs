namespace Shop.Core.DomainEntities;

public class Product : EntityBase
{
    public string Name { get; set; } = string.Empty;
    public string Code { get; set; } = string.Empty;
    public int CategoryId { get; set; }
    public decimal Price { get; set; }
    public int Stock { get; set; }
    public string Description { get; set; } = string.Empty;
    public DateTime CreateTime { get; set; } = DateTime.Now;
    public DateTime ModifyTime { get; set; } = DateTime.Now;
    public bool IsDisabled { get; set; } = false;
    public bool IsDeleted { get; set; } = false;
    public ICollection<Attachment> Attachments { get; set; } = new List<Attachment>();
}