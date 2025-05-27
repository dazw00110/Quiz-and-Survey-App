using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Quiz_and_Survey_App.Models;  // <-- poprawiona przestrze� nazw do ApplicationDbContext i AppUser

var builder = WebApplication.CreateBuilder(args);

// Po��czenie do bazy
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection")
    ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

// Rejestracja DbContext z Twoim kontekstem i SQL Server
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));

// Obs�uga wyj�tk�w migracji na dewelopment
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

// Dodajemy Identity z Twoim AppUser
builder.Services.AddDefaultIdentity<AppUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>();

builder.Services.AddRazorPages();

var app = builder.Build();

// Middleware
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication(); // zapomnia�e� doda� uwierzytelnianie!
app.UseAuthorization();

app.MapRazorPages();

app.Run();
