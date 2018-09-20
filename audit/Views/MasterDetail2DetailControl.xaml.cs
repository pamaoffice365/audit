using System;

using audit.Models;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace audit.Views
{
    public sealed partial class MasterDetail2DetailControl : UserControl
    {
        public SampleOrder MasterMenuItem
        {
            get { return GetValue(MasterMenuItemProperty) as SampleOrder; }
            set { SetValue(MasterMenuItemProperty, value); }
        }

        public static readonly DependencyProperty MasterMenuItemProperty = DependencyProperty.Register("MasterMenuItem", typeof(SampleOrder), typeof(MasterDetail2DetailControl), new PropertyMetadata(null, OnMasterMenuItemPropertyChanged));

        public MasterDetail2DetailControl()
        {
            InitializeComponent();
        }

        private static void OnMasterMenuItemPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = d as MasterDetail2DetailControl;
            control.ForegroundElement.ChangeView(0, 0, 1);
        }
    }
}
