# Stopwatch_Application

A simple Windows Forms Stopwatch application written in C# (.NET 7). This project implements a stopwatch with Start, Pause, Resume, Reset, and Stop functionality and displays elapsed time in the format 00:00:00 (hh:mm:ss).

## Features

- Start: Begins counting from 00:00:00.
- Pause: Pauses the stopwatch and shows the current time.
- Resume: Continues counting from the paused time.
- Reset: Sets the timer back to 00:00:00.
- Stop: Stops the timer completely and leaves the last recorded time shown.

## Prerequisites

- .NET 7 SDK installed (https://dotnet.microsoft.com/download)
- Windows OS (this project uses Windows Forms)
- Visual Studio 2022+ recommended for designer support (or Visual Studio Code + C# extensions)

## How to run

Using Visual Studio:

1. Open `Stopwatch_Application.sln` in Visual Studio.
2. Build the solution (Build > Build Solution).
3. Run the project (F5 or Debug > Start Debugging).

Using the command line (PowerShell):

```powershell
# From the repository root
dotnet build "c:\Users\awini\Stopwatch_Application\Stopwatch_Application.csproj"
dotnet run --project "c:\Users\awini\Stopwatch_Application\Stopwatch_Application.csproj"
```

The application window should open and show the timer display and the control buttons.

## Usage

- Click **Start** to begin counting from 00:00:00.
- Click **Pause** to pause the timer (time remains displayed).
- Click **Resume** to continue counting.
- Click **Reset** to set the time back to 00:00:00 (and stop counting).
- Click **Stop** to stop the timer (time remains displayed until you Start or Reset).

Buttons are enabled/disabled to reflect the current state.

## XML Documentation

All methods include XML documentation comments as required. You can generate documentation or inspect the source to see the XML comments.

## Deliverables checklist

- [ ] Project pushed to GitHub (repository)
- [ ] README.md (this file)
- [ ] Screen recording (3–5 minutes) demonstrating the stopwatch
- [ ] Screenshot of stopwatch running (time other than 00:00:00)
- [ ] XML documentation checkpoint (methods documented)

## Notes and troubleshooting

- If controls do not appear as expected, ensure you run the project (not just build) and that your environment supports Windows Forms.
- If you get build errors around nullability or designer partial classes, open the `Form1.Designer.cs` in Visual Studio to confirm there are no duplicate control definitions.

If you'd like, I can:

- Add a small automated test harness (console-based) to unit-test the timer logic.
- Produce a sample screen recording command and tips on capturing with free tools.

---

Created to satisfy a group coding assignment: implement a stopwatch UI with Start/Pause/Resume/Reset/Stop and XML-documented methods.
