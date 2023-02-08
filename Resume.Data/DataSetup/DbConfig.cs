using Microsoft.Extensions.Configuration;

namespace Resume.Data.DataSetup;

public static class DbConfig
{
    public static string GetConnString(string name)
    {
        var connectionString = Environment.GetEnvironmentVariable("db");
        Console.WriteLine(connectionString);

        if (connectionString == null)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            connectionString = configuration.GetConnectionString("db");
        }
        Console.WriteLine(connectionString);
        return connectionString ?? throw new InvalidOperationException();
    }
}