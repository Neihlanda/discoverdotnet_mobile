using discoverdotnet_mobile.Models;
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
        public TaskLoaderNotifier<List<News>> Loader { get; }

        public NewsViewModel()
        {
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


        private ICommand openLink;
        public ICommand OpenLink => openLink ??= new Command(
            execute: async (url) => await ProcessOpenLink(url as string),
            canExecute: (data) => data is string url && !string.IsNullOrEmpty(url)
        );

        private async Task ProcessOpenLink(string Url)
        {
            await Launcher.OpenAsync(Url);
        }
    }
}
