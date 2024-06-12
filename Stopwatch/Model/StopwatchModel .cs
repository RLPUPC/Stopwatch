using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Stopwatch.Model
{
    public class StopwatchModel 
    {
        private readonly Timer _timer;
        private TimeSpan _timeElapsed;

        public StopwatchModel() 
        {
            _timer = new Timer(1000);
            _timer.Elapsed += OnTimedEvent;
            _timeElapsed = TimeSpan.Zero;
        }

        public event EventHandler TimeUpdated;
        public string TimeElapsed => _timeElapsed.ToString(@"hh\:mm\:ss");

        public void OnTimedEvent(object source, ElapsedEventArgs e) 
        {
            _timeElapsed = _timeElapsed.Add(TimeSpan.FromSeconds(1));
            TimeUpdated?.Invoke(this, EventArgs.Empty);
        }

        public void Start() => _timer.Start();
         
        public void Pause() => _timer.Stop();

        public void Stop() 
        {
            _timer.Stop();
            _timeElapsed = TimeSpan.Zero;
            TimeUpdated?.Invoke(this, EventArgs.Empty);

        }
    }
}
