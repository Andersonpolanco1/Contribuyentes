using ContribuyentesApi.Core.Interfaces;
using ContribuyentesApi.Core.Interfaces.Repositories;
using ContribuyentesApi.Core.Interfaces.Services;
using ContribuyentesApi.Infrastructure.Data;
using ContribuyentesApi.Infrastructure.Repositories;
using ContribuyentesApi.Services;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnectionString"),
        x => x.MigrationsAssembly("ContribuyentesApi.Infrastructure")));

builder.Services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
builder.Services.AddScoped(typeof(IContribuyenteService), typeof(ContribuyentesService));
builder.Services.AddScoped(typeof(IContribuyenteRepository), typeof(ContribuyenteRepository));

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.Configure<RouteOptions>(options => options.LowercaseUrls = true);

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(builder => 
    builder.WithOrigins("http://localhost:4200")
            .AllowAnyHeader()
            .AllowAnyMethod());
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.UseCors();

app.Run();
