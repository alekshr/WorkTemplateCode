using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WorkTemplateCode.Timer;

public class TestTimerView : MonoBehaviour
{
    
    private readonly Dictionary<TimerTypeView, string> _mapFormatTimer = new Dictionary<TimerTypeView, string>()
    {
        [TimerTypeView.HourWithMillisecondsFormat] = @"hh\:mm\:ss.fffffff",
        [TimerTypeView.MinutsWithMillisecondsFormat] = @"mm\:ss.fffffff",        
        [TimerTypeView.SecondsWithMillisecondsFormat] = @"ss.fffffff",        
        [TimerTypeView.HourFormat] = @"hh\:mm\:ss",        
        [TimerTypeView.MinutsFormat] = @"mm\:ss",        
        [TimerTypeView.SecondsFormat] = @"ss",
    };

    private void Awake()
    {
        TimeSpan timeSpan = new TimeSpan(0, 15, 38, 58, 23562);
        Debug.Log(timeSpan.ToString(@"hh\:mm\:ss\.fffffff"));
        Debug.Log(timeSpan.ToString(@"mm\:ss\.fffffff"));
        Debug.Log(timeSpan.ToString(@"ss\.fffffff"));
        Debug.Log(timeSpan.ToString(@"hh\:mm\:ss"));
        Debug.Log(timeSpan.ToString(@"mm\:ss"));
        Debug.Log(timeSpan.ToString(@"ss"));
    }
}
