using SyrianProject.DAL;
using Microsoft.EntityFrameworkCore;
using System;

#region Builder

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

var connectionString = builder.Configuration.GetConnectionString("Default");
builder.Services.AddDbContext<AppDbContext>(x => x.UseSqlServer(connectionString));

#endregion

#region App

var app = builder.Build();
//app.MapDefaultControllerRoute();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=medicaldepartment}/{action=index}"
    );
app.UseStaticFiles();
app.Run();

#endregion