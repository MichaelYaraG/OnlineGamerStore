using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OGS.Infraestructure;
using OGS.Application;
using OGS.Domain;

var builder = WebApplication.CreateBuilder(args);

// Configurar IConfiguration
builder.Services.AddSingleton<IConfiguration>(builder.Configuration);

// Configurar la conexión a la base de datos
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));

// Agregar controladores y vistas
builder.Services.AddControllersWithViews();
builder.Services.AddControllers();

// Construir la aplicación
var app = builder.Build();

// Configurar el pipeline de la aplicación
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}


app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapControllers();

// Ejecutar la aplicación
app.Run();
