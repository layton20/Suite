using Azure.Identity;
using Microsoft.EntityFrameworkCore;
using Suite.Data;
using Suite.Manager;

WebApplicationBuilder _Builder = WebApplication.CreateBuilder(args);

_Builder.Configuration.AddAzureAppConfiguration(options =>
{
    options.Connect(
        _Builder.Configuration["ConnectionStrings:AppConfig"])
            .ConfigureKeyVault(kv =>
            {
                kv.SetCredential(new DefaultAzureCredential());
            });
});

// Add services to the container.
_Builder.Services.AddRazorPages();

// Add managers
_Builder.Services.AddScoped<ITagManager, TagManager>();

_Builder.Services.AddDbContext<SuiteContext>(options =>
    options.UseSqlServer(_Builder.Configuration.GetConnectionString("SuiteContext") ?? throw new InvalidOperationException("Connection string 'SuiteContext' not found.")));

WebApplication _App = _Builder.Build();

// Configure the HTTP request pipeline.
if (!_App.Environment.IsDevelopment())
{
    _App.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    _App.UseHsts();
}

_App.UseHttpsRedirection();
_App.UseStaticFiles();

_App.UseRouting();

_App.UseAuthorization();

_App.MapRazorPages();

_App.Run();
