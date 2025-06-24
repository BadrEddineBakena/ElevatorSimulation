using ElevatorSimulation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace ElevatorSimulation
{
    internal class Elevator
    {
        private Motor motor;
        public Label current;
        private Panel elevator;
        private Door door;
        private Queue<int> upwardRequests;
        private Queue<int> downwardRequests;
        public int currentFloor;
        private TaskCompletionSource<bool> elevatorTaskCompletionSource;


        public Elevator(Panel elevatorPanel, Panel door, Label current)
        {
            this.motor = new Motor(elevatorPanel, door);
            this.current = current;
            this.upwardRequests = new Queue<int>();
            this.downwardRequests = new Queue<int>();
            this.elevatorTaskCompletionSource = new TaskCompletionSource<bool>();
        }



        public async void StartElevator(int floorDest, int currentFloor)
        {
            await Task.Delay(3000);

            Direction requestDirection = floorDest > currentFloor ? Direction.Up : Direction.Down;

            if (requestDirection == Direction.Up)
            {
                upwardRequests.Enqueue(floorDest);
            }
            else if (requestDirection == Direction.Down)
            {
                downwardRequests.Enqueue(floorDest);
            }

            if (!motor.IsMoving)
            {
                while (upwardRequests.Count > 0 || downwardRequests.Count > 0)
                {
                    int nextFloor;

                    if (upwardRequests.Count > 0)
                    {
                        nextFloor = upwardRequests.Dequeue();
                    }
                    else if (downwardRequests.Count > 0)
                    {
                        nextFloor = downwardRequests.Dequeue();
                    }
                    else
                    {
                        break;
                    }


                    await motor.MoveElevator(nextFloor, currentFloor, current);



                    await Task.Delay(5000);


                    await motor.GetElevatorTaskCompletionSource().Task;
                }
            }
        }

    }




}