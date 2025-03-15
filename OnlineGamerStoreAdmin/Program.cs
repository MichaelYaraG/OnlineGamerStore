using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OGS.Infraestructure;
using OGS.Application;
using OGS.Domain;
using OGS.Infraestructure.Repository;
using OGS.Application.Services;
using Microsoft.AspNetCore.Http.Features;

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

//AGREGO LAS REFERENCIAS A LOS REPOSITORIOS Y SERVICIOS
builder.Services.AddScoped<MarcaRepository>();
builder.Services.AddScoped<MarcaService>();
builder.Services.AddScoped<CategoriaRepository>();
builder.Services.AddScoped<CategoriaService>();
builder.Services.AddScoped<ProductoRepository>();
builder.Services.AddScoped<ProductoService>();
builder.Services.AddScoped<ClienteRepository>();
builder.Services.AddScoped<ClienteService>();
builder.Services.Configure<FormOptions>(options =>
{
    options.MultipartBodyLengthLimit = 10 * 1024 * 1024; // Permitir archivos de hasta 10MB
});

// Construir la aplicación
var app = builder.Build();

// Configurar el pipeline de la aplicación
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseStaticFiles();
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
