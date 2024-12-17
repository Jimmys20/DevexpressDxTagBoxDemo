using DevExpress.Blazor;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace DevexpressDxTagBoxDemo
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            builder.Services.AddDevExpressBlazor(options =>
            {
                options.BootstrapVersion = BootstrapVersion.v5;
                options.SizeMode = SizeMode.Medium;
            });

            await builder.Build().RunAsync();
        }
    }
}
