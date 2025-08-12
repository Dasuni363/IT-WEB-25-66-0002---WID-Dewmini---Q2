using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Q2__WID_Dewmini.Data;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<Q2__WID_DewminiContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Q2__WID_DewminiContext") ?? throw new InvalidOperationException("Connection string 'Q2__WID_DewminiContext' not found.")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
