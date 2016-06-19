using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tank
{
    class Tank : Object
    {
        private bool up;
        private bool down;
        private bool left;
        private bool right;
        private bool animate_type;
        private int speed = 2;
        private System.Windows.Forms.ImageList imageList;
        /*
        private bool direction;
        private ImageList[][][] imageList_type;
        private ImageList[][][] imageList_explode_type;
        private int color;
        private int level;
        private int speed;
        private int ammo;
        */

        public Tank(System.Windows.Forms.ImageList imageList)
        {
            this.imageList = imageList;
            this.animate_type = false;
            this.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        public bool Up
        {
            get { return up; }
            set { up = value; }
        }
        public bool Down
        {
            get { return down; }
            set { down = value; }
        }
        public bool Right
        {
            get { return right; }
            set { right = value; }
        }
        public bool Left_c
        {
            get { return left; }
            set { left = value; }
        }

        public void MoveUp()
        {
            this.Top -= speed;
            this.Image = (animate_type) ? imageList.Images[0] : imageList.Images[1];
            animate_type = (animate_type) ? false : true;
        }

        public void MoveDown()
        {
            this.Top += speed;
            this.Image = (animate_type) ? imageList.Images[2] : imageList.Images[3];
            animate_type = (animate_type) ? false : true;
        }

        public void MoveLeft()
        {
            this.Left -= speed;
            this.Image = (animate_type) ? imageList.Images[4] : imageList.Images[5];
            animate_type = (animate_type) ? false : true;
        }

        public void MoveRight()
        {
            this.Left += speed;
            this.Image = (animate_type) ? imageList.Images[6] : imageList.Images[7];
            animate_type = (animate_type) ? false : true;
        }

        public bool collition()
        {
            return true;
        }
        public void fire()
        { 
        }
        public void upgrade()
        {
 
        }
    }
}
