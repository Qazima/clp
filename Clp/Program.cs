// See https://aka.ms/new-console-template for more information
using Clp.Library;
using Microsoft.Extensions.Configuration;

IConfigurationRoot? _appSettings = new ConfigurationBuilder()
    .AddJsonFile("appSettings.json")
    .AddEnvironmentVariables()
    .Build();

Configuration? _configuration = _appSettings.GetRequiredSection("configuration").Get<Configuration>();

_configuration?.CreatePluginsDirectories();
