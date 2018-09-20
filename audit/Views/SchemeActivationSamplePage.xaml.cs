using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using audit.Helpers;
using audit.ViewModels;

using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace audit.Views
{
    // TODO WTS: Remove this sample page when/if it's not needed.
    // This page is an sample of how to launch a specific page in response to a protocol launch and pass it a value.
    // It is expected that you will delete this page once you have changed the handling of a protocol launch to meet
    // your needs and redirected to another of your pages.
    public sealed partial class SchemeActivationSamplePage : Page, IPivotActivationPage
    {
        private SchemeActivationSampleViewModel ViewModel
        {
            get { return DataContext as SchemeActivationSampleViewModel; }
        }

        public SchemeActivationSamplePage()
        {
            InitializeComponent();
        }

        public async Task OnPivotActivatedAsync(Dictionary<string, string> parameters)
        {
            ViewModel.Initialize(parameters);
            await Task.CompletedTask;
        }
    }
}
