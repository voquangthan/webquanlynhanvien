using Microsoft.EntityFrameworkCore;
using QuanlynhanvienAPI.Models;
using QuanlynhanvienAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddScoped<Inhanvien, Nhanvienservices>();
builder.Services.AddScoped<IPhongbancs, Phongbanservices>();


builder.Services.AddDbContext<QuanLyNhanVienDBContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection")
    ));

// cấp quyền api frontend (1)
builder.Services.AddCors(options =>
{
    options.AddPolicy("React", policy =>
    {
        policy.WithOrigins(
                "http://localhost:5174",
                "http://localhost:5173"
              )
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

// Configure the HTTP request pipeline.

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/openapi/v1.json", "v1");
    });
}

app.UseHttpsRedirection();

app.UseCors("React"); // Cho React gọi API (20)

app.UseAuthorization();

app.MapControllers();

app.Run();