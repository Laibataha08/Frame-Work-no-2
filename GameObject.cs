using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.Drawing;


namespace WindowsFormsApp4
{
    class GameObject
    {
        Movement move;

        PictureBox pictureBox;
        public int speed;
        Movement movement;

        public GameObject(PictureBox pictureBox , Movement movement , int speed)
        {
            this.pictureBox = pictureBox;
            this.movement = movement;
            this.speed = speed;
        }

        public void updateposition()
        {
            move = movement;
            move.typeofmovement(speed, pictureBox);    
        }
       
    }
}
