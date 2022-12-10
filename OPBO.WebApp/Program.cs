using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using OPBO.UseCases.PluginInterfaces;
using OPBO.WebApp.Data;
using OPBO.Plugins.InMemory;
using OPBO.UseCases;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddSingleton<IOrderRepository ,OrderRepository>();
builder.Services.AddTransient<IViewOrdersUseCase, ViewOrdersUseCase>();
builder.Services.AddTransient<IViewOrdersSummaryUseCase, ViewOrdersSummaryUseCase>();
builder.Services.AddTransient<IViewOrderDetailsUseCase, ViewOrderDetailsUseCase>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
