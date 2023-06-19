// STARTUP CONFIGURATION

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

IServiceCollection services = builder.Services;
ConfigurationManager configuration = builder.Configuration;

// add framework services
services.AddControllers();

// swagger
services.AddEndpointsApiExplorer();
services.AddSwaggerGen();

// get CORS origins from appsettings
string[] origins = Array.Empty<string>();
IConfigurationSection corsOrigins = configuration.GetSection("CorsOrigins");

if (corsOrigins != null)
{
    List<(string key, string value)>? originKeys = corsOrigins
      .Get<List<(string key, string value)>>();

    if (originKeys != null)
    {
        origins = originKeys.Select(x => x.value).ToArray();
    }
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
app.MapControllers();
app.Run();
