using NUnit.Framework;

namespace Stopwatch_Application.Tests
{
    /// <summary>
    /// Unit tests for the <see cref="StopwatchLogic"/> class.
    /// </summary>
    public class StopwatchLogicTests
    {
        private StopwatchLogic stopwatch;

        [SetUp]
        public void Setup()
        {
            stopwatch = new StopwatchLogic();
        }

        [Test]
        public void Start_ShouldResetTimeAndStartRunning()
        {
            stopwatch.Start();
            Assert.AreEqual("00:00:00", stopwatch.GetFormattedTime(),
                "When starting, the stopwatch should reset time to 00:00:00.");
            Assert.IsTrue(stopwatch.IsRunning,
                "The stopwatch should be running after Start() is called.");
        }

        [Test]
        public void Tick_ShouldIncreaseSeconds_WhenRunning()
        {
            stopwatch.Start();
            stopwatch.Tick();
            Assert.AreEqual("00:00:01", stopwatch.GetFormattedTime(),
                "After one tick, the time should increase by one second.");
        }

        [Test]
        public void Tick_ShouldRollOverMinutesAndHours()
        {
            stopwatch.Start();
            for (int i = 0; i < 3661; i++) stopwatch.Tick(); // 1h 1m 1s
            Assert.AreEqual("01:01:01", stopwatch.GetFormattedTime(),
                "After 3661 ticks, the time should correctly roll over to 01:01:01.");
        }

        [Test]
        public void Pause_ShouldStopTimeProgress()
        {
            stopwatch.Start();
            stopwatch.Tick();
            stopwatch.Pause();
            stopwatch.Tick();
            Assert.AreEqual("00:00:01", stopwatch.GetFormattedTime(),
                "Time should not increase while the stopwatch is paused.");
        }

        [Test]
        public void Resume_ShouldContinueCounting()
        {
            stopwatch.Start();
            stopwatch.Tick();
            stopwatch.Pause();
            stopwatch.Resume();
            stopwatch.Tick();
            Assert.AreEqual("00:00:02", stopwatch.GetFormattedTime(),
                "After resuming, time should continue from where it left off.");
        }

        [Test]
        public void Reset_ShouldReturnToZero()
        {
            stopwatch.Start();
            stopwatch.Tick();
            stopwatch.Reset();
            Assert.AreEqual("00:00:00", stopwatch.GetFormattedTime(),
                "Reset should set the time back to 00:00:00.");
            Assert.IsFalse(stopwatch.IsRunning,
                "After reset, the stopwatch should not be running.");
        }

        [Test]
        public void Stop_ShouldStopCounting()
        {
            stopwatch.Start();
            stopwatch.Tick();
            stopwatch.Stop();
            stopwatch.Tick();
            Assert.AreEqual("00:00:01", stopwatch.GetFormattedTime(),
                "Once stopped, additional ticks should not change the time.");
        }
    }
}
