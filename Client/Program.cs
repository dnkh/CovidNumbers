using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using BlazorApplicationInsights;
using Client;
using Client.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");

builder.Services.AddBlazorApplicationInsights();
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<ICovidDataService, CovidDataService>();

await builder.Build().RunAsync();
