using DataAccessLayer.Actions;
using DataAccessLayer.Services;
using DataAccessLayer.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IFilmService, FilmService>();
builder.Services.AddScoped<IYFilmService, YFilmService>();
builder.Services.AddScoped<IYakinService, YakinService>();
builder.Services.AddScoped<IFilmTurService, FilmTurService>();
builder.Services.AddScoped<IDiziService, DiziService>();
builder.Services.AddScoped<IDiziTurService, DiziTurService>();
builder.Services.AddDbContext<watchDbContext>();

builder.Services.AddHttpContextAccessor();
builder.Services.AddSession();

// Build the application.
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Home/Error");
	app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.UseSession();

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Main}/{action=Index}/{id?}");

// Run the application.
app.Run();
