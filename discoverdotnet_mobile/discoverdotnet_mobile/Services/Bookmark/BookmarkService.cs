using discoverdotnet_mobile.DataAccess;
using discoverdotnet_mobile.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace discoverdotnet_mobile.Services
{
    public class BookmarkService : IBookmarkService
    {
        private readonly LocalDatabase _localDb;
        public BookmarkService()
        {
            _localDb = LocalDatabase.Database;
        }

        public async Task BookmarkNews(News news)
        {
            news.Bookmarked = true;
            if (!await _localDb.BookMarkedNewsExistAsync(news))
                await _localDb.SaveBookmarkedNewsAsync(news);
        }

        public Task<List<News>> GetBookmarkedNews()
        {
            return _localDb.GetBookmarkedNewsAsync();
        }

        public async Task RemoveBookmarkedNews(News news)
        {
            news.Bookmarked = false;
            if (await _localDb.BookMarkedNewsExistAsync(news))
                await _localDb.DeleteBookmarkedNewsAsync(news);
        }
    }
}
