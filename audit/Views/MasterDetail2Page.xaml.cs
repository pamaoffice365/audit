using System;

using audit.ViewModels;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace audit.Views
{
    public sealed partial class MasterDetail2Page : Page
    {
        private MasterDetail2ViewModel ViewModel
        {
            get { return DataContext as MasterDetail2ViewModel; }
        }

        public MasterDetail2Page()
        {
            InitializeComponent();
            Loaded += MasterDetail2Page_Loaded;
        }

        private async void MasterDetail2Page_Loaded(object sender, RoutedEventArgs e)
        {
            await ViewModel.LoadDataAsync(MasterDetailsViewControl.ViewState);
        }
    }
}
