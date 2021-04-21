using discoverdotnet_mobile.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace discoverdotnet_mobile.Services
{
    public interface IBookmarkService
    {
        Task<List<News>> GetBookmarkedNews();
        Task BookmarkNews(News news);
        Task RemoveBookmarkedNews(News news);
    }
}
