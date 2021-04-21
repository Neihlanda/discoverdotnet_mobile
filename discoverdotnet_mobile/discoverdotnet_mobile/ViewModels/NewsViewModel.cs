﻿using discoverdotnet_mobile.Controls;
using discoverdotnet_mobile.Models;
using discoverdotnet_mobile.Services;
using Sharpnado.Presentation.Forms;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace discoverdotnet_mobile.ViewModels
{
    public class NewsViewModel : BaseViewModel
    {
        private readonly IBookmarkService _bookmarkService;
        public TaskLoaderNotifier<List<News>> Loader { get; }


        public NewsViewModel()
        {
            _bookmarkService = new BookmarkService();
            Loader = new TaskLoaderNotifier<List<News>>();
        }

        public override Task InitializeAsync(object parameter)
        {
            Loader.Load(LoadLastNews);
            return base.InitializeAsync(parameter);
        }

        private async Task<List<News>> LoadLastNews()
        {
            return await DiscoverDotnetService.GetNews();        
        }

        private ICommand bookmarkNews;
        public ICommand BookmarkNews => bookmarkNews ??= new Command(
            execute: async (data) =>
            {
                var news = data as News;
                await _bookmarkService.BookmarkNews(news);
                DependencyService.Resolve<IToast>().Show("News bookmarked !");
            },
            canExecute: (data) => data is News
        );
    }
}
