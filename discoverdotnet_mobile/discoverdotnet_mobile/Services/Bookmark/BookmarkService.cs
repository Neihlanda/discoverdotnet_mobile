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
            if (!await _localDb.NewsExistAsync(news))
                await _localDb.SaveNewsAsync(news);
        }

        public Task<List<News>> GetBookmarkedNews()
        {
            return _localDb.GetNewsAsync();
        }

        public async Task RemoveBookmarkedNews(News news)
        {
            if (await _localDb.NewsExistAsync(news))
                await _localDb.DeleteNewsAsync(news);
        }
    }
}
