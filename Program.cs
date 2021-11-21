using Microsoft.EntityFrameworkCore;
using net_web_tuto.Database;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Database
builder.Services.AddDbContext<ApplicationDbContext>(options => {
    string databaseHost = Environment.GetEnvironmentVariable("DATABSE_HOST");
    string databaseName = Environment.GetEnvironmentVariable("DATABSE_NAME");
    string databaseUsername = Environment.GetEnvironmentVariable("DATABASE_USERNAME");
    string databasePassword = Environment.GetEnvironmentVariable("DATABSE_PASSWORD");

    var connectionString = $"server={databaseHost};database={databaseName};user={databaseUsername};password={databasePassword}";
    Console.WriteLine(connectionString);
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
