using Persistense;
using Persistense.Interface;
using Service;
using Service.Interface;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<IDatabaseConn, DatabaseConn>();
builder.Services.AddScoped<ITipo_LocalService, Tipo_LocalService>();
builder.Services.AddScoped<IHorarioService, HorarioService>();
builder.Services.AddScoped<ILocalService, LocalService>();

// Add services to the container.
builder.Services.AddControllers();
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
