var builder = DistributedApplication.CreateBuilder(args);

var myApi = builder.AddProject<Projects.Api>("weatherApi");

var web = builder.AddProject<Projects.MyWeatherHub>("myweatherhub")
              .WithReference(myApi)
              .WithExternalHttpEndpoints();

builder.Build().Run();