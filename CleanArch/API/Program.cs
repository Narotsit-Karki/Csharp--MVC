using Infrastructure;
using Application;

var builder = WebApplication.CreateBuilder(args);

//For enablig Application
RegisterApplication.AddApplication(builder.Services);
// Add services to the container.
// add this  for enabling infrastructure
RegisterInfrastructure.AddInfrastructure(builder.Services, builder.Configuration);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
