using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using discoverdotnet_mobile.Models;
using SQLite;

namespace discoverdotnet_mobile.DataAccess
{
    public class LocalDatabase
    {
        private const string DatabaseFilename = nameof(discoverdotnet_mobile) + ".db3";

        private static string DatabasePath
        {
            get
            {
                var basePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                return Path.Combine(basePath, DatabaseFilename);
            }
        }

        private readonly SQLiteAsyncConnection _database;

        private static LocalDatabase _currentInstance;

        public static LocalDatabase Database => _currentInstance ??= new LocalDatabase();
  
        private LocalDatabase()
        {
            _database = new SQLiteAsyncConnection(DatabasePath);
            _database.CreateTableAsync<News>();
        }

        public Task<List<News>> GetNewsAsync()
        {
            return _database.Table<News>().ToListAsync();
        }

        public async Task<bool> NewsExistAsync(News news)
        {
            return await _database.Table<News>().Where(dbnews => dbnews.Link == news.Link).CountAsync() > 0;
        }

        public Task<int> SaveNewsAsync(News News)
        {
            return _database.InsertAsync(News);
        }

        public Task<int> DeleteNewsAsync(News contact)
        {
            return _database.DeleteAsync(contact);
        }
    }
}
