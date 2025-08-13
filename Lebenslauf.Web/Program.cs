using GoogleReCaptcha.V3;
using GoogleReCaptcha.V3.Interface;
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

#region dbCOntext
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
});
#endregion



RegisterServices(builder.Services);
#region Google Recaptcha

builder.Services.AddHttpClient<ICaptchaValidator, GoogleReCaptchaValidator>();

#endregion

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
