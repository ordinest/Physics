using Darnton.Blazor.DeviceInterop.Geolocation;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Options;
using Physics;
using Physics.Domains.Astronomy;


var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");


// Register HTTP Client Factory typed with AstroObjectService data service
var apiSettings = builder.Configuration
    .GetSection(nameof(AstroObjectsAPISettings))
    .Get<AstroObjectsAPISettings>();
builder.Services.AddHttpClient<IAstroObjectService, AstroObjectService>(client =>
{
    client.BaseAddress = new Uri(apiSettings.AstroObjectsBaseAddress);
});

builder.Services.AddScoped<IGeolocationService, GeolocationService>();
//builder.Services.AddScoped<IAstroObjectService, AstroObjectService>();

await builder.Build().RunAsync();
