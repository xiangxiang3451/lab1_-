using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const double dt = 0.01;
        double height, angle, speed;
        double t, x, y;


        double cosa, sina;
        const double g = 9.81;
        int index = -1;

        private void BtStart_Click(object sender, EventArgs e)
        {

            height = (double)EdHeight.Value;
            angle = (double)EdAngle.Value;
            speed = (double)EdSpeed.Value;

            cosa = Math.Cos(angle * Math.PI / 180);
            sina = Math.Sin(angle * Math.PI / 180);

            t = 0;
            x = 0;
            y = height;


            chart1.Series[index + 1].Points.Clear();
            chart1.Series[index + 1].Points.AddXY(x, y);



            index++;
            timer1.Start();


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            t += dt;
            x = speed * cosa * t;
            y = speed * sina * t + height - g * t * t / 2;
            chart1.Series[index].Points.AddXY(x, y);

            if (y <= 0) timer1.Stop();

        }
    }

}

