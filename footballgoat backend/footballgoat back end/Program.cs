using DAL;
using DAL.Handlers;
using DAL.Interfaces;
using Logic;
using Logic.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<IPlayerHandler, PlayerHandler>();
builder.Services.AddTransient<IPlayerLogic, PlayerLogic>();
builder.Services.AddTransient<IClubHandler, ClubHandler>();
builder.Services.AddTransient<IClubLogic, ClubLogic>();

/*
builder.Services.AddDbContext<ApplicationDataContext>(options =>
{
    options.UseMySql(builder.Configuration.GetConnectionString("Server=studmysql01.fhict.local;Uid=dbi406978;Database=dbi406978;Pwd=Sudblamzud2;"), ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("Server=studmysql01.fhict.local;Uid=dbi406978;Database=dbi406978;Pwd=Sudblamzud2;")));
});
*/

var app = builder.Build();

IPlayerHandler playerHandler = app.Services.GetRequiredService<IPlayerHandler>();
IPlayerLogic playerLogic = app.Services.GetRequiredService<IPlayerLogic>();
IClubHandler clubHandler = app.Services.GetRequiredService<IClubHandler>();
IClubLogic clubLogic = app.Services.GetRequiredService<IClubLogic>();

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
