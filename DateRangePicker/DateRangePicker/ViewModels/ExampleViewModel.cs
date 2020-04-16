
using System;
using AgentOctal.WpfLib;


namespace DateRangePicker.ViewModels
{
    public class ExampleViewModel : ViewModel
    {
        public ExampleViewModel()
        {
            FromDate = new DateTime(2020, 1, 1);
            ToDate = DateTime.Today;
        }

        private DateTime _fromDate;
        public DateTime FromDate
        {
            get { return _fromDate; }
            set
            {
                SetValue(ref _fromDate, value);
                UpdateDifference();
            }
        }

        private DateTime _toDate;
        public DateTime ToDate
        {
            get { return _toDate; }
            set
            {
                SetValue(ref _toDate, value);
                UpdateDifference();
            }
        }

        private int _difference;
        public int Difference
        {
            get { return _difference; }
            set
            {
                SetValue(ref _difference, value);
            }
        }

        private void UpdateDifference()
        {
            Difference = (int)Math.Floor((ToDate - FromDate).TotalDays);
        }
    }
}
