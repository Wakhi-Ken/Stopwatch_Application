using NUnit.Framework;

namespace Stopwatch_Application.Tests
{
    /// <summary>
    /// Unit tests for the <see cref="StopwatchLogic"/> class.
    /// </summary>
    public class StopwatchLogicTests
    {
        /// <summary>
        /// The stopwatch instance under test.
        /// </summary>
        private StopwatchLogic stopwatch;

        /// <summary>
        /// Creates a new stopwatch before each test.
        /// </summary>
        [SetUp]
        public void Setup()
        {
            stopwatch = new StopwatchLogic();
        }

        /// <summary>
        /// Starting should reset time and set running state.
        /// </summary>
        [Test]
        public void Start_ShouldResetTimeAndStartRunning()
        {
            stopwatch.Start();
            Assert.AreEqual("00:00:00", stopwatch.GetFormattedTime());
            Assert.IsTrue(stopwatch.IsRunning);
        }

        /// <summary>
        /// A single tick should increase seconds by one.
        /// </summary>
        [Test]
        public void Tick_ShouldIncreaseSeconds_WhenRunning()
        {
            stopwatch.Start();
            stopwatch.Tick();
            Assert.AreEqual("00:00:01", stopwatch.GetFormattedTime());
        }

        /// <summary>
        /// Ticks should roll over correctly to minutes and hours.
        /// </summary>
        [Test]
        public void Tick_ShouldRollOverMinutesAndHours()
        {
            stopwatch.Start();
            for (int i = 0; i < 3661; i++) stopwatch.Tick(); // 1h 1m 1s
            Assert.AreEqual("01:01:01", stopwatch.GetFormattedTime());
        }

        /// <summary>
        /// Pausing should stop time progression.
        /// </summary>
        [Test]
        public void Pause_ShouldStopTimeProgress()
        {
            stopwatch.Start();
            stopwatch.Tick();
            stopwatch.Pause();
            stopwatch.Tick();
            Assert.AreEqual("00:00:01", stopwatch.GetFormattedTime());
        }

        /// <summary>
        /// Resuming should continue counting from paused time.
        /// </summary>
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

        /// <summary>
        /// Reset should zero time and stop the stopwatch.
        /// </summary>
        [Test]
        public void Reset_ShouldReturnToZero()
        {
            stopwatch.Start();
            stopwatch.Tick();
            stopwatch.Reset();
            Assert.AreEqual("00:00:00", stopwatch.GetFormattedTime());
            Assert.IsFalse(stopwatch.IsRunning);
        }

        /// <summary>
        /// Stop should prevent further time advancement.
        /// </summary>
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
