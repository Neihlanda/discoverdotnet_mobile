using discoverdotnet_mobile.Controls;
using discoverdotnet_mobile.Models;
using discoverdotnet_mobile.Services;
using Sharpnado.Presentation.Forms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace discoverdotnet_mobile.ViewModels
{
    public class BookmarkViewModel : BaseViewModel
    {
        private readonly IBookmarkService _bookmarkService;
        public TaskLoaderNotifier<ObservableCollection<News>> Loader { get; }

        public BookmarkViewModel()
        {
            _bookmarkService = new BookmarkService();
            Loader = new TaskLoaderNotifier<ObservableCollection<News>>();
        }

        public override Task InitializeAsync(object parameter)
        {
            Loader.Load(async (_) => new ObservableCollection<News>(await _bookmarkService.GetBookmarkedNews()));
            return base.InitializeAsync(parameter);
        }

        private ICommand bookmarkNews;
        public ICommand DeleteBookmark => bookmarkNews ??= new Command(
            execute: async (data) =>
            {
                var news = data as News;
                await _bookmarkService.RemoveBookmarkedNews(news);
                Loader.Result.Remove(news);
                DependencyService.Resolve<IToast>().Show("News removed from bookmark !");
            },
            canExecute: (data) => data is News
        );
    }
}
