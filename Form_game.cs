using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace Tank
{
    public partial class Form_game : Form
    {
        private Form_stage form_stage;
        private Tank[] player;
        private int number;
        private KeyEventArgs repeat;
        private ImageList[][][] imageList;
        
        public Form_game(Form_stage form_stage, int number)
        {
            InitializeComponent();
            this.form_stage = form_stage;
            this.number = number;
            player = new Tank[4];
            //imageList = new ImageList[4][][];
        }

        private void Form_game_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < number; i++)
            {
                player[i] = new Tank(imageList1);
                this.Controls.Add(player[i]);
            }
            //this.BackColor = System.Drawing.Color.Black;
        }

        private void Form_game_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void Form_game_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Equals(repeat))
            {
                return;
            }
            repeat = e;
            switch (e.KeyCode)
            {
                case Keys.Left:
                    player[0].Left_c=true;
                    break;
                case Keys.Right:
                    player[0].Right=true;
                    break;
                case Keys.Down:
                    player[0].Down=true;
                    break;
                case Keys.Up:
                    player[0].Up=true;
                    break;
                case Keys.A:
                    player[1].Left_c=true;
                    break;
                case Keys.D:
                    player[1].Right=true;
                    break;
                case Keys.S:
                    player[1].Down=true;
                    break;
                case Keys.W:
                    player[1].Up=true;
                    break;
            }
            PlayerMove();
            timer_move.Start();
        }

        private void Form_game_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    player[0].Left_c=false;
                    break;
                case Keys.Right:
                    player[0].Right=false;
                    break;
                case Keys.Down:
                    player[0].Down=false;
                    break;
                case Keys.Up:
                    player[0].Up=false;
                    break;
                case Keys.A:
                    player[1].Left_c=false;
                    break;
                case Keys.D:
                    player[1].Right=false;
                    break;
                case Keys.S:
                    player[1].Down=false;
                    break;
                case Keys.W:
                    player[1].Up=false;
                    break;
            }

            if (!(player[0].Down || player[0].Left_c || player[0].Right || player[0].Up ||
                player[1].Left_c || player[1].Right || player[1].Down || player[1].Up))
            {
                timer_move.Stop();
            }
        }

        private void timer_move_Tick(object sender, EventArgs e)
        {
            PlayerMove();
        }

        private void PlayerMove()
        {
            if (player[0].Down) player[0].MoveDown();
            if (player[0].Left_c) player[0].MoveLeft();
            if (player[0].Right) player[0].MoveRight();
            if (player[0].Up) player[0].MoveUp();
            if (player[1].Down) player[1].MoveDown();
            if (player[1].Left_c) player[1].MoveLeft();
            if (player[1].Right) player[1].MoveRight();
            if (player[1].Up) player[1].MoveUp();
        }
    }
}
