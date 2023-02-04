using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WorkTemplateCode.Timer
{
    /// <summary>
    /// Контроллер таймера
    /// </summary>
    public class TimerController : MonoBehaviour
    {
        /// <summary>
        /// Событие обновление таймера
        /// </summary>
        public event Action<TimeSpan> onUpdateTimer = delegate {  }; 
        
        /// <summary>
        /// Событие при окончание таймера
        /// </summary>
        public event Action onEndTimer = delegate {  }; 
        
        [SerializeField, Header("Данные таймера")] 
        private TimerData _timerData = default;

        [SerializeField, Header("Время передается в миллисекундах"), Min(0)]
        private float _substractTimerMillisecund = default;

        [SerializeField] private TimerTypeView _timerTypeView = default;
        
        private Coroutine _coroutine = default;
        private TimeSpan _timerDataSpan = default;
        private TimeSpan _substractTimeSpan = default;
        private float _secundsConvert = default;
        

        /// <summary>
        /// Запускаем таймер
        /// </summary>
        public void Run()
        {
            if (_coroutine == null)
            {
                InitData();
                _coroutine = StartCoroutine(TimerRun());
            }
        }

        private void InitData()
        {
            _timerDataSpan = _timerData.GetTimeSpan();
            _substractTimeSpan = TimeSpan.FromMilliseconds(_substractTimerMillisecund);
            _secundsConvert = _substractTimerMillisecund / 1000;
        }

        private IEnumerator TimerRun()
        {
            while (_timerDataSpan.TotalMilliseconds > 0)
            {
                yield return new WaitForSeconds(_secundsConvert);
                _timerDataSpan = _timerDataSpan.Subtract(_substractTimeSpan);
                onUpdateTimer(_timerDataSpan);
            }
            onEndTimer();
        }
    }
}
