using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Syncfusion.Blazor;

namespace FLBX
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            #region Syncfusion ���
            builder.Services.AddSyncfusionBlazor(true);
            #endregion

            #region HttpClient ����
            builder.Services.AddHttpClient("DefaultClient", client => client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress));
            builder.Services.AddScoped(sp => sp.GetRequiredService<IHttpClientFactory>().CreateClient("DefaultClient"));
            #endregion

            #region Custom Service ���
            builder.Services.AddSingleton<FxUtil>(); //���� �Լ�
            builder.Services.AddSingleton<MenuService>(); //�޴� ����
            #endregion

            await builder.Build().RunAsync();
        }
    }
}
