using FRMK.ConsoleApp;
using FRMK.IoC;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((_, services) =>
        services.RegisterServices()
        .AddScoped<Executor>())
    .Build();

host.Services.GetService<Executor>()?.Execute();

await host.RunAsync();