using Ex2022Timurshin320.Data;
using Ex2022Timurshin320.Data.DB;
using Ex2022Timurshin320.Data.Users;
using Ex2022Timurshin320.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddAuthenticationCore();
builder.Services.AddScoped<UserService>();
builder.Services.AddSingleton<FileService>();
builder.Services.AddScoped<AuthStateProvider>();
builder.Services.AddScoped<AuthenticationStateProvider>(provider =>
    provider.GetRequiredService<AuthStateProvider>());

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

BsonClassMap.RegisterClassMap<AppUser>();
DBConnection.users.Indexes.CreateOne(new CreateIndexModel<AppUser>(Builders<AppUser>.IndexKeys.Ascending(x => x.Email), new CreateIndexOptions { Unique = true }));

app.Run();
