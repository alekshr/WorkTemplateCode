using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace WorkTemplateCode.Timer
{
    public class TimerView : MonoBehaviour
    {
        [SerializeField] 
        private Text _textTimer = default;
        
        [SerializeField] 
        private TimerTypeView _timerTypeView = default;
        
        [SerializeField]
        private TimerController _timerController = default;

        private readonly Dictionary<TimerTypeView, string> _mapFormatTimer = new Dictionary<TimerTypeView, string>()
        {
            [TimerTypeView.HourWithMillisecondsFormat] = @"hh\:mm\:ss\.fffffff",
            [TimerTypeView.MinutsWithMillisecondsFormat] = @"mm\:ss\.fffffff",        
            [TimerTypeView.SecondsWithMillisecondsFormat] = @"ss\.fffffff",        
            [TimerTypeView.HourFormat] = @"hh\:mm\:ss",        
            [TimerTypeView.MinutsFormat] = @"mm\:ss",        
            [TimerTypeView.SecondsFormat] = @"ss",
        };
        
        private string _formatTimer = default;
        
        private void Start()
        {
            _formatTimer = _mapFormatTimer[_timerTypeView];
            _timerController.onUpdateTimer += UpdateTimer;
        }

        private void OnDestroy() => 
            _timerController.onUpdateTimer -= UpdateTimer;

        private void UpdateTimer(TimeSpan _timeSpan) =>
            _textTimer.text = _timeSpan.ToString(_formatTimer);
    }
}


