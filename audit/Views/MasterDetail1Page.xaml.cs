using System;

using audit.ViewModels;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace audit.Views
{
    public sealed partial class MasterDetail1Page : Page
    {
        private MasterDetail1ViewModel ViewModel
        {
            get { return DataContext as MasterDetail1ViewModel; }
        }

        public MasterDetail1Page()
        {
            InitializeComponent();
            Loaded += MasterDetail1Page_Loaded;
        }

        private async void MasterDetail1Page_Loaded(object sender, RoutedEventArgs e)
        {
            await ViewModel.LoadDataAsync(MasterDetailsViewControl.ViewState);
        }
    }
}
