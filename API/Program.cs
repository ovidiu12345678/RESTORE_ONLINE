using API.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Adaugarea serviciilor necesare pentru controlori
builder.Services.AddControllers();

// Adaugarea serviciilor necesare pentru documentarea API-ului cu Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Adaugarea serviciilor necesare pentru baza de date
builder.Services.AddDbContext<MagazinContext>(opt => 
{
    opt.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddCors();

// Adăugarea serviciilor necesare pentru autorizare
builder.Services.AddAuthorization();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors(opt => {
    opt.AllowAnyHeader().AllowAnyMethod().WithOrigins("http://localhost:5173");
});
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

var scope = app.Services.CreateScope();
var context = scope.ServiceProvider.GetRequiredService<MagazinContext>();
var logger = scope.ServiceProvider.GetRequiredService<ILogger<Program>>();

try
{
    context.Database.Migrate();
    InitializatorDb.Initializare(context);
}
catch (Exception ex)
{
    logger.LogError(ex, "A aparut o problema în timpul migrarii");
}

app.Run();

