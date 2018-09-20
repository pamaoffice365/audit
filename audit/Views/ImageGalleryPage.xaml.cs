using System;

using audit.ViewModels;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace audit.Views
{
    public sealed partial class ImageGalleryPage : Page
    {
        private ImageGalleryViewModel ViewModel
        {
            get { return DataContext as ImageGalleryViewModel; }
        }

        public ImageGalleryPage()
        {
            Loaded += ImageGalleryPage_Loaded;
            InitializeComponent();
            ViewModel.Initialize(gridView);
        }

        private async void ImageGalleryPage_Loaded(object sender, RoutedEventArgs e)
        {
            await ViewModel.LoadAnimationAsync();
        }
    }
}
