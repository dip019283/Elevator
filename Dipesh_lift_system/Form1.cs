
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Dipesh_lift_system
{
    public partial class Form1 : Form
    {
        // Create a Door object to control door actions
        Door dr = new Door();

        Elevator elevator = new Elevator();

        // Flags to track if the elevator has arrived at the ground or first floor
        bool arrived_G = false;
        bool arrived_1 = false;

        // Flags to track if the elevator should go up or down
        bool go_up = false;
        bool go_down = false;

        // Counter variable to track door open time
        int increment = 0;

        // Create a DatabaseConnection object to log events to the database
        DatabaseConnection dbconn = new DatabaseConnection();

        // Constructor to initialize the form components
        public Form1()
        {
            InitializeComponent();
        }

        // A delegate to represent any door action method
        public delegate void DoorAction();

        // Timer event for opening ground floor doors
        private void timer_Down_doorOpen_Tick(object sender, EventArgs e)
        {
            // Calls PerformDoorAction to open the ground floor doors
            PerformDoorAction(() => dr.OpenDoor(Up_Left_Door, Up_Right_Door, Down_Left_Door, Down_Right_Door));
        }

        // Timer event for opening first floor doors
        private void timer_Up_dooropen_Tick(object sender, EventArgs e)
        {
            // Calls PerformDoorActions to open the first floor doors
            PerformDoorActions(() => dr.OpenDoor1(Up_Left_Door, Up_Right_Door, Down_Left_Door, Down_Right_Door));
        }

        // Method to handle ground floor door opening actions
        private void PerformDoorAction(DoorAction doorAction)
        {
            // Check if the doors are partially open
            if (Down_Left_Door.Width > 0 && Down_Right_Door.Width > 0)
            {
                // Execute the provided door action delegate to open the doors
                doorAction();

                // Enable the button for floor 1 and the up button
                button_1.Enabled = true;
                Up_button.Enabled = true;
            }
            else
            {
                // If doors are fully open, start automatic door close timer
                Automatic_Close_The_Door.Enabled = true;

                // Stop the ground floor door opening timer
                timer_Down_doorOpen.Enabled = false;

                // Log the door opening event and display data
                dbconn.Insert("Ground Floor Door is Opened");

                // Show the latest data (events or logs)
                DisplayData();

                // Enable the floor buttons
                Up_button.Enabled = true;
                Down_button.Enabled = true;
                button_G.Enabled = true;

                // Reset colors for button states
                button_G.BackColor = Color.White;
                btn_open.BackColor = Color.White;
                btn_close.BackColor = Color.White;

                // Continue with automatic door closing
                Automatic_Close_The_Door.Enabled = true;
            }
        }

        // Method to handle first floor door opening actions
        private void PerformDoorActions(DoorAction doorAction)
        {
            // Check if the first floor doors are partly open
            if (Up_Left_Door.Width > 0 && Up_Right_Door.Width > 0)
            {
                // If yes, perform the door action to open them fully
                dr.OpenDoor1(Up_Left_Door, Up_Right_Door, Down_Left_Door, Down_Right_Door);
                //button_1.Enabled = true;

                // Reset the color of the up button to white
                Up_button.BackColor = Color.White;

            }
            else
            {
                // If doors are fully open, stop the first floor door opening timer
                timer_Up_dooropen.Enabled = false;

                // Start automatic door close timer
                Automatic_Close_The_Door.Enabled = true;

                // Log "First Floor Door is opened" in the database
                dbconn.Insert("First Floor Door is opened");

                // Show the latest data (events or logs)
                DisplayData();

                // Enable the floor buttons
                button_G.Enabled = true;
                button_1.Enabled = true;

                // Start automatic door closing
                Automatic_Close_The_Door.Enabled = true;

                // Start automatic door closing
                btn_open.BackColor = Color.White;
                button_1.BackColor = Color.White;
                btn_close.BackColor = Color.White;

            }
        }

        // Timer event for closing the first-floor doors
        private void timer_Up_doorclose_Tick(object sender, EventArgs e)
        {
            // If first-floor doors are not fully closed
            if (Up_Left_Door.Width < 117 && Up_Right_Door.Width < 117)
            {
                // Close first-floor doors
                dr.CloseDoor1(Up_Left_Door, Up_Right_Door, Down_Left_Door, Down_Right_Door);

            }
            else
            {
                // Disable automatic door closing and reset increment counter
                Automatic_Close_The_Door.Enabled = false;
                increment = 0;

                // Stop first-floor door close timer
                timer_Up_doorclose.Enabled = false;

                // Log "First Floor Door is closed" to database and refresh display
                dbconn.Insert("First Floor Door is closed");
                DisplayData();

                // Reset button color to indicate door closed
                btn_close.BackColor = Color.White;

                // If lift needs to go down
                if (go_down == true)
                {
                    Automatic_Close_The_Door.Enabled = false;
                    increment = 0;


                    pictureBox5.Image = global::Dipesh_lift_system.Properties.Resources.down_2;
                    Up_pictureBox.Image = global::Dipesh_lift_system.Properties.Resources.down_2;
                    Down_pictureBox.Image = global::Dipesh_lift_system.Properties.Resources.down_2;

                    // Enable lift movement downwards
                    Lift_GoingDown.Enabled = true;

                    // Log lift movement to database
                    dbconn.Insert("Lift is Going Down");
                    DisplayData();

                    // Reset go_down flag and button color
                    go_down = false;
                    btn_close.BackColor = Color.White;
                }

            }
        }


        // Timer event for closing ground floor doors
        private void timer_Down_doorClose_Tick(object sender, EventArgs e)
        {

            // If ground floor doors are not fully closed
            if (Down_Left_Door.Width < 117 && Down_Right_Door.Width < 117)
            {
                // Close ground floor doors
                dr.CloseDoor(Up_Left_Door, Up_Right_Door, Down_Left_Door, Down_Right_Door);
            }
            else
            {
                // Reset counter and disable automatic door close timer
                increment = 0;
                Automatic_Close_The_Door.Enabled = false;

                // Stop ground floor door close timer
                timer_Down_doorClose.Enabled = false;
                dbconn.Insert("Ground Floor Door is Closed");

                // Log "Ground Floor Door is Closed" and refresh display
                DisplayData();

                // Reset button color
                btn_close.BackColor = Color.White;

                // If lift needs to go up
                if (go_up == true)
                {
                    // Update lift direction icons to up
                    pictureBox5.Image = global::Dipesh_lift_system.Properties.Resources.up_2;
                    Up_pictureBox.Image = global::Dipesh_lift_system.Properties.Resources.up_2;
                    Down_pictureBox.Image = global::Dipesh_lift_system.Properties.Resources.up_2;

                    // Enable lift movement upwards
                    Lift_GoingUp.Enabled = true;

                    // Log lift movement to database
                    dbconn.Insert("Lift is Going Up");
                    DisplayData();

                    // Reset go_up flag
                    go_up = false;
                }
            }
        }


        // Timer event to move lift upwards
        private void Lift_GoingUp_Tick(object sender, EventArgs e)
        {
            // Get the target Y position for the lift
            int targetY = Liftup.Location.Y;

            // If lift hasn't reached target
            if (Lift.Top > targetY)
            {
                // Move lift up and update button states
                elevator.UpLift(Lift, Liftup);
                Up_button.BackColor = Color.Red;
                button_G.Enabled = false;
                button_G.BackColor = Color.White;
                Down_button.Enabled = true;
            }
            else
            {
                // Stop lift movement and enable first-floor door open timer
                Lift_GoingUp.Enabled = false;
                timer_Up_dooropen.Enabled = true;
                timer_Up_doorclose.Enabled = false;
                arrived_1 = true;

                // Enable buttons and update display
                Up_button.BackColor = Color.White;
                btn_open.Enabled = true;
                btn_close.Enabled = true;
                pictureBox5.Image = global::Dipesh_lift_system.Properties.Resources._1;
                Up_pictureBox.Image = global::Dipesh_lift_system.Properties.Resources._1;
                Down_pictureBox.Image = global::Dipesh_lift_system.Properties.Resources._1;
            }
        }

        // Timer event to move lift downwards
        private void Lift_GoingDown_Tick(object sender, EventArgs e)
        {
            // Set target Y position for lift
            int targetY = pictureBox3.Location.Y;

            // If lift hasn't reached target
            if (Lift.Bottom < targetY + pictureBox3.Height)
            {
                // Move lift down and update button states
                elevator.DownLift(Lift, pictureBox3);
                Down_button.BackColor = Color.Red;
                btn_close.Enabled = false;
                btn_open.Enabled = false;
            }
            else
            {
                // Stop lift movement and enable ground floor door open timer
                Lift_GoingDown.Enabled = false;
                Down_button.Enabled = true;
                button_1.Enabled = false;
                button_G.Enabled = true;

                // Enable buttons and update display
                Up_button.Enabled = false;
                timer_Down_doorOpen.Enabled = true;
                timer_Down_doorClose.Enabled = false;
                arrived_G = true;

                Down_button.BackColor = Color.White;
                Down_button.BackColor = Color.White;
                btn_open.Enabled = true;
                btn_close.Enabled = true;
                pictureBox5.Image = global::Dipesh_lift_system.Properties.Resources._G;
                Up_pictureBox.Image = global::Dipesh_lift_system.Properties.Resources._G;
                Down_pictureBox.Image = global::Dipesh_lift_system.Properties.Resources._G;


            }
        }

        // Button click to open doors
        private void btn_open_Click(object sender, EventArgs e)
        {
            // Change button color to indicate door is opening
            btn_open.BackColor = Color.Red;

            // Check if elevator is on ground or first floor and enable respective door timer
            if (arrived_G == true)
            {
                timer_Down_doorOpen.Enabled = true;
                timer_Down_doorClose.Enabled = false;
            }
            else if (arrived_1 == true)
            {
                timer_Up_dooropen.Enabled = true;
                timer_Up_doorclose.Enabled = false;
            }

        }

        // Button click to close doors
        private void btn_close_Click(object sender, EventArgs e)
        {
            // Change button color to indicate door is closing
            btn_close.BackColor = Color.Red;

            // Check if elevator is on ground or first floor and enable respective door close timer
            if (arrived_G == true)
            {
                timer_Down_doorClose.Enabled = true;
                timer_Down_doorOpen.Enabled = false;
            }
            else if (arrived_1 == true)
            {
                timer_Up_doorclose.Enabled = true;
                timer_Up_dooropen.Enabled = false;
            }

        }

        // Button click to go up to first floor
        private void button_1_Click(object sender, EventArgs e)
        {
            // Change button color and disable ground floor button
            button_1.BackColor = Color.Red;
            arrived_G = false;
            go_up = true;

            // Enable ground floor door close timer and disable open timer
            timer_Down_doorClose.Enabled = true;
            timer_Down_doorOpen.Enabled = false;
            button_G.Enabled = false;

        }

        // Button click to go down to ground floor
        private void button_G_Click(object sender, EventArgs e)
        {
            // Change button color and disable first-floor button
            button_G.BackColor = Color.Red;
            arrived_1 = false;
            arrived_G = true;
            go_down = true;

            // Enable first-floor door close timer and disable open timer
            timer_Up_doorclose.Enabled = true;
            timer_Up_dooropen.Enabled = false;
            button_1.Enabled = false;

        }

        // Button click to go up from ground floor
        private void Up_button_Click(object sender, EventArgs e)
        {
            // Change button color and disable down button
            Up_button.BackColor = Color.Red;
            go_up = true;

            // Enable ground floor door close timer and disable open timer
            timer_Down_doorClose.Enabled = true;
            timer_Down_doorOpen.Enabled = false;
            arrived_G = false;
            Down_button.Enabled = false;
            button_G.Enabled = false;

        }

        // Button click to go down from first floor
        private void Down_button_Click(object sender, EventArgs e)
        {
            // Change button color and disable up button
            Down_button.BackColor = Color.Red;
            go_down = true;

            // Enable first-floor door close timer and disable open timer
            timer_Up_doorclose.Enabled = true;
            timer_Up_dooropen.Enabled = false;
            arrived_1 = false;
            Up_button.Enabled = false;
            button_G.Enabled = false;
        }

        // Timer event for automatic door closing after delay
        private void Automatic_Close_The_Door_Tick(object sender, EventArgs e)
        {
            increment++;
            if (increment >= 240 && arrived_G == true)
            {
                timer_Down_doorClose.Enabled = true;
            }
            else if (increment >= 240 && arrived_1 == true)
            {
                timer_Up_doorclose.Enabled = true;
            }
        }

        // Display data in grid view
        public void DisplayData()
        {
            try
            {
                DatabaseConnection dbconn = new DatabaseConnection();
                DataTable dt = dbconn.Display_AllData();
                dataGridView1.DataSource = dt;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // This line makes columns fill the DataGridView width
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Elevator Control");
            }
        }

        // Button click to clear data
        private void Clear_btn_Click(object sender, EventArgs e)
        {
            // 1. It calls a method named 'Remove' (possibly to clear or remove data, but the exact functionality depends on the implementation of the 'Remove' method).
            dbconn.Remove();
            // 2. It calls a method named 'DisplayData' (possibly to refresh or redisplay data, but this depends on the 'DisplayData' method's implementation).
            DisplayData();

        }

        // This event handler is triggered when a button (likely named "Exit") is clicked.
        // It is used to close the current form or application, effectively exiting the program.

        // Close the form or application
        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

 

        private void Up_Right_Door_Click(object sender, EventArgs e)
        {

        }

        private void Up_Left_Door_Click(object sender, EventArgs e)
        {

        }

        private void Down_Right_Door_Click(object sender, EventArgs e)
        {

        }

        private void Down_Left_Door_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }
    }
}
