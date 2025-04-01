using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Refit;
using Taskmaster;
using Taskmaster.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddRefitClient<ITaskmasterApi>(new RefitSettings
{
    ContentSerializer = new SystemTextJsonContentSerializer(TaskmasterSettings.GetJsonSerializerOptions())
}).ConfigureHttpClient(c => c.BaseAddress = new Uri(TaskmasterSettings.ApiUrl));

builder.Services.AddBlazorBootstrap();
//builder.Services.AddSessionStorageServices();


await builder.Build().RunAsync();