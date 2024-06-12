using Stopwatch.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Stopwatch.ViewModel
{
    public class StopwatchViewModel : INotifyPropertyChanged
    {
        private readonly StopwatchModel _stopwatchModel;

        public StopwatchViewModel() 
        {
            _stopwatchModel = new StopwatchModel();
            _stopwatchModel.TimeUpdated += OnTimeUpdated;
        }

        private void OnTimeUpdated(object sender, EventArgs e)
        {
            OnPropertyChanged(nameof(TimeElapsed));
        }

        public string TimeElapsed => _stopwatchModel.TimeElapsed;

        public void Start() => _stopwatchModel.Start();

        public void Pause() => _stopwatchModel.Pause();

        public void Stop() => _stopwatchModel.Stop();

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
