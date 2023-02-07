using Microsoft.Extensions.Configuration;

namespace Resume.Data.DataSetup;

public static class DbConfig
{
    public static string GetConnString(string name)
    {
        var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

        var connectionString = configuration.GetConnectionString("db");
        Console.WriteLine(connectionString);
        return connectionString ?? throw new InvalidOperationException();
    }
}