using System;
using System.Linq;
using System.Threading.Tasks;

using audit.Activation;
using audit.Helpers;
using audit.ViewModels;

using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace audit.Views
{
    public sealed partial class PivotPage : Page
    {
        private PivotViewModel ViewModel
        {
            get { return DataContext as PivotViewModel; }
        }

        public PivotPage()
        {
            // We use NavigationCacheMode.Required to keep track the selected item on navigation. For further information see the following links.
            // https://msdn.microsoft.com/en-us/library/windows/apps/xaml/windows.ui.xaml.controls.page.navigationcachemode.aspx
            // https://msdn.microsoft.com/en-us/library/windows/apps/xaml/Hh771188.aspx
            NavigationCacheMode = NavigationCacheMode.Required;
            InitializeComponent();
        }

        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            if (e.Parameter is SchemeActivationData data)
            {
                await InitializeFromSchemeActivationAsync(data);
            }

            await Task.CompletedTask;
        }

        public async Task InitializeFromSchemeActivationAsync(SchemeActivationData schemeActivationData)
        {
            var selected = pivot.Items.Cast<PivotItem>()
                    .FirstOrDefault(i => i.IsOfViewModelName(schemeActivationData.ViewModelName));

            var page = selected?.GetPage<IPivotActivationPage>();

            pivot.SelectedItem = selected;
            await page?.OnPivotActivatedAsync(schemeActivationData.Parameters);
        }
    }
}
