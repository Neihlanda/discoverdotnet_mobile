using discoverdotnet_mobile.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace discoverdotnet_mobile.Services
{
    public interface IDiscoverDotnetService
    {
        Task<List<News>> GetNews();     
    }
}
