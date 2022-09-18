using PizzaTIC.App.Persistencia;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using PizzaTIC.App.Presentacion.Areas.Identity.Data;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("IdentityDataContextConnection") ?? throw new InvalidOperationException("Connection string 'IdentityDataContextConnection' not found.");

builder.Services.AddDbContext<IdentityDataContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<IdentityDataContext>();

// Add services to the container.
builder.Services.AddRazorPages();
//builder.services.AddControllersWithViews();
builder.Services.AddSingleton<IRepositorioInvLineaDeProducto, RepositorioInvLineaDeProducto>();
builder.Services.AddSingleton<IRepositorioPizza, RepositorioPizza>();
builder.Services.AddSingleton<IRepositorioIngrediente, RepositorioIngrediente>();
builder.Services.AddSingleton<IRepositorioComidaTamano, RepositorioComidaTamano>();
builder.Services.AddSingleton<IRepositorioCombo, RepositorioCombo>();
builder.Services.AddSingleton<IRepositorioCliente, RepositorioCliente>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
//middleware applications
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();;

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();
