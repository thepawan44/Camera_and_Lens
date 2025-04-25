using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using UI.Configuration.Extension;
using UI.Shared.EndPointsManager;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddCustomServices(builder.Configuration);
builder.Services.AddHttpClient();
var baseUrl = builder.Configuration["ApiSettings:BaseUrl"];
EndPointsManager.InitializeAllEndPoints(baseUrl);

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
