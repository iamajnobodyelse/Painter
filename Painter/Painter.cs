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
        int brushSize = 1;
        Pen color;
        Point startLocation;
        Graphics graphic;
        Bitmap drawing;
        Rectangle selectionRectangle;
        Color colorChoice;
        private System.Drawing.Bitmap myBitmap;


        public Painter()
        {
            InitializeComponent();
            drawing = new Bitmap(this.Width, this.Height);
            graphic = Graphics.FromImage(this.drawing);
            color = new Pen(Color.Black);
            Graphics.FromImage(this.drawing);
            //selectionRectangle = new Rectangle(10, 10, 100, 100);
        }

        private void Painter_Load(object sender, EventArgs e)
        {


        }

        private void New_Click(object sender, EventArgs e)
        {
            graphic.Clear(Color.White);
            this.Refresh();
        }

        private void Painter_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            startLocation = e.Location;
        }

        private void Painter_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;
        }

        private void Painter_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint)
            {
                graphic.DrawLine(color, startLocation, e.Location);
                startLocation = e.Location;
                this.Refresh();
            }
        }

        private void Bigger_Click(object sender, EventArgs e)
        {
            if (brushSize < 20)
            {
                brushSize = brushSize + 1;
                color.Width = brushSize;
            }
        }

        private void Smaller_Click(object sender, EventArgs e)
        {
            if (brushSize > 1)
            {
                brushSize = brushSize - 1;
                color.Width = brushSize;
            }

        }

        private void Painter_Paint(object sender, PaintEventArgs e)
        {

            e.Graphics.DrawImageUnscaled(this.drawing, Point.Empty);
            //e.Graphics.DrawRectangle(color, this.selectionRectangle);
        }

        private void ChooseColor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            color.Color = colorDialog1.Color;
        }
    }
}
