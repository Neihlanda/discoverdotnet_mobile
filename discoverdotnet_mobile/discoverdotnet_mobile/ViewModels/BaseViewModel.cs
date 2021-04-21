using discoverdotnet_mobile.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace discoverdotnet_mobile.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        protected IDiscoverDotnetService DiscoverDotnetService { get; }

        public BaseViewModel()
        {
            DiscoverDotnetService = new DiscoverDotnetService();
        }

        public virtual Task InitializeAsync(object parameter)
        {
            return Task.FromResult(true);
        }

        protected bool SetProperty<T>(ref T backingStore, T value,
            [CallerMemberName] string propertyName = "",
            Action onChanged = null)
        {
            if (EqualityComparer<T>.Default.Equals(backingStore, value))
                return false;

            backingStore = value;
            onChanged?.Invoke();
            OnPropertyChanged(propertyName);
            return true;
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

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            var changed = PropertyChanged;
            if (changed == null)
                return;

            changed.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
