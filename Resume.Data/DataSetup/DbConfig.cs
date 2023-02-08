using System.Collections;
using Microsoft.Extensions.Configuration;

namespace Resume.Data.DataSetup;

public static class DbConfig
{
    public static string GetConnString(string name)
    {
        var connectionString = Environment.GetEnvironmentVariable(name);

        if (connectionString == null)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            connectionString = configuration.GetConnectionString(name);
        }
        
        return connectionString ?? throw new InvalidOperationException();
    }
}