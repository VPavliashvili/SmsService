using SmsService.Contexts;
using SmsService.Providers;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers()
                .AddJsonOptions(options => options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter()));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<ISmsProviderStrategy, RandomProviderStrategy>();
builder.Services.AddScoped<ISmsProviderStrategy, PercentProviderStrategy>();

builder.Services.AddScoped<IProvider, MagtiSmsProvider>();
builder.Services.AddScoped<IProvider, TwilioSmsProvider>();
builder.Services.AddScoped<IProvider, GeocellSmsProvider>();

builder.Services.AddScoped<ISmsServiceContext, SmsServiceContext>();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
