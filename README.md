# ElevatorSimulation
## Overview  
This project is a simple elevator simulator built using Windows Forms (.NET). It features a graphical interface that mimics an elevator moving between floors, with animated doors and floor indicators.

## Features  
- Elevator moves between 4 floors (Ground to Floor 3)  
- Animated door open/close simulation  
- Floor indicator with direction arrows  
- Buttons to call the elevator from floors and inside the cabin  

## Getting Started  

### Prerequisites  
- Windows OS  
- Visual Studio 2022 or newer (with .NET desktop development workload)  
- .NET 6.0 or later SDK  

### Setup  
1. Clone the repository  
   ```bash
   git clone https://github.com/BadrEddineBakena/ElevatorSimulator.git
Open the solution ElevatorSimulation.sln in Visual Studio.

Restore NuGet packages if necessary (usually automatic).

Build and run the project (F5).

Usage
Click on any floor button to call the elevator.

Watch the elevator move and doors animate.

Floor indicator updates with direction arrows.

Project Structure
ElevatorManage.cs: Main form and UI event handlers.

Motor.cs: Handles elevator movement logic and animations.

Door.cs: Manages door opening/closing animations.

Resources/: Contains image assets (door, elevator, call button).

Known Issues / TODO
Smooth door animation can be improved.

Add sound effects for elevator movement.

Handle concurrent floor requests more efficiently.

Contributing
Feel free to fork and submit pull requests. Please follow coding conventions and write clear commit messages.

License
This project is licensed under the MIT License - see the LICENSE file for details.

