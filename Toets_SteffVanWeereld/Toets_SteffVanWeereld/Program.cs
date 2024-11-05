
using Serilog;
using Serilog.Formatting.Json;
using Toets_SteffVanWeereld.Services;

namespace Toets_SteffVanWeereld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            
            // Add services to the container.
            builder.Logging.ClearProviders();
            var logger = new LoggerConfiguration()
            .WriteTo.Seq("http://localhost:5341")
            .WriteTo.Console(new JsonFormatter())
            .CreateLogger();
            builder.Services.AddControllers();
            builder.Logging.AddSerilog(logger);
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddSingleton<IVacationHomeService, VacationHomeService>();
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
        }
    }
}
