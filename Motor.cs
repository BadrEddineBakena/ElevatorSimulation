using ElevatorSimulation;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace ElevatorSimulation
{
    internal enum Direction
    {
        Up,
        Down,
        None
    }

    internal class Motor
    {
        private Panel elevator;
        private Door door;
        private int currentFloor;
        private TaskCompletionSource<bool> elevatorTaskCompletionSource;

        public bool IsMoving { get; private set; }
        public Direction Direction { get; private set; }
        private string direct;

        public Motor(Panel elevator, Panel door)
        {
            this.elevator = elevator;
            currentFloor = 1;
            this.door = new Door(elevator, door);
            Direction = Direction.None;
            this.elevatorTaskCompletionSource = new TaskCompletionSource<bool>();
        }

        public void MoveElevatorUp(int floorDest, Label current)
        {
            IsMoving = true;
            elevatorTaskCompletionSource = new TaskCompletionSource<bool>();

            Timer timer1 = new Timer();
            timer1.Interval = 5;

            int targetPosition = 133 * (4 - floorDest) + 97;

            timer1.Tick += async (object sender, EventArgs e) =>
            {
                if (elevator.Top > targetPosition)
                {
                    elevator.Top -= 2;
                    UpdateCurrentFloor(current);
                    direct = "up";
                }
                else
                {
                    timer1.Stop();
                    await door.OpenDoorAsync();
                    current.Text = floorDest.ToString() + "  _";
                    IsMoving = false;
                    elevatorTaskCompletionSource.TrySetResult(true);
                }
            };

            timer1.Start();
        }

        public void MoveElevatorDown(int floorDest, Label current)
        {
            IsMoving = true;
            elevatorTaskCompletionSource = new TaskCompletionSource<bool>();

            Timer timer1 = new Timer();
            timer1.Interval = 5;

            int targetPosition = 133 * (4 - floorDest) + 97;

            timer1.Tick += async (object sender, EventArgs e) =>
            {
                if (elevator.Top < targetPosition)
                {
                    elevator.Top += 2;
                    UpdateCurrentFloor(current);
                    direct = "down";
                }
                else
                {
                    timer1.Stop();
                    await door.OpenDoorAsync();
                    current.Text = floorDest.ToString() + "  _";
                    IsMoving = false;
                    elevatorTaskCompletionSource.TrySetResult(true);
                }
            };

            timer1.Start();
        }

        private void UpdateCurrentFloor(Label current)
        {
            int currentFloorCalc = 4 - ((elevator.Top) / 133);

            if (direct == "up")
            {
                current.Text = currentFloorCalc.ToString() + "  ∧";
            }
            else if (direct == "down")
            {
                current.Text = currentFloorCalc.ToString() + "  v";
            }
        }

        public TaskCompletionSource<bool> GetElevatorTaskCompletionSource()
        {
            return elevatorTaskCompletionSource;
        }

        public async Task MoveElevator(int nextFloor, int currentFloor, Label current)
        {
            if (nextFloor != currentFloor)
            {
                if (nextFloor > currentFloor)
                {
                    MoveElevatorUp(nextFloor, current);
                }
                else if (nextFloor < currentFloor)
                {
                    MoveElevatorDown(nextFloor, current);
                }

                // Await the completion of the move
                await elevatorTaskCompletionSource.Task;

                // Hold door open for 3 seconds, then close it
                await Task.Delay(3000);
                await door.CloseDoorAsync();
            }
            else
            {
                // Already on the floor: open door, wait, then close
                await door.OpenDoorAsync();
                if (direct == "up")
                {
                    current.Text = currentFloor.ToString() + "  ∧";
                }
                else if (direct == "down")
                {
                    current.Text = currentFloor.ToString() + "  V";
                }
                await Task.Delay(5000);
                await door.CloseDoorAsync();
            }
        }

        public async Task OpenDoorAsync()
        {
            await door.OpenDoorAsync();
        }

        public async Task CloseDoorAsync()
        {
            await door.CloseDoorAsync();
        }
    }
}
