using System;
using System.Windows.Forms;

namespace Stopwatch_Application;

public partial class Form1 : Form
{
    private int hours = 0;
    private int minutes = 0;
    private int seconds = 0;
    private bool isPaused = false;

    /// <summary>
    /// Initialize the main form and its components
    /// </summary>
    public Form1()
    {
        InitializeComponent();
        UpdateDisplay();
        EnableButtons(true, false, false, false, false);
    }

    /// <summary>
    /// Timer tick event handler - updates the time display
    /// </summary>
    private void Timer_Tick(object? sender, EventArgs e)
    {
        seconds++;
        if (seconds == 60)
        {
            seconds = 0;
            minutes++;
            if (minutes == 60)
            {
                minutes = 0;
                hours++;
            }
        }
        UpdateDisplay();
    }

    /// <summary>
    /// Updates the time display label with current time
    /// </summary>
    private void UpdateDisplay()
    {
        if (timeLabel != null)
        {
            timeLabel.Text = $"{hours:D2}:{minutes:D2}:{seconds:D2}";
        }
    }

    /// <summary>
    /// Starts the stopwatch from 00:00:00
    /// </summary>
    private void StartButton_Click(object? sender, EventArgs e)
    {
        if (!timer.Enabled && !isPaused)
        {
            hours = minutes = seconds = 0;
            UpdateDisplay();
            timer.Start();
            EnableButtons(false, true, false, true, true);
        }
    }

    /// <summary>
    /// Pauses the stopwatch and displays current time
    /// </summary>
    private void PauseButton_Click(object? sender, EventArgs e)
    {
        if (timer.Enabled)
        {
            timer.Stop();
            isPaused = true;
            EnableButtons(false, false, true, true, true);
        }
    }

    /// <summary>
    /// Resumes the stopwatch from the last paused time
    /// </summary>
    private void ResumeButton_Click(object? sender, EventArgs e)
    {
        if (!timer.Enabled && isPaused)
        {
            timer.Start();
            isPaused = false;
            EnableButtons(false, true, false, true, true);
        }
    }

    /// <summary>
    /// Resets the stopwatch back to 00:00:00
    /// </summary>
    private void ResetButton_Click(object? sender, EventArgs e)
    {
        timer.Stop();
        hours = minutes = seconds = 0;
        isPaused = false;
        UpdateDisplay();
        EnableButtons(true, false, false, false, false);
    }

    /// <summary>
    /// Stops the stopwatch completely and displays the final time
    /// </summary>
    private void StopButton_Click(object? sender, EventArgs e)
    {
        timer.Stop();
        isPaused = false;
        EnableButtons(true, false, false, false, false);
    }

    /// <summary>
    /// Enables or disables buttons based on current state
    /// </summary>
    private void EnableButtons(bool start, bool pause, bool resume, bool reset, bool stop)
    {
        if (startButton != null) startButton.Enabled = start;
        if (pauseButton != null) pauseButton.Enabled = pause;
        if (resumeButton != null) resumeButton.Enabled = resume;
        if (resetButton != null) resetButton.Enabled = reset;
        if (stopButton != null) stopButton.Enabled = stop;
    }
}
