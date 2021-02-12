using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using BlazorApplicationInsights;

namespace Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddHttpClient("DataService", dataClient => new HttpClient {  BaseAddress= new Uri( "https://services7.arcgis.com/0Uc5jDlEgdLosloE/arcgis/rest/services/Gemeinden/FeatureServer/0/query?f=json&where=1%3D1&outFields=*&returngeometry=false")});
            builder.Services.AddBlazorApplicationInsights();

            await builder.Build().RunAsync();
        }
    }
}
