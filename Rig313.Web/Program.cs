using Microsoft.EntityFrameworkCore;
using Rig313.Data;
using Rig313.Data.DataAccess;
using Rig313.Data.IRepository;
using Rig313.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppDbContext>(options
    => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped(typeof(CategoryService), typeof(CategoryService));
builder.Services.AddScoped(typeof(ProductService), typeof(ProductService));
builder.Services.AddScoped(typeof(InventoryService), typeof(InventoryService));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{area=Shop}/{controller=Home}/{action=Index}/{id?}");

app.Run();
