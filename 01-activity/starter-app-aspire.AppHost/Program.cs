var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.starter_app_aspire_ApiService>("apiservice");

builder.AddProject<Projects.starter_app_aspire_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService);

builder.Build().Run();
