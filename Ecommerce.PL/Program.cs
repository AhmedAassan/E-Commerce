using Ecommerce.BL.Interface;
using Ecommerce.BL.Mapper;
using Ecommerce.BL.Repository;
using Ecommerce.DAL.Database;
using Microsoft.EntityFrameworkCore;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


builder.Services.AddAutoMapper(x => x.AddProfile(new DomainProfile())); // Mapper

//connectionstring
builder.Services.AddDbContext<ProductContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("ProductContext")); // Connection String
});

builder.Services.AddScoped<IProductRep, ProductRep>();  //Dependancy Injaction => Ctor
builder.Services.AddScoped<IOrderRep, OrderRep>();  //Dependancy Injaction => Ctor
builder.Services.AddScoped<ICustomerRep, CustomerRep>();  //Dependancy Injaction => Ctor
builder.Services.AddScoped<IOrderProductRep, OrderProductRep>();  //Dependancy Injaction => Ctor

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
