using Microsoft.OpenApi.Models;
using NP90S.Application.Contracts.Persistence.AlbumEntity;
using NP90S.Persistence;
using NP90S.Persistence.ApplicationDbContexts;

namespace NP90S.Api
{
  public static class StartupExtensions
  {
    public static WebApplication ConfigureServices(this WebApplicationBuilder builder)
    {
      AddSwagger(builder.Services);
      builder.Services.AddPersistenceServices(builder.Configuration);
      builder.Services.AddScoped<IAlbumContext, AlbumContext>();
      builder.Services.AddHttpContextAccessor();
      builder.Services.AddControllers();
      builder.Services.AddCors(options =>
      {
        options.AddPolicy("Open", builder => builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
      });

      return builder.Build();
    }

    public static WebApplication ConfigurePipeline(this WebApplication app)
    {
      if (app.Environment.IsDevelopment())
      {
        app.UseSwagger();
        app.UseSwaggerUI(c => { c.SwaggerEndpoint("/swagger/v1/swagger.json", "NP90S API"); });
      }

      app.UseHttpsRedirection();
      //app.UseRouting();
      app.UseAuthentication();
      //app.UseCustomExceptionHandler();
      app.UseCors("Open");
      app.UseAuthorization();
      app.MapControllers();

      return app;
    }

    private static void AddSwagger(IServiceCollection services)
    {
      services.AddSwaggerGen(c =>
      {
        c.SwaggerDoc("v1", new OpenApiInfo
        {
          Version = "v1",
          Title = "NP90S API",
        });
      });
    }
  }
}
