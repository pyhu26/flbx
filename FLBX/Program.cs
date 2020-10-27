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

            #region Syncfusion 등록
            builder.Services.AddSyncfusionBlazor(true);
            #endregion

            #region HttpClient 생성
            builder.Services.AddHttpClient("DefaultClient", client => client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress));
            builder.Services.AddScoped(sp => sp.GetRequiredService<IHttpClientFactory>().CreateClient("DefaultClient"));
            #endregion

            #region Custom Service 등록
            builder.Services.AddSingleton<FxUtil>(); //공용 함수
            builder.Services.AddSingleton<MenuService>(); //메뉴 관리
            #endregion

            await builder.Build().RunAsync();
        }
    }
}
