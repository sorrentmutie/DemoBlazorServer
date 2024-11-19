using DemoBlazorServer.Models;
using DemoBlazorServer.Models.RandomUserAPI;
using DemoBlazorWASM;
using DemoBlazorWASM.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddScoped<IEventi, ServizioEventiWASM>();
builder.Services.AddScoped<IRandomUserData, ServizioWASMRandomUser>();

await builder.Build().RunAsync();
