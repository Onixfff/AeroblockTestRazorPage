using Aeroblock.DataAccess.Rail.Interface;
using Microsoft.EntityFrameworkCore;
using Aeroblock.DataAccess.Rail.Repositories;
using Aeroblock.DataAccess.Rail;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var connectionString = builder.Configuration.GetConnectionString("local");

builder.Services.AddDbContext<RailDbContext>(
    options =>
    {
        options.UseMySql(connectionString, new MySqlServerVersion(new Version(8,0,36)));
        options.LogTo(Console.WriteLine, LogLevel.Information).EnableSensitiveDataLogging().EnableDetailedErrors();
    });

builder.Services.AddScoped<IMainPageRepository, MainPageRepository>();
builder.Services.AddScoped<IResettingSilos, ResettingSilosRepository>();

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
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
