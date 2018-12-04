using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Delegates
{
    public delegate void TempChanged(double prev, double current);

    public class Mashine
    {
        private double _currentTemp = 36;
        private TempChanged _tempChanged;

        public double CurrentTemp
        {
            get => _currentTemp;

            set
            {
                if (_currentTemp != value)
                {
                    var prev = _currentTemp;
                    _currentTemp = value;
                    OnTempChanged(prev, value);
                }
            }
        }

        public void TurnOn()
        {
            while (CurrentTemp < 100)
            {
                Thread.Sleep(1000);
                CurrentTemp++;
            }
        }

        /// <summary>
        /// Subscribe to Event with the delegate
        /// </summary>
        /// <param name="watcher">Delegate to Execute</param>
        public void RegisterTempChange(TempChanged watcher)
        {
            _tempChanged += watcher;
        }

        /// <summary>
        /// Raise the Event that is subscribed
        /// </summary>
        /// <param name="prev"></param>
        /// <param name="current"></param>
        private void OnTempChanged(double prev, double current)
        {
            _tempChanged?.Invoke(prev, current);
        }
    }

}
