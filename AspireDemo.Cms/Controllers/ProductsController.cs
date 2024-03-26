using AspireDemo.WeatherApi;
using Umbraco.Cms.Web.Common.Controllers;

namespace AspireDemo.Cms.Controllers
{
    /// <summary>
    /// ~/Umbraco/Api/Products/GetAllProducts
    /// </summary>
    public class ProductsController : UmbracoApiController
    {
        private readonly WeatherServiceClient client;

        public ProductsController(WeatherServiceClient client)
        {
            this.client = client;
        }

        public async Task<IEnumerable<WeatherForecast>> GetAllProducts()
        {
            return await client.Get();
        }
    }
}
