// STARTUP CONFIGURATION

using Api;
using Microsoft.OpenApi.Models;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

IServiceCollection services = builder.Services;
ConfigurationManager configuration = builder.Configuration;

// add framework services
services.AddControllers();

// OpenAPI (Swagger docs)
// Learn more at https://aka.ms/aspnetcore/swashbuckle
services.AddEndpointsApiExplorer();
services.AddSwaggerGen();
services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "API | Stock Indicators",
        Description = "We'll convert your stock quotes into market indicators.  This is a self-hosted open-source API, developed by Skender Consulting Services, LLC.",
        TermsOfService = new Uri("https://api-docs.stockindicators.dev/terms"),
        Contact = new OpenApiContact
        {
            Name = "Project",
            Url = new Uri("https://api-docs.stockindicators.dev"),

        },
        License = new OpenApiLicense
        {
            Name = "License",
            Url = new Uri("https://github.com/DaveSkender/Stock.Indicators.Api/blob/main/LICENSE")
        }
    });
});

// get CORS origins from appsettings
string?[] configOrigins = configuration
    .GetSection("CorsOrigins")
    .GetChildren()
    .Select(x => x.Value)
    .ToArray();

string[] origins = [];

if (configOrigins is not null)
{
    origins = configOrigins!;
}
else
{
    throw new InvalidOperationException("CORS Origins are missing from App Settings.");
}

// setup CORS for website
services.AddCors(options =>
{
    options.AddPolicy("CorsPolicy",
    cors =>
    {
        cors.AllowAnyHeader();
        cors.AllowAnyMethod();
        cors.WithOrigins(origins);
    });
});

// build application
WebApplication app = builder.Build();

// setup development environment
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();

    app.UseSwagger();
    app.UseSwaggerUI();
}

// production alternatives
else
{
    app.UseHsts();
}

// configure the HTTP request pipeline.
app.UseHttpsRedirection();
app.UseRouting();
app.UseCors("CorsPolicy");

// add minimal API root endpoint
app.MapGet("/", () => "API is functioning nominally.")
  .ExcludeFromDescription();

// base indicators
Indicators.Map(app);

// run the API
app.Run();
