using System.Threading.Tasks;
using TNTGoClone.Models;
using TNTGoClone.ViewModels;
using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace TNTGoClone.ContentViews
{
    public partial class LiveContentView : ContentView
    {
        public LiveContentView()
        {
            InitializeComponent();
        }

        protected override async void OnBindingContextChanged()
        {
            await OnBindingContextChangedAsync();
        }

        private async Task OnBindingContextChangedAsync()
        {
            base.OnBindingContextChanged();

            if (BindingContext is AppPage appPage)
                if (appPage.ViewModel is LiveViewModel viewModel)
                    await viewModel.InitializeAsync();
        }
    }
}
