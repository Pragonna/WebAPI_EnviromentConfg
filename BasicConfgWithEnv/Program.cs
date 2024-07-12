
using Microsoft.Extensions.Configuration;

Environment.SetEnvironmentVariable("Pragonna_TestEnv", "Development");

IConfigurationRoot configurationRoot = new ConfigurationBuilder()
    .AddJsonFile("appSettings.json")
    .AddEnvironmentVariables(prefix:"Pragonna_")
    .Build();

var dbName=configurationRoot["DatabaseName"];
var username = configurationRoot["DefaultUsername"];
var envName = configurationRoot["TestEnv"];

Console.WriteLine($"Db:  {dbName}\nUsr: {username}\nEnv: {envName}");

Console.ReadLine();

