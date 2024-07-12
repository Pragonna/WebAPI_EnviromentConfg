
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;

// Changed for git

IConfigurationBuilder configurationBuilder = new ConfigurationBuilder()
    .AddJsonFile("appSettings.json");

IConfigurationRoot configurationRoot = configurationBuilder.Build();

var dbName = configurationRoot["DatabaseName"];
var username = configurationRoot["DefaultUsername"];

Console.WriteLine($" Database name is {dbName}\n Username is {username}");

Console.ReadLine();
