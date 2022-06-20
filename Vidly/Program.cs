using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Vidly.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

/*
 * Old Custom Route Implementation
 * - Custom routes are now applied in the Controller
 * 
 * - Order of routes matter
 *  - Order from most specific to least
 *  
 * https://docs.microsoft.com/en-us/aspnet/core/mvc/controllers/routing?view=aspnetcore-6.0
 * 
    app.MapControllerRoute(
        name: "MoviesByReleaseDate",
        pattern: "movies/released/{year}/{month}",
        defaults: new { controller = "Movies", action = "ByReleaseDate" },
        //limit the year to 4 digits and month to 2 digits
        constraints: new { year = @"\d{4}", month = @"\d{2}" });
 */

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();

app.Run();
