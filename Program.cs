using finance_api.EndPoints;
using finance_api.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.AddArchitectures();

var app = builder.Build();

app.UseArchitectures();

app.MapFinanceEndPoints();

app.Run();
