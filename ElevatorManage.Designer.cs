namespace ElevatorSimulation
{
    partial class ElevatorManage
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            Floor3 = new Panel();
            F3 = new Button();
            label3 = new Label();
            Floor2 = new Panel();
            F2 = new Button();
            label4 = new Label();
            Floor1 = new Panel();
            F1 = new Button();
            label1 = new Label();
            Ground = new Panel();
            G = new Button();
            label2 = new Label();
            Elevator = new Panel();
            Door = new Panel();
            container = new Panel();
            panel1 = new Panel();
            current = new Label();
            floor3Btn = new Button();
            floor2Btn = new Button();
            floor1Btn = new Button();
            groundBtn = new Button();
            Floor3.SuspendLayout();
            Floor2.SuspendLayout();
            Floor1.SuspendLayout();
            Ground.SuspendLayout();
            Elevator.SuspendLayout();
            container.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Floor3
            // 
            Floor3.BackColor = Color.Tan;
            Floor3.Controls.Add(F3);
            Floor3.Controls.Add(label3);
            Floor3.Location = new Point(9, 38);
            Floor3.Name = "Floor3";
            Floor3.Size = new Size(355, 133);
            Floor3.TabIndex = 4;
            // 
            // F3
            // 
            F3.AccessibleName = "4";
            F3.BackColor = Color.MintCream;
            F3.BackgroundImage = Properties.Resources.callButton;
            F3.Location = new Point(332, 72);
            F3.Name = "F3";
            F3.Size = new Size(20, 40);
            F3.TabIndex = 0;
            F3.UseVisualStyleBackColor = false;
            F3.Click += button_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(26, 45);
            label3.Name = "label3";
            label3.Size = new Size(100, 42);
            label3.TabIndex = 1;
            label3.Text = "Floor3";
            // 
            // Floor2
            // 
            Floor2.BackColor = Color.Tan;
            Floor2.Controls.Add(F2);
            Floor2.Controls.Add(label4);
            Floor2.Location = new Point(9, 176);
            Floor2.Name = "Floor2";
            Floor2.Size = new Size(355, 133);
            Floor2.TabIndex = 3;
            // 
            // F2
            // 
            F2.AccessibleName = "3";
            F2.BackColor = Color.MintCream;
            F2.BackgroundImage = Properties.Resources.callButton;
            F2.Location = new Point(332, 72);
            F2.Name = "F2";
            F2.Size = new Size(20, 40);
            F2.TabIndex = 0;
            F2.UseVisualStyleBackColor = false;
            F2.Click += button_Click;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(26, 45);
            label4.Name = "label4";
            label4.Size = new Size(102, 37);
            label4.TabIndex = 1;
            label4.Text = "Floor2";
            // 
            // Floor1
            // 
            Floor1.BackColor = Color.Tan;
            Floor1.Controls.Add(F1);
            Floor1.Controls.Add(label1);
            Floor1.Location = new Point(9, 314);
            Floor1.Name = "Floor1";
            Floor1.Size = new Size(355, 133);
            Floor1.TabIndex = 2;
            // 
            // F1
            // 
            F1.AccessibleName = "2";
            F1.BackColor = Color.MintCream;
            F1.BackgroundImage = Properties.Resources.callButton;
            F1.Location = new Point(332, 72);
            F1.Name = "F1";
            F1.Size = new Size(20, 40);
            F1.TabIndex = 0;
            F1.UseVisualStyleBackColor = false;
            F1.Click += button_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(26, 45);
            label1.Name = "label1";
            label1.Size = new Size(102, 40);
            label1.TabIndex = 1;
            label1.Text = "Floor1";
            // 
            // Ground
            // 
            Ground.BackColor = Color.Tan;
            Ground.Controls.Add(G);
            Ground.Controls.Add(label2);
            Ground.Location = new Point(9, 453);
            Ground.Name = "Ground";
            Ground.Size = new Size(355, 133);
            Ground.TabIndex = 1;
            // 
            // G
            // 
            G.AccessibleName = "1";
            G.BackColor = Color.MintCream;
            G.BackgroundImage = Properties.Resources.callButton;
            G.Location = new Point(332, 72);
            G.Name = "G";
            G.Size = new Size(20, 40);
            G.TabIndex = 0;
            G.UseVisualStyleBackColor = false;
            G.Click += button_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(26, 45);
            label2.Name = "label2";
            label2.Size = new Size(102, 51);
            label2.TabIndex = 1;
            label2.Text = "Ground";
            // 
            // Elevator
            // 
            Elevator.BackColor = SystemColors.ControlText;
            Elevator.BackgroundImage = Properties.Resources.elevator;
            Elevator.Controls.Add(Door);
            Elevator.Location = new Point(0, 0);
            Elevator.Name = "Elevator";
            Elevator.Size = new Size(83, 79);
            Elevator.TabIndex = 5;
            // 
            // Door
            // 
            Door.BackColor = SystemColors.ControlDarkDark;
            Door.BackgroundImage = Properties.Resources.door;
            Door.Location = new Point(4, 4);
            Door.Name = "Door";
            Door.Size = new Size(72, 73);
            Door.TabIndex = 0;
            // 
            // container
            // 
            container.Controls.Add(panel1);
            container.Controls.Add(floor3Btn);
            container.Controls.Add(floor2Btn);
            container.Controls.Add(floor1Btn);
            container.Controls.Add(groundBtn);
            container.Controls.Add(Elevator);
            container.Location = new Point(368, 507);
            container.Name = "container";
            container.Size = new Size(259, 79);
            container.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(current);
            panel1.Location = new Point(185, 13);
            panel1.Name = "panel1";
            panel1.Size = new Size(72, 42);
            panel1.TabIndex = 0;
            // 
            // current
            // 
            current.BackColor = SystemColors.ActiveCaptionText;
            current.Font = new Font("Microsoft Sans Serif", 16.2F);
            current.ForeColor = Color.Gold;
            current.Location = new Point(0, 0);
            current.Name = "current";
            current.Size = new Size(100, 23);
            current.TabIndex = 0;
            current.Text = "1  _";
            // 
            // floor3Btn
            // 
            floor3Btn.AccessibleName = "4";
            floor3Btn.Location = new Point(0, 0);
            floor3Btn.Name = "floor3Btn";
            floor3Btn.Size = new Size(75, 23);
            floor3Btn.TabIndex = 1;
            floor3Btn.Text = "4";
            floor3Btn.Click += button_Click;
            // 
            // floor2Btn
            // 
            floor2Btn.AccessibleName = "3";
            floor2Btn.Location = new Point(0, 0);
            floor2Btn.Name = "floor2Btn";
            floor2Btn.Size = new Size(75, 23);
            floor2Btn.TabIndex = 2;
            floor2Btn.Text = "3";
            floor2Btn.Click += button_Click;
            // 
            // floor1Btn
            // 
            floor1Btn.AccessibleName = "2";
            floor1Btn.Location = new Point(0, 0);
            floor1Btn.Name = "floor1Btn";
            floor1Btn.Size = new Size(75, 23);
            floor1Btn.TabIndex = 3;
            floor1Btn.Text = "2";
            floor1Btn.Click += button_Click;
            // 
            // groundBtn
            // 
            groundBtn.AccessibleName = "1";
            groundBtn.Location = new Point(0, 0);
            groundBtn.Name = "groundBtn";
            groundBtn.Size = new Size(75, 23);
            groundBtn.TabIndex = 4;
            groundBtn.Text = "1";
            groundBtn.Click += button_Click;
            // 
            // ElevatorManage
            // 
            ClientSize = new Size(815, 602);
            Controls.Add(container);
            Controls.Add(Ground);
            Controls.Add(Floor1);
            Controls.Add(Floor2);
            Controls.Add(Floor3);
            Name = "ElevatorManage";
            Text = "Elevator Manage";
            Load += Form1_Load;
            Floor3.ResumeLayout(false);
            Floor2.ResumeLayout(false);
            Floor1.ResumeLayout(false);
            Ground.ResumeLayout(false);
            Elevator.ResumeLayout(false);
            container.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel Floor3;
        private System.Windows.Forms.Panel Floor2;
        private System.Windows.Forms.Panel Floor1;
        private System.Windows.Forms.Panel Ground;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel Elevator;
        private System.Windows.Forms.Button F1;
        private System.Windows.Forms.Button F2;
        private System.Windows.Forms.Button F3;
        private System.Windows.Forms.Button G;
        private System.Windows.Forms.Panel Door;
        private System.Windows.Forms.Panel container;
        private System.Windows.Forms.Button groundBtn;
        private System.Windows.Forms.Button floor3Btn;
        private System.Windows.Forms.Button floor2Btn;
        private System.Windows.Forms.Button floor1Btn;
        private System.Windows.Forms.Label current;
        private System.Windows.Forms.Panel panel1;
    }
}
