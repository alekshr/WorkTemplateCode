using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WorkTemplateCode.Timer
{
    
    public enum TimerTypeView 
    {
        [InspectorName("Format(hh:mm:ss.fffffff)")]
        HourWithMillisecondsFormat = 0,
        [InspectorName("Format(mm:ss.fffffff)")]
        MinutsWithMillisecondsFormat = 1,        
        [InspectorName("Format(ss.fffffff)")]
        SecondsWithMillisecondsFormat = 2,        
        [InspectorName("Format(hh:mm:ss)")]
        HourFormat = 3,        
        [InspectorName("Format(mm:ss)")]
        MinutsFormat = 4,        
        [InspectorName("Format(ss)")]
        SecondsFormat = 5,
        
    }
}