# TempreatureAlarm

## Overview
`TempreatureAlarm` is a simple, console-based C# application that simulates a temperature monitoring system. It uses delegates and events to notify a display and an alarm component when the current temperature changes, specifically when it crosses a predefined threshold.

---

## How It Works
1. **Temperature Sensor** (`Sensor.cs`) reports changes by raising an event with temperature data.
2. **Delegates & Events**: Subscribers like the display and alarm components register to the sensor's event. When the temperature changes, the event is triggered and they’re notified.
3. **Display Component** (`Display.cs`) reacts by showing the updated temperature.
4. **Alarm Component** (`Alarm.cs`) reacts by issuing a warning if the temperature exceeds the configured alarm threshold.

This design demonstrates clear separation of concerns and decoupled communication—classic use of the publisher-subscriber pattern in event-driven programming, powered by delegates and events.

---

## Technologies Used
- **C#**
- **.NET Console Application** (e.g., .NET 7 or 8)
- Object-Oriented Programming principles
- Events & Delegates for communication between components
- Project structure includes `.csproj`, `.sln`, and source code files like `Program.cs`, `Sensor.cs`, `TempEventArgs.cs`, `Display.cs`, `Alarm.cs`

---

## Getting Started

### Prerequisites
- Install the .NET SDK (e.g., .NET 7 or 8)

### Installation & Usage

git clone https://github.com/mohamedamin7510/TempreatureAlarm.git
cd TempreatureAlarm
dotnet build
dotnet run
## Contribution
Contributions are welcome! Steps to contribute:

1. Fork the repository.
2. Create a new branch (e.g., `feature/your-feature`).
3. Make changes with clear, descriptive commits.
4. Push your branch.
5. Open a Pull Request describing your enhancements or fixes.

---

## License
This project is open-source and free to use, modify, and distribute without restriction.

---

## Summary
**TempreatureAlarm** is a simple, educational tool showcasing how delegates and events enable decoupled components (sensor, display, alarm) in a console application.  

If you'd like to enhance it, consider:
- Adding configuration options for thresholds
- Logging or file-based input/output
- Multiple sensor support
- A graphical user interface or richer console UI
---
---
---
