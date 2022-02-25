namespace Shop.UI.Interface.Models;

public class ProductEditModel
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Code { get; set; } = string.Empty;
    public int CategoryId { get; set; }
    public decimal Price { get; set; }
    public int Stock { get; set; }
    public string Description { get; set; } = string.Empty;
    public bool IsDisabled { get; set; } = false;
    public bool IsDeleted { get; set; } = false;
}