using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fukusyu0531
{
    public partial class Form1 : Form
    {
        int vx = -3;
        int vy = -3;
        int itime;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
                label1.Left = vx;
                label1.Top = vy;
                 
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Text = MousePosition.X + "," + MousePosition.Y;
            Point p = PointToClient(MousePosition);

            label2.Left = -(label2.Width/2) + p.X;
            label2.Top = -(label2.Height / 2) + p.Y;
            
            label1.Left += vx;
            label1.Top += vy;

            if (label1.Left < 0)
            {
                vx = Math.Abs(vx); ;
            }
            if (label1.Top < 0)
            {
                vy = Math.Abs(vy); ;
            }
            if (label1.Left > ClientSize.Width - label1.Width)
            {
                vx = -Math.Abs(vx);
            }
            if (label1.Top > ClientSize.Height - label1.Height)
            {
                vy = -Math.Abs(vy); ;
            }

            if ((p.X >= label1.Left) && (p.X <= label1.Right) && (p.Y >= label1.Top) && (p.Y <= label1.Bottom))
            {
                timer1.Enabled = false;
            }
            else
            {
                timer1.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("" + label1.Right);  
            //MessageBox.Show("" + ClientSize.Width + "," + ClientSize.Height);
            //MessageBox.Show("" + label1.Width + "," + label1.Height);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        
    }
    
}
