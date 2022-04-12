using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssistiveTouch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Point vector = new Point(0, 0);

        private void userControl1_Gesture(object sender, GestureEventArgs e)
        {
            listBox1.Items.Add(e.X + ":" + e.Y);

            vector.X += e.X;
            vector.Y += e.Y;

            //listBox1.Items.Add(vector.X + ":" + vector.Y);

            if (e.Gesture == GestureId.GID_END && e.X == 0 && e.Y == 0)
            {
                MessageBox.Show(vector.X + ":" + vector.Y);
            }
        }
    }
}
