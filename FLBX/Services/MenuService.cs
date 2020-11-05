using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Json;
using Microsoft.Extensions.Configuration;

namespace FLBX
{
    public class MenuService : IMenuService
    {
        IHttpClientFactory ClientFactory { get; set; }
        IConfiguration Configuration { get; set; }
        public List<Menu> Menus { get; set; }

        public MenuService(IHttpClientFactory clientFactory, IConfiguration configuration)
        {
            this.ClientFactory = clientFactory;
            this.Configuration = configuration;
        }

        public async Task GetMenus()
        {
            string productUrl = Configuration.GetSection("Hosts").GetSection("Product").Value;

            if (string.IsNullOrEmpty(productUrl))
            {
                throw new NotImplementConfigureException("Can not find. product service url. please configure hosts.json");
            }

            this.Menus = await this.ClientFactory.CreateClient().GetFromJsonAsync<List<Menu>>(productUrl + "/api/Menus");
        }
    }
}
