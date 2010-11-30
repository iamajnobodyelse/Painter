using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Painter
{
    public partial class Painter : Form
    {
        bool paint = false;
        SolidBrush color;
        int brushSize = 2;

        public Painter()
        {
            InitializeComponent();
        }

        private void ChooseColor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
        }

        private void New_Click(object sender, EventArgs e)
        {
            Graphics graphica = panel1.CreateGraphics();
            graphica.Clear(panel1.BackColor);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint)
            color = new SolidBrush(Color.Black);
            Graphics graphic = panel1.CreateGraphics();
            graphic.FillRectangle(color, e.X, e.Y, brushSize, brushSize);
            graphic.Dispose();
        }

        private void Bigger_Click(object sender, EventArgs e)
        {
            if (brushSize < 20)
                brushSize = brushSize + 2;
        }

        private void Smaller_Click(object sender, EventArgs e)
        {
            if (brushSize > 2)
                brushSize = brushSize - 2;
        }

    }
}
