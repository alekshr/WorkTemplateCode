using System;
using UnityEngine;

namespace WorkTemplateCode.Timer
{
    /// <summary>
    /// Данные таймера
    /// </summary>
    [Serializable]
    public class TimerData
    {
        /// <summary>
        /// Часы
        /// </summary>
        [Range(0, 23)]
        public int Hour = default;

        /// <summary>
        /// Минуты
        /// </summary>
        [Range(0, 59)]
        public int Minutes = default;

        /// <summary>
        /// Секунды
        /// </summary>
        [Range(0, 59)]
        public int Seconds = default;

        /// <summary>
        /// Возвращает TimeSpan
        /// </summary>
        /// <returns></returns>
        public TimeSpan GetTimeSpan() =>
            new TimeSpan(0, Hour, Minutes, Seconds);
        
        
    }
}

