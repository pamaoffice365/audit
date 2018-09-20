using System.Threading.Tasks;

using audit.Helpers;
using audit.ViewModels;

using Windows.UI.Xaml.Controls;

namespace audit.Views
{
    public sealed partial class CameraPage : Page, IPivotPage
    {
        private CameraViewModel ViewModel
        {
            get { return DataContext as CameraViewModel; }
        }

        public CameraPage()
        {
            InitializeComponent();
        }

        public async Task OnPivotSelectedAsync()
        {
            await cameraControl.InitializeCameraAsync();
        }

        public async Task OnPivotUnselectedAsync()
        {
            await cameraControl.CleanupCameraAsync();
        }
    }
}
