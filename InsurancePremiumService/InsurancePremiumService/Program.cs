using BusinessLayer;
using BusinessLayer.Interfaces;
using DataAccessLayer.ServiceExtension;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddRepositoryServices();
builder.Services.AddScoped<IPremiumProcessor, PremiumProcessor>();

builder.Services.AddControllers();

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "MyAllowSpecificOrigins",
                      builder =>
                      {
                          builder.AllowAnyOrigin().AllowAnyMethod()
                          .AllowAnyHeader();
                      });
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseCors("MyAllowSpecificOrigins");
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
