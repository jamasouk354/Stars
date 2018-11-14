using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Stars
{
    public partial class Form1 : Form
    {
        Random randGen = new Random();

        //int colorGen, randomL, randomW, starSize;

        public Form1()
        {
            InitializeComponent();

           
        }

        private void startButton_Click(object sender, EventArgs e)
        {

            startButton.Visible = false;

            Graphics gr = this.CreateGraphics();
            SolidBrush drawBrush = new SolidBrush(Color.White);

            int x = 0;
            int y = 0;
            int r = 0;
            int g = 0;
            int b = 0;
            int star = 0;
            int count = 0;

            while (count < 1000)
            {
                x = randGen.Next(0, this.Width);
                y = randGen.Next(0, this.Height);
                r = randGen.Next(0, 256);
                g = randGen.Next(0, 256);
                b = randGen.Next(0, 256);
                star = randGen.Next(2, 9);

                drawBrush.Color = Color.FromArgb(r , g , b);

                gr.FillEllipse(drawBrush, x, y, star, star);
                Thread.Sleep(3);

                count++;
            }
        }
    }
}
