namespace Dipesh_lift_system
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Lift = new PictureBox();
            groupBox1 = new GroupBox();
            btn_close = new Button();
            btn_open = new Button();
            button_G = new Button();
            button_1 = new Button();
            pictureBox5 = new PictureBox();
            dataGridView1 = new DataGridView();
            Up_pictureBox = new PictureBox();
            Up_Right_Door = new PictureBox();
            Up_Left_Door = new PictureBox();
            Down_Right_Door = new PictureBox();
            Down_Left_Door = new PictureBox();
            Up_button = new Button();
            Down_button = new Button();
            Clear_btn = new Button();
            Exit = new Button();
            Down_pictureBox = new PictureBox();
            timer_Down_doorOpen = new System.Windows.Forms.Timer(components);
            timer_Down_doorClose = new System.Windows.Forms.Timer(components);
            timer_Up_dooropen = new System.Windows.Forms.Timer(components);
            timer_Up_doorclose = new System.Windows.Forms.Timer(components);
            Lift_GoingUp = new System.Windows.Forms.Timer(components);
            Lift_GoingDown = new System.Windows.Forms.Timer(components);
            Automatic_Close_The_Door = new System.Windows.Forms.Timer(components);
            Liftup = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Lift).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Up_pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Up_Right_Door).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Up_Left_Door).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Down_Right_Door).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Down_Left_Door).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Down_pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Liftup).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // Lift
            // 
            Lift.Image = (Image)resources.GetObject("Lift.Image");
            Lift.Location = new Point(45, 390);
            Lift.Name = "Lift";
            Lift.Size = new Size(236, 318);
            Lift.SizeMode = PictureBoxSizeMode.StretchImage;
            Lift.TabIndex = 1;
            Lift.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.BackgroundImage = (Image)resources.GetObject("groupBox1.BackgroundImage");
            groupBox1.BackgroundImageLayout = ImageLayout.Stretch;
            groupBox1.Controls.Add(btn_close);
            groupBox1.Controls.Add(btn_open);
            groupBox1.Controls.Add(button_G);
            groupBox1.Controls.Add(button_1);
            groupBox1.Controls.Add(pictureBox5);
            groupBox1.Location = new Point(383, 134);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(287, 434);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btn_close
            // 
            btn_close.BackgroundImage = Properties.Resources.closedoorsbutton1;
            btn_close.BackgroundImageLayout = ImageLayout.Stretch;
            btn_close.Location = new Point(149, 327);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(121, 84);
            btn_close.TabIndex = 10;
            btn_close.UseVisualStyleBackColor = true;
            btn_close.Click += btn_close_Click;
            // 
            // btn_open
            // 
            btn_open.BackgroundImage = Properties.Resources.opendoorbutton1;
            btn_open.BackgroundImageLayout = ImageLayout.Stretch;
            btn_open.Location = new Point(18, 327);
            btn_open.Name = "btn_open";
            btn_open.Size = new Size(121, 84);
            btn_open.TabIndex = 9;
            btn_open.UseVisualStyleBackColor = true;
            btn_open.Click += btn_open_Click;
            // 
            // button_G
            // 
            button_G.BackgroundImage = Properties.Resources.Groundfloorbutton;
            button_G.BackgroundImageLayout = ImageLayout.Stretch;
            button_G.Location = new Point(102, 250);
            button_G.Name = "button_G";
            button_G.Size = new Size(75, 65);
            button_G.TabIndex = 8;
            button_G.UseVisualStyleBackColor = true;
            button_G.Click += button_G_Click;
            // 
            // button_1
            // 
            button_1.BackgroundImage = Properties.Resources.firstfloorbutton;
            button_1.BackgroundImageLayout = ImageLayout.Stretch;
            button_1.Location = new Point(102, 182);
            button_1.Name = "button_1";
            button_1.Size = new Size(72, 62);
            button_1.TabIndex = 7;
            button_1.UseVisualStyleBackColor = true;
            button_1.Click += button_1_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.BackgroundImage = (Image)resources.GetObject("pictureBox5.BackgroundImage");
            pictureBox5.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox5.Location = new Point(46, 22);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(188, 150);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 6;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(718, 108);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(544, 595);
            dataGridView1.TabIndex = 3;
            // 
            // Up_pictureBox
            // 
            Up_pictureBox.Image = (Image)resources.GetObject("Up_pictureBox.Image");
            Up_pictureBox.Location = new Point(126, 0);
            Up_pictureBox.Name = "Up_pictureBox";
            Up_pictureBox.Size = new Size(73, 32);
            Up_pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            Up_pictureBox.TabIndex = 4;
            Up_pictureBox.TabStop = false;
            // 
            // Up_Right_Door
            // 
            Up_Right_Door.Image = (Image)resources.GetObject("Up_Right_Door.Image");
            Up_Right_Door.Location = new Point(163, 30);
            Up_Right_Door.Name = "Up_Right_Door";
            Up_Right_Door.Size = new Size(118, 318);
            Up_Right_Door.SizeMode = PictureBoxSizeMode.StretchImage;
            Up_Right_Door.TabIndex = 8;
            Up_Right_Door.TabStop = false;
            Up_Right_Door.Click += Up_Right_Door_Click;
            // 
            // Up_Left_Door
            // 
            Up_Left_Door.Image = (Image)resources.GetObject("Up_Left_Door.Image");
            Up_Left_Door.Location = new Point(45, 30);
            Up_Left_Door.Name = "Up_Left_Door";
            Up_Left_Door.Size = new Size(118, 318);
            Up_Left_Door.SizeMode = PictureBoxSizeMode.StretchImage;
            Up_Left_Door.TabIndex = 9;
            Up_Left_Door.TabStop = false;
            Up_Left_Door.Click += Up_Left_Door_Click;
            // 
            // Down_Right_Door
            // 
            Down_Right_Door.Image = (Image)resources.GetObject("Down_Right_Door.Image");
            Down_Right_Door.Location = new Point(163, 390);
            Down_Right_Door.Name = "Down_Right_Door";
            Down_Right_Door.Size = new Size(118, 318);
            Down_Right_Door.SizeMode = PictureBoxSizeMode.StretchImage;
            Down_Right_Door.TabIndex = 10;
            Down_Right_Door.TabStop = false;
            Down_Right_Door.Click += Down_Right_Door_Click;
            // 
            // Down_Left_Door
            // 
            Down_Left_Door.Image = (Image)resources.GetObject("Down_Left_Door.Image");
            Down_Left_Door.Location = new Point(45, 390);
            Down_Left_Door.Name = "Down_Left_Door";
            Down_Left_Door.Size = new Size(118, 318);
            Down_Left_Door.SizeMode = PictureBoxSizeMode.StretchImage;
            Down_Left_Door.TabIndex = 11;
            Down_Left_Door.TabStop = false;
            Down_Left_Door.Click += Down_Left_Door_Click;
            // 
            // Up_button
            // 
            Up_button.BackgroundImage = (Image)resources.GetObject("Up_button.BackgroundImage");
            Up_button.BackgroundImageLayout = ImageLayout.Stretch;
            Up_button.Location = new Point(287, 172);
            Up_button.Name = "Up_button";
            Up_button.Size = new Size(46, 64);
            Up_button.TabIndex = 12;
            Up_button.UseVisualStyleBackColor = true;
            Up_button.Click += Up_button_Click;
            // 
            // Down_button
            // 
            Down_button.BackgroundImage = (Image)resources.GetObject("Down_button.BackgroundImage");
            Down_button.BackgroundImageLayout = ImageLayout.Stretch;
            Down_button.Location = new Point(287, 527);
            Down_button.Name = "Down_button";
            Down_button.Size = new Size(46, 64);
            Down_button.TabIndex = 13;
            Down_button.UseVisualStyleBackColor = true;
            Down_button.Click += Down_button_Click;
            // 
            // Clear_btn
            // 
            Clear_btn.Location = new Point(742, 46);
            Clear_btn.Name = "Clear_btn";
            Clear_btn.Size = new Size(114, 37);
            Clear_btn.TabIndex = 15;
            Clear_btn.Text = "Clear";
            Clear_btn.UseVisualStyleBackColor = true;
            Clear_btn.Click += Clear_btn_Click;
            // 
            // Exit
            // 
            Exit.Location = new Point(884, 46);
            Exit.Name = "Exit";
            Exit.Size = new Size(114, 37);
            Exit.TabIndex = 16;
            Exit.Text = "Exit";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // Down_pictureBox
            // 
            Down_pictureBox.Image = (Image)resources.GetObject("Down_pictureBox.Image");
            Down_pictureBox.Location = new Point(126, 358);
            Down_pictureBox.Name = "Down_pictureBox";
            Down_pictureBox.Size = new Size(73, 32);
            Down_pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            Down_pictureBox.TabIndex = 19;
            Down_pictureBox.TabStop = false;
            // 
            // timer_Down_doorOpen
            // 
            timer_Down_doorOpen.Tick += timer_Down_doorOpen_Tick;
            // 
            // timer_Down_doorClose
            // 
            timer_Down_doorClose.Tick += timer_Down_doorClose_Tick;
            // 
            // timer_Up_dooropen
            // 
            timer_Up_dooropen.Tick += timer_Up_dooropen_Tick;
            // 
            // timer_Up_doorclose
            // 
            timer_Up_doorclose.Tick += timer_Up_doorclose_Tick;
            // 
            // Lift_GoingUp
            // 
            Lift_GoingUp.Interval = 2;
            Lift_GoingUp.Tick += Lift_GoingUp_Tick;
            // 
            // Lift_GoingDown
            // 
            Lift_GoingDown.Interval = 2;
            Lift_GoingDown.Tick += Lift_GoingDown_Tick;
            // 
            // Automatic_Close_The_Door
            // 
            Automatic_Close_The_Door.Interval = 5;
            Automatic_Close_The_Door.Tick += Automatic_Close_The_Door_Tick;
            // 
            // Liftup
            // 
            Liftup.Location = new Point(45, 30);
            Liftup.Name = "Liftup";
            Liftup.Size = new Size(236, 318);
            Liftup.TabIndex = 20;
            Liftup.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(45, 390);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(236, 318);
            pictureBox3.TabIndex = 21;
            pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1270, 707);
            Controls.Add(Down_pictureBox);
            Controls.Add(Exit);
            Controls.Add(Clear_btn);
            Controls.Add(Down_button);
            Controls.Add(Up_button);
            Controls.Add(Down_Left_Door);
            Controls.Add(Down_Right_Door);
            Controls.Add(Up_Left_Door);
            Controls.Add(Up_Right_Door);
            Controls.Add(Up_pictureBox);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(Lift);
            Controls.Add(Liftup);
            Controls.Add(pictureBox3);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)Lift).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Up_pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)Up_Right_Door).EndInit();
            ((System.ComponentModel.ISupportInitialize)Up_Left_Door).EndInit();
            ((System.ComponentModel.ISupportInitialize)Down_Right_Door).EndInit();
            ((System.ComponentModel.ISupportInitialize)Down_Left_Door).EndInit();
            ((System.ComponentModel.ISupportInitialize)Down_pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)Liftup).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox Lift;
        private GroupBox groupBox1;
        private Button btn_close;
        private Button btn_open;
        private Button button_G;
        private Button button_1;
        private PictureBox pictureBox5;
        private DataGridView dataGridView1;
        private PictureBox Up_pictureBox;
        private PictureBox Up_Right_Door;
        private PictureBox Up_Left_Door;
        private PictureBox Down_Right_Door;
        private PictureBox Down_Left_Door;
        private Button Up_button;
        private Button Down_button;
        private Button Clear_btn;
        private Button Exit;
        private PictureBox Down_pictureBox;
        
        private System.Windows.Forms.Timer timer_Down_doorOpen;
        private System.Windows.Forms.Timer timer_Down_doorClose;
        private System.Windows.Forms.Timer timer_Up_dooropen;
        private System.Windows.Forms.Timer timer_Up_doorclose;
        private System.Windows.Forms.Timer Lift_GoingUp;
        private System.Windows.Forms.Timer Lift_GoingDown;
        private System.Windows.Forms.Timer Automatic_Close_The_Door;
        private PictureBox Liftup;
        private PictureBox pictureBox3;
    }
}
