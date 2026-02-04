using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RazorPageWatches.Data;
using RazorPageWatches.Models;
using System;
using System.Globalization;
using Microsoft.AspNetCore.Identity;

// Change culture

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<RazorPageWatchesContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("RazorPageWatchesContext") ?? throw new InvalidOperationException("Connection string 'RazorPageWatchesContext' not found.")));

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<RazorPageWatchesContext>();

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

CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-PH");

app.Run();
