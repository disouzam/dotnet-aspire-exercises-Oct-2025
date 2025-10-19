var builder = DistributedApplication.CreateBuilder(args);

var cache = builder.AddRedis("cache");

var myApi = builder.AddProject<Projects.Api>("api");

var web = builder.AddProject<Projects.MyWeatherHub>("myweatherhub")
              .WithReference(myApi)
              .WithExternalHttpEndpoints();

builder.Build().Run();