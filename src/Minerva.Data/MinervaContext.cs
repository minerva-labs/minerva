using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Npgsql;

namespace Minerva.Data;

public class MinervaContext : DbContext
{
    public DbSet<TestResult> TestResults => Set<TestResult>();

    public MinervaContext()
    {
        NpgsqlConnection.GlobalTypeMapper.MapEnum<TestResultFormat>();
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.HasPostgresEnum<TestResultFormat>();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var configBuilder = new ConfigurationBuilder()
            .AddEnvironmentVariables();
        var config = configBuilder.Build();
        optionsBuilder
            .UseNpgsql($"Host={config["MinervaDbHost"]};Database={config["MinervaDatabase"]};Username={config["MinervaDbUser"]};Password={config["MinervaDbPassword"]}", o => o.UseNodaTime())
            .UseSnakeCaseNamingConvention();
    }
}
