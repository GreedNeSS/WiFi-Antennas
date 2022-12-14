using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.Cookies;
using WiFi_Antennas.DAL.EF;
using WiFi_Antennas.DAL.Interfaces;
using WiFi_Antennas.DAL.Repositories;
using WiFi_Antennas.BLL.Interfaces;
using WiFi_Antennas.BLL.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationContext>(options =>
{
    options.UseSqlite(builder.Configuration.GetConnectionString("AntennasDBConnection") ?? throw new Exception("Bad connection path"));
});
builder.Services.AddDbContext<UserContext>(options =>
{
    options.UseSqlite(builder.Configuration.GetConnectionString("UsersDBConnection") ?? throw new Exception("Bad connection path"));
});

builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IAntennaRepository, AntennaRepository>();
builder.Services.AddScoped<IAccessUserService, AccessUserService>();
builder.Services.AddTransient<ITokenCreator, TokenCreator>();
builder.Services.AddScoped<IAntennaService, AntennaService>();

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options =>
    {
        options.LoginPath = "/auth/login";
        options.ExpireTimeSpan = TimeSpan.FromMinutes(15);
    });

builder.Services.AddControllersWithViews();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");

    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
