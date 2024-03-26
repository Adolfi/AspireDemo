var builder = DistributedApplication.CreateBuilder(args);

var weatherapi = builder.AddProject<Projects.AspireDemo_WeatherApi>("weatherapi");

builder.AddProject<Projects.AspireDemo_Cms>("cms").WithReference(weatherapi);

builder.Build().Run();
