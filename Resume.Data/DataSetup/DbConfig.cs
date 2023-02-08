using System.Collections;
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
        Console.WriteLine("_______________________");
        foreach (DictionaryEntry de in Environment.GetEnvironmentVariables())
        {
            Console.WriteLine("  {0} = {1}", de.Key, de.Value);
        }
        return connectionString ?? throw new InvalidOperationException();
    }
}