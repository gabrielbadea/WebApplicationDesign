using AspNetCoreServicesRepositoryApp.Models;
using AspNetCoreServicesRepositoryApp.Repositories.Interfaces;
using AspNetCoreServicesRepositoryApp.Repositories;
using AspNetCoreServicesRepositoryApp.Services.Interfaces;
using AspNetCoreServicesRepositoryApp.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<ILocationRepository, LocationRepository>();
builder.Services.AddScoped<ILocationService, LocationService>();
builder.Services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();

builder.Services.AddDbContext<LocationContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("LocationDb")));

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
    pattern: "{controller=Location}/{action=Index}/{id?}");

app.MapControllers();

app.Run();
