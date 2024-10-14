using BlazorApp2;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using System.Net.Http.Json;
using MudBlazor;
using BlazorApp2;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

var httpClient= new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) };
var appSettings = await httpClient.GetFromJsonAsync<AppSettings>("appsettings.json");
var baseurl = appSettings!.baseurls.ApiRecur;
builder.Services.AddScoped(sp=>new HttpClient { BaseAddress=new Uri(baseurl) });

    //builder.Services.AddScoped(sp =>
    //   new HttpClient
    //   {
    //        BaseAddress = new Uri("https://localhost:7154")
    //    });
await builder.Build().RunAsync();



public class AppSettings
{
    public BaseUrls baseurls { get; set; }
}
public class BaseUrls
{
    public string ApiRecur { get; set; }
}