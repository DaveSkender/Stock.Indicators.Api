// STARTUP CONFIGURATION

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

IServiceCollection services = builder.Services;
ConfigurationManager configuration = builder.Configuration;

// add framework services
services.AddControllers();

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

// Configure the HTTP request pipeline.
_ = app.Environment.IsDevelopment()
  ? app.UseDeveloperExceptionPage()
  : app.UseHsts();

app.UseHttpsRedirection();
app.UseRouting();
app.UseCors("CorsPolicy");
app.MapControllers();
app.Run();
