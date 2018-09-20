using System;

using audit.ViewModels;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace audit.Views
{
    public sealed partial class MapPage : Page
    {
        private MapViewModel ViewModel
        {
            get { return DataContext as MapViewModel; }
        }

        public MapPage()
        {
            InitializeComponent();
            Loaded += MapPage_Loaded;
            Unloaded += MapPage_Unloaded;
        }

        private async void MapPage_Loaded(object sender, RoutedEventArgs e)
        {
            await ViewModel.InitializeAsync(mapControl);
        }

        private void MapPage_Unloaded(object sender, RoutedEventArgs e)
        {
            ViewModel.Cleanup();
        }
    }
}
