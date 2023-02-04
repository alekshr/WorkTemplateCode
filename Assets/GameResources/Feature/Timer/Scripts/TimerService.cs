using System;
using System.Threading;
using System.Threading.Tasks;

namespace WorkTemplateCode.Timer
{
    public class TimerService
    {
        /// <summary>
        /// Событие при окончание таймера
        /// </summary>
        public event Action onEndTimer = delegate {  }; 
        
        private TimeSpan _timerData = default;
        private TimeSpan _substractionTimerMillisecunds = default;
        private CancellationTokenSource _cancellationSource = default;
        
        public TimerService(TimeSpan timerData, float substractionTimerMillisecunds)
        {
            _timerData = timerData;
            _substractionTimerMillisecunds = TimeSpan.FromMilliseconds(substractionTimerMillisecunds);
            _cancellationSource = new CancellationTokenSource();
        }

        public async void Run()
        {
            while (_timerData.TotalMilliseconds > 0)
            {
                await Task.Delay(_substractionTimerMillisecunds, _cancellationSource.Token);
                _timerData = _timerData.Subtract(_substractionTimerMillisecunds);
            }

            onEndTimer();
        }

    }
}