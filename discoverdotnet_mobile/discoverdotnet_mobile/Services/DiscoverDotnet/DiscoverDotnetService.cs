using discoverdotnet_mobile.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace discoverdotnet_mobile.Services
{
    public class DiscoverDotnetService : HttpService, IDiscoverDotnetService
    {
        private const string ApiEndpoint = "https://discoverdot.net/data/";
        private const string NewsEndpoint = ApiEndpoint + "news.json";

        public Task<List<News>> GetNews()
        {
            return GetAsync<List<News>>(NewsEndpoint);
        }

    }
}
