using NUnit.Framework;

namespace Stopwatch_Application.Tests
{
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
            Assert.AreEqual("00:00:00", stopwatch.GetFormattedTime());
            Assert.IsTrue(stopwatch.IsRunning);
        }

        [Test]
        public void Tick_ShouldIncreaseSeconds_WhenRunning()
        {
            stopwatch.Start();
            stopwatch.Tick();
            Assert.AreEqual("00:00:01", stopwatch.GetFormattedTime());
        }

        [Test]
        public void Tick_ShouldRollOverMinutesAndHours()
        {
            stopwatch.Start();
            for (int i = 0; i < 3661; i++) stopwatch.Tick(); // 1h 1m 1s
            Assert.AreEqual("01:01:01", stopwatch.GetFormattedTime());
        }

        [Test]
        public void Pause_ShouldStopTimeProgress()
        {
            stopwatch.Start();
            stopwatch.Tick();
            stopwatch.Pause();
            stopwatch.Tick();
            Assert.AreEqual("00:00:01", stopwatch.GetFormattedTime());
        }

        [Test]
        public void Resume_ShouldContinueCounting()
        {
            stopwatch.Start();
            stopwatch.Tick();
            stopwatch.Pause();
            stopwatch.Resume();
            stopwatch.Tick();
            Assert.AreEqual("00:00:02", stopwatch.GetFormattedTime());
        }

        [Test]
        public void Reset_ShouldReturnToZero()
        {
            stopwatch.Start();
            stopwatch.Tick();
            stopwatch.Reset();
            Assert.AreEqual("00:00:00", stopwatch.GetFormattedTime());
            Assert.IsFalse(stopwatch.IsRunning);
        }

        [Test]
        public void Stop_ShouldStopCounting()
        {
            stopwatch.Start();
            stopwatch.Tick();
            stopwatch.Stop();
            stopwatch.Tick();
            Assert.AreEqual("00:00:01", stopwatch.GetFormattedTime());
        }
    }
}
