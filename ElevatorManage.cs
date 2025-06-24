using ElevatorSimulation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
 
namespace ElevatorSimulation
{
    public partial class ElevatorManage : Form
    {


        private int destinationFloor;

        private Elevator elevator;

        public ElevatorManage()
        {
            InitializeComponent();

            elevator = new Elevator(container, Door, current);
            elevator.currentFloor = 1;

            current.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }




        private async void button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int floor = int.Parse(btn.AccessibleName);

            //await Task.Delay(3000);

            elevator.StartElevator(floor, elevator.currentFloor);

            elevator.currentFloor = floor;
            await Task.Delay(5000);
        }

    }


}