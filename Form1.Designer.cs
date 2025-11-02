namespace Stopwatch_Application;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    // Designer-managed controls
    private System.Windows.Forms.Timer timer;
    private System.Windows.Forms.Label timeLabel;
    private System.Windows.Forms.Button startButton;
    private System.Windows.Forms.Button pauseButton;
    private System.Windows.Forms.Button resumeButton;
    private System.Windows.Forms.Button resetButton;
    private System.Windows.Forms.Button stopButton;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.timer = new System.Windows.Forms.Timer(this.components);
        this.timeLabel = new System.Windows.Forms.Label();
        this.startButton = new System.Windows.Forms.Button();
        this.pauseButton = new System.Windows.Forms.Button();
        this.resumeButton = new System.Windows.Forms.Button();
        this.resetButton = new System.Windows.Forms.Button();
        this.stopButton = new System.Windows.Forms.Button();
        this.SuspendLayout();

        // 
        // timer
        // 
        this.timer.Interval = 1000;
        this.timer.Tick += new System.EventHandler(this.Timer_Tick);

        // 
        // timeLabel
        // 
        this.timeLabel.Name = "timeLabel";
        this.timeLabel.Text = "00:00:00";
        this.timeLabel.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.timeLabel.Size = new System.Drawing.Size(200, 50);
        this.timeLabel.Location = new System.Drawing.Point(100, 30);

        // 
        // startButton
        // 
        this.startButton.Name = "startButton";
        this.startButton.Text = "Start";
        this.startButton.Size = new System.Drawing.Size(80, 30);
        this.startButton.Location = new System.Drawing.Point(50, 120);
        this.startButton.Click += new System.EventHandler(this.StartButton_Click);

        // 
        // pauseButton
        // 
        this.pauseButton.Name = "pauseButton";
        this.pauseButton.Text = "Pause";
        this.pauseButton.Size = new System.Drawing.Size(80, 30);
        this.pauseButton.Location = new System.Drawing.Point(150, 120);
        this.pauseButton.Click += new System.EventHandler(this.PauseButton_Click);

        // 
        // resumeButton
        // 
        this.resumeButton.Name = "resumeButton";
        this.resumeButton.Text = "Resume";
        this.resumeButton.Size = new System.Drawing.Size(80, 30);
        this.resumeButton.Location = new System.Drawing.Point(250, 120);
        this.resumeButton.Click += new System.EventHandler(this.ResumeButton_Click);

        // 
        // resetButton
        // 
        this.resetButton.Name = "resetButton";
        this.resetButton.Text = "Reset";
        this.resetButton.Size = new System.Drawing.Size(80, 30);
        this.resetButton.Location = new System.Drawing.Point(100, 170);
        this.resetButton.Click += new System.EventHandler(this.ResetButton_Click);

        // 
        // stopButton
        // 
        this.stopButton.Name = "stopButton";
        this.stopButton.Text = "Stop";
        this.stopButton.Size = new System.Drawing.Size(80, 30);
        this.stopButton.Location = new System.Drawing.Point(200, 170);
        this.stopButton.Click += new System.EventHandler(this.StopButton_Click);

        // 
        // Form1
        // 
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(400, 300);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        this.MaximizeBox = false;
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Stopwatch Application";

        // Add controls
        this.Controls.Add(this.timeLabel);
        this.Controls.Add(this.startButton);
        this.Controls.Add(this.pauseButton);
        this.Controls.Add(this.resumeButton);
        this.Controls.Add(this.resetButton);
        this.Controls.Add(this.stopButton);

        // Initial button states
        this.startButton.Enabled = true;
        this.pauseButton.Enabled = false;
        this.resumeButton.Enabled = false;
        this.resetButton.Enabled = false;
        this.stopButton.Enabled = false;

        this.ResumeLayout(false);
    }

    #endregion
}