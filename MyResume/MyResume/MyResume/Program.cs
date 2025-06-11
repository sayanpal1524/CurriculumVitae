// Ensure the necessary namespaces are included at the top of the file
using MyResume.Domain.Interfaces;
using MyResume.Infrastructure.Data; // Ensure this namespace is included for IResumeDao

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<MyResume.Services.ResumeHelper>();
builder.Services.AddScoped<IResumeDao, ResumeDao>(); // Updated to use the imported namespaces

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
