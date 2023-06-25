using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using portfolio_web_app.Data;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);


ConfigurationBuilder configurationBuilder = new ConfigurationBuilder();
IConfiguration configuration = configurationBuilder.AddUserSecrets<Program>().Build();
string dbToken = configuration.GetSection("ConnectionStrings")["portfolioDBConnectionString"];



// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<portfolio_web_appContext>(options =>
     options.UseSqlServer(builder.Configuration.GetConnectionString("portfolioDBConnectionString")));

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

app.UseAuthorization();

app.MapRazorPages();

app.Run();
