using System;

namespace Stopwatch_Application
{
    /// <summary>
    /// Represents the stopwatch logic independent of UI, for testing.
    /// </summary>
    public class StopwatchLogic
    {
        public int Hours { get; private set; }
        public int Minutes { get; private set; }
        public int Seconds { get; private set; }
        public bool IsRunning { get; private set; }

        /// <summary>
        /// Starts or restarts the stopwatch from 00:00:00.
        /// </summary>
        public void Start()
        {
            Hours = Minutes = Seconds = 0;
            IsRunning = true;
        }

        /// <summary>
        /// Pauses the stopwatch.
        /// </summary>
        public void Pause() => IsRunning = false;

        /// <summary>
        /// Resumes the stopwatch.
        /// </summary>
        public void Resume() => IsRunning = true;

        /// <summary>
        /// Stops the stopwatch completely.
        /// </summary>
        public void Stop() => IsRunning = false;

        /// <summary>
        /// Resets the stopwatch back to 00:00:00.
        /// </summary>
        public void Reset()
        {
            Hours = Minutes = Seconds = 0;
            IsRunning = false;
        }

        /// <summary>
        /// Simulates one timer tick (1 second).
        /// </summary>
        public void Tick()
        {
            if (!IsRunning) return;

            Seconds++;
            if (Seconds == 60)
            {
                Seconds = 0;
                Minutes++;
                if (Minutes == 60)
                {
                    Minutes = 0;
                    Hours++;
                }
            }
        }

        /// <summary>
        /// Returns formatted time 00:00:00.
        /// </summary>
        public string GetFormattedTime() => $"{Hours:D2}:{Minutes:D2}:{Seconds:D2}";
    }
}
