using DAL;
using DAL.Handlers;
using DAL.Interfaces;
using Logic;
using Logic.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<IPlayerHandler, PlayerHandler>();
builder.Services.AddSingleton<IPlayerLogic, PlayerLogic>();

var app = builder.Build();

IPlayerHandler playerHandler = app.Services.GetRequiredService<IPlayerHandler>();
IPlayerLogic playerLogic = app.Services.GetRequiredService<IPlayerLogic>();

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
