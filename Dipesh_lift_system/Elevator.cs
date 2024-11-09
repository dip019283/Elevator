using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dipesh_lift_system
{
    internal class Elevator
    {
        // This method is responsible for moving a lift (represented by the 'Lift' PictureBox)
        // upwards to reach a specified target position (represented by the 'Liftup' PictureBox).

        public void UpLift(PictureBox Lift, PictureBox Liftup)
        {
            // Get the target Y coordinate from the Liftup PictureBox's location.
            int targetY = Liftup.Location.Y;

            if (Lift.Top > targetY)
            {
                // Move PictureBox up (decrease Top) until it reaches the target
                Lift.Top -= 5;
            }
            else
            {
                // Stop the timer when PictureBox reaches the target location

            }
        }
        // This method is responsible for moving a lift (represented by the 'Lift' PictureBox)
        // downwards to reach a specified target position (represented by the 'pictureBox3' PictureBox).
        public void DownLift(PictureBox Lift, PictureBox pictureBox3)
        {
            // Get the target Y coordinate from the Liftdown PictureBox's location.
            int targetY = pictureBox3.Location.Y;

            if (Lift.Bottom < targetY + pictureBox3.Height)
            {
                // Move PictureBox2 down (increase Top) until it reaches the target
                Lift.Top += 5;
            }
            else
            {
                // Stop the timer when PictureBox2 reaches the target location
            }
        }
    }
}
