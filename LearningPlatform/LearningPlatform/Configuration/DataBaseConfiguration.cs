using LearningPlatform.Dal;
using Microsoft.EntityFrameworkCore;

namespace LearningPlatform.Server.Configuration;

public static class DataBaseConfiguration
{
    public static void ConfigureDataBase(this WebApplicationBuilder builder)
    {
        var connectionString = builder.Configuration.GetConnectionString("DatabaseConnection");

        builder.Services.AddDbContext<MainContext>
            (b => b.UseSqlServer(connectionString));
    }
}
