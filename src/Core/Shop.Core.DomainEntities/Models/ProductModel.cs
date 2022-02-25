﻿namespace Shop.Core.DomainEntities.Models;

public class ProductModel
{
    public string Name { get; set; } = string.Empty;
    public string Code { get; set; } = string.Empty;
    public int CategoryId { get; set; }
    public decimal Price { get; set; }
    public int Stock { get; set; }
    public string Description { get; set; } = string.Empty;

}