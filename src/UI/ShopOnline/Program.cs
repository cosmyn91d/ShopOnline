using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Shop.Core.Business;
using Shop.Core.Business.Services;
using Shop.Core.DomainEntities;
using Shop.Core.DomainEntities.Models;
using Shop.Core.RepositoriesInterface.Interfaces;
using Shop.DAL.RepoSQL;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var connectioString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ShopOnlineDbContext>(options => options.UseSqlite(connectioString));
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/products", ([FromServices] IProductService productService) =>
 {
     return productService.GetAllProducts();
 });

app.MapGet("/products/{id}", ([FromServices] IProductService productService, int id) =>
{
    var product = productService.GetProductById(id);
    return product != null ? Results.Ok(product) : Results.NotFound();
});

app.MapPost("/products/addProduct", ([FromServices] IProductService _productService, [FromBody]ProductAddModel productModel) =>
{
    try
    {
        _productService.AddProduct(productModel);
        return Results.Ok();
    }
    catch (ArgumentException)
    {

        return Results.BadRequest();
    }
});


app.MapPut("/products/editProduct", ([FromServices] IProductService _productService, [FromBody] ProductEditModel product) =>
{
    try
    {
        _productService.EditProduct(product);
        return Results.Ok();
    }
    catch (ArgumentException)
    {

        return Results.BadRequest();
    }
});

app.MapPut("/products/deleteProduct", ([FromServices] IProductService _productService, int productId) =>
{
    try
    {
        _productService.DeleteProduct(productId);
        return Results.Ok();
    }
    catch (ArgumentException)
    {

        return Results.BadRequest();
    }
});

app.Run();

