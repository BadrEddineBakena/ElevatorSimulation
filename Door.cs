using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElevatorSimulation
{
    internal class Door
    {
        private readonly Panel doorPanel;
        private readonly int closedWidth = 72;
        private readonly int animationStep = 4;
        private readonly int animationDelay = 10;

        public Door(Panel elevatorPanel, Panel door)
        {
            this.doorPanel = door;
        }

        public async Task OpenDoorAsync()
        {
            await AnimateDoorAsync(open: true);
        }

        public async Task CloseDoorAsync()
        {
            await AnimateDoorAsync(open: false);
        }

        private async Task AnimateDoorAsync(bool open)
        {
            int targetWidth = open ? 0 : closedWidth;
            int direction = open ? -animationStep : animationStep;

            await Task.Run(() =>
            {
                while ((open && doorPanel.Width > targetWidth) || (!open && doorPanel.Width < targetWidth))
                {
                    doorPanel.Invoke((MethodInvoker)(() =>
                    {
                        doorPanel.Width += direction;

                        // Prevent overshoot
                        if ((open && doorPanel.Width < targetWidth) || (!open && doorPanel.Width > targetWidth))
                        {
                            doorPanel.Width = targetWidth;
                        }
                    }));

                    System.Threading.Thread.Sleep(animationDelay);
                }
            });
        }
    }
}
