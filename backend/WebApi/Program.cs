using Microsoft.EntityFrameworkCore;
using Service.Models.AppSettings;
using Service.Models.ExternalApisSettings;
using Service.Service.Interfaces;
using Service.Service;
using tarefas.Corp.Context;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHttpClient();

builder.Services.AddOptions<ExternalApisSettings>()
    .Bind(builder.Configuration.GetSection("ExternalApiSettings"));

builder.Services.AddOptions<SigningSettings>()
.Bind(builder.Configuration.GetSection("SigningConfigurations"));

builder.Services.AddScoped<ISessionService, SessionService>();
builder.Services.AddScoped<ICharacterService, CharacterService>();
builder.Services.AddScoped<ILocationService, LocationService>();
builder.Services.AddScoped<IEpisodeService, EpisodeService>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("MyPolicy", policy =>
    {
        policy.RequireAssertion(context => true);
    });
});

builder.Services.AddDbContext<CorpContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("Corp")!));

builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(builder => builder
           .WithOrigins(
               "https://mujapira.com",
               "http://localhost:3000",
               "http://localhost:5000",
               "http://localhost:5174"
           )
           .SetIsOriginAllowedToAllowWildcardSubdomains()
           .AllowAnyMethod()
           .AllowAnyHeader()
           .AllowCredentials());
});

var app = builder.Build();

app.UseCors();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();