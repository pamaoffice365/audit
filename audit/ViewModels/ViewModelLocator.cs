using System;

using audit.Services;
using audit.Views;

using CommonServiceLocator;

using GalaSoft.MvvmLight.Ioc;

namespace audit.ViewModels
{
    [Windows.UI.Xaml.Data.Bindable]
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            SimpleIoc.Default.Register(() => new NavigationServiceEx());
            Register<PivotViewModel, PivotPage>();
            Register<MainViewModel, MainPage>();
            Register<CameraViewModel, CameraPage>();
            Register<MasterDetailViewModel, MasterDetailPage>();
            Register<MasterDetail1ViewModel, MasterDetail1Page>();
            Register<MasterDetail2ViewModel, MasterDetail2Page>();
            Register<ChartViewModel, ChartPage>();
            Register<InkSmartCanvasViewModel, InkSmartCanvasPage>();
            Register<ImageGalleryViewModel, ImageGalleryPage>();
            Register<ImageGalleryDetailViewModel, ImageGalleryDetailPage>();
            Register<MapViewModel, MapPage>();
            Register<SettingsViewModel, SettingsPage>();
            Register<SchemeActivationSampleViewModel, SchemeActivationSamplePage>();
        }

        public SchemeActivationSampleViewModel SchemeActivationSampleViewModel => ServiceLocator.Current.GetInstance<SchemeActivationSampleViewModel>();

        public SettingsViewModel SettingsViewModel => ServiceLocator.Current.GetInstance<SettingsViewModel>();

        public MapViewModel MapViewModel => ServiceLocator.Current.GetInstance<MapViewModel>();

        public ImageGalleryDetailViewModel ImageGalleryDetailViewModel => ServiceLocator.Current.GetInstance<ImageGalleryDetailViewModel>();

        public ImageGalleryViewModel ImageGalleryViewModel => ServiceLocator.Current.GetInstance<ImageGalleryViewModel>();

        public InkSmartCanvasViewModel InkSmartCanvasViewModel => ServiceLocator.Current.GetInstance<InkSmartCanvasViewModel>();

        public ChartViewModel ChartViewModel => ServiceLocator.Current.GetInstance<ChartViewModel>();

        public MasterDetail2ViewModel MasterDetail2ViewModel => ServiceLocator.Current.GetInstance<MasterDetail2ViewModel>();

        public MasterDetail1ViewModel MasterDetail1ViewModel => ServiceLocator.Current.GetInstance<MasterDetail1ViewModel>();

        public MasterDetailViewModel MasterDetailViewModel => ServiceLocator.Current.GetInstance<MasterDetailViewModel>();

        public CameraViewModel CameraViewModel => ServiceLocator.Current.GetInstance<CameraViewModel>();

        public MainViewModel MainViewModel => ServiceLocator.Current.GetInstance<MainViewModel>();

        public PivotViewModel PivotViewModel => ServiceLocator.Current.GetInstance<PivotViewModel>();

        public NavigationServiceEx NavigationService => ServiceLocator.Current.GetInstance<NavigationServiceEx>();

        public void Register<VM, V>()
            where VM : class
        {
            SimpleIoc.Default.Register<VM>();

            NavigationService.Configure(typeof(VM).FullName, typeof(V));
        }
    }
}
