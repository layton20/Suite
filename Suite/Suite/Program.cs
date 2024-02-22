﻿using Azure.Identity;
using Microsoft.EntityFrameworkCore;
using Suite.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddAzureAppConfiguration(options =>
{
    options.Connect(
        builder.Configuration["ConnectionStrings:AppConfig"])
            .ConfigureKeyVault(kv =>
            {
                kv.SetCredential(new DefaultAzureCredential());
            });
});

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<SuiteContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("SuiteContext") ?? throw new InvalidOperationException("Connection string 'SuiteContext' not found.")));

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
