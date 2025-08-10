using Lebenslauf.Infra.Data.Context;
using Lebenslauf.Infra.IoC;
using Microsoft.EntityFrameworkCore;
using System.Text.Encodings.Web;
using System.Text.Unicode;

var builder = WebApplication.CreateBuilder(args);

// Zugriff auf die Konfiguration
var configuration = builder.Configuration;

// ---------------------- Services registrieren ----------------------
builder.Services.AddControllersWithViews();

// DbContext
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
});

//// Eigene Services
RegisterServices(builder.Services);

//// Google Recaptcha
//builder.Services.AddHttpClient<ICaptchaValidator, GoogleReCaptchaValidator>();

// Encoder
builder.Services.AddSingleton<HtmlEncoder>(
    HtmlEncoder.Create(allowedRanges: new[] { UnicodeRanges.All })
);

// ---------------------- App erstellen ----------------------
var app = builder.Build();

// ---------------------- Middleware-Pipeline ----------------------
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// Area-Route + Default-Route
app.MapControllerRoute(
    name: "areas",
    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
);

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);

app.Run();

// ---------------------- Hilfsmethoden ----------------------
static void RegisterServices(IServiceCollection services)
{
    DependencyContainers.RegisterService(services);
}
