using System;
using System.Collections.ObjectModel;

using audit.Models;
using audit.Services;

using GalaSoft.MvvmLight;

namespace audit.ViewModels
{
    public class ChartViewModel : ViewModelBase
    {
        public ChartViewModel()
        {
        }

        public ObservableCollection<DataPoint> Source
        {
            get
            {
                // TODO WTS: Replace this with your actual data
                return SampleDataService.GetChartSampleData();
            }
        }
    }
}
