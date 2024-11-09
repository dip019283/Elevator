using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dipesh_lift_system
{
    class Door
    {
        // open down door
        public void OpenDoor(PictureBox Up_Left_Door, PictureBox Up_Right_Door, PictureBox Down_Left_Door, PictureBox Down_Right_Door)
        {
            if (Down_Left_Door.Width > 0 && Down_Right_Door.Width > 0)
            {
                // Reduce the width of Down_Left_Door by 5 units.
                Down_Left_Door.Width -= 5;

                // Reduce the width of the PictureBox while keeping the left edge fixed.
                int newWidth = Down_Right_Door.Width - 5;
                // Move the left edge of Down_Right_Door to keep it fixed while reducing the width.
                Down_Right_Door.Left += Down_Right_Door.Width - newWidth;
                // Update the width of Down_Right_Door to the new value.
                Down_Right_Door.Width = newWidth;
            }

        }
        //open up door
        public void OpenDoor1(PictureBox Up_Left_Door, PictureBox Up_Right_Door, PictureBox Down_Left_Door, PictureBox Down_Right_Door)
        {

            if (Up_Left_Door.Width > 0 && Up_Right_Door.Width > 0)
            {
                // Reduce the width of Up_Left_Door by 5 units.
                Up_Left_Door.Width -= 5;

                // Reduce the width of the PictureBox while keeping the right edge fixed.
                int newWidth = Up_Right_Door.Width - 5;
                // Move the left edge of Up_Right_Door to keep it fixed while reducing the width.
                Up_Right_Door.Left += Up_Right_Door.Width - newWidth;
                // Update the width of Down_Right_Door to the new value.
                Up_Right_Door.Width = newWidth;


            }
        }
        //close down door
        public void CloseDoor(PictureBox Up_Left_Door, PictureBox Up_Right_Door, PictureBox Down_Left_Door, PictureBox Down_Right_Door)
        {

            // Increase the width of the PictureBox while keeping the left edge fixed.

            if (Down_Left_Door.Width < 117 && Down_Right_Door.Width < 117)
            {
                int newWidth = Down_Left_Door.Width + 5;
                Down_Left_Door.Width = newWidth;
                // Calculate the new width for Down_right_Door by increasing it by 5 units.
                int newWidth2 = Down_Right_Door.Width + 5;
                // Move the left edge of Down_Right_Door to keep it fixed while increasing the width.
                Down_Right_Door.Left -= newWidth2 - Down_Right_Door.Width;
                // Update the width of Down_Right_Door to the new value.
                Down_Right_Door.Width = newWidth2;
            }
        }

        // close up door
        public void CloseDoor1(PictureBox Up_Left_Door, PictureBox Up_Right_Door, PictureBox Down_Left_Door, PictureBox Down_Right_Door)
        {

            if (Up_Left_Door.Width < 117 && Up_Right_Door.Width < 117)
            {
                // Increase the width of the PictureBox while keeping the left edge fixed.
                int newWidth = Up_Left_Door.Width + 5;
                Up_Left_Door.Width = newWidth;
                // Calculate the new width for up_right_Door by increasing it by 5 units.
                int newWidth2 = Up_Right_Door.Width + 5;
                // Move the left edge of up_Right_Door to keep it fixed while increasing the width.
                Up_Right_Door.Left -= newWidth2 - Up_Right_Door.Width;
                // Update the width of up_Right_Door to the new value.
                Up_Right_Door.Width = newWidth2;
            }


        }
    }
}
