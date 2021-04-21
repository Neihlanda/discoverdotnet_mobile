using discoverdotnet_mobile.Models;
using Sharpnado.Presentation.Forms;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace discoverdotnet_mobile.ViewModels
{
    public class ProjectViewModel : BaseViewModel
    {
        public TaskLoaderNotifier<List<Project>> Loader { get; }

        public ProjectViewModel()
        {
            Loader = new TaskLoaderNotifier<List<Project>>();
        }

        public override Task InitializeAsync(object parameter)
        {
            Loader.Load(async () => await DiscoverDotnetService.GetProjects());
            return base.InitializeAsync(parameter);
        }
    }
}
