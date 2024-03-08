using System;
using Microsoft.Extensions.Configuration;


static void main(string[] args)
{
    IConfigurationRoot configuration = new ConfigurationBuilder()
        .AddJsonFile("TrackerUI\\config.json").Build();
    string ff = configuration.GetConnectionString("Tournaments");
    Console.WriteLine(ff);
}