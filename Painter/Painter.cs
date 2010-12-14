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
        bool drawSquare = false;
        bool drawCircle = false;
        bool drawLine = false;
        int brushSize = 1;
        Pen pen;
        Brush brush;
        Point startLocation;
        Graphics graphic;
        Bitmap drawing;
        Rectangle selectionRectangle;
        string brushType;
        private System.Drawing.Bitmap myBitmap;
        int clickA1;
        int clickA2;
        int clickB1;
        int clickB2;
        Point point1;
        Point point2;


        public Painter()
        {
            InitializeComponent();
            drawing = new Bitmap(this.Width, this.Height);
            graphic = Graphics.FromImage(this.drawing);
            pen = new Pen(Color.Black);
            brushType = "pen";
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
            if (brushType == "square")
            {
                clickA1 = e.X;
                clickA2 = e.Y;
                drawSquare = true;
            }
            if (brushType == "circle")
            {
                clickA1 = e.X;
                clickA2 = e.Y;
                drawCircle = true;
            }
            if (brushType == "line")
            {
                point1 = e.Location;
                drawLine = true;
            }
        }

        private void Painter_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;
            if (brushType == "square" && drawSquare == true)
            {
                clickB1 = Math.Abs(clickA1 - e.X);
                clickB2 = Math.Abs(clickA2 - e.Y);
                graphic.DrawRectangle(pen, clickA1, clickA2, clickB1, clickB2);
                drawSquare = false;
            }
            if (brushType == "circle" && drawCircle == true)
            {
                clickB1 = Math.Abs(clickA1 - e.X);
                clickB2 = Math.Abs(clickA2 - e.Y);
                graphic.DrawEllipse(pen, clickA1, clickA2, clickB1, clickB2);
                drawCircle = false;
            }
            if (brushType == "line" && drawLine == true)
            {
                point2 = e.Location;
                graphic.DrawLine(pen, point1, point2);
                drawLine = false;
                //point2 = 0;
            }
        }

        private void Painter_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint)
            {
                if (brushType == "pen")
                {
                    graphic.DrawLine(pen, startLocation, e.Location);
                    startLocation = e.Location;
                }
                if (brushType == "square")
                {

                }
                this.Refresh();
            }
        }

        private void Bigger_Click(object sender, EventArgs e)
        {
            if (brushSize < 20)
            {
                brushSize = brushSize + 1;
                pen.Width = brushSize;
            }
        }

        private void Smaller_Click(object sender, EventArgs e)
        {
            if (brushSize > 1)
            {
                brushSize = brushSize - 1;
                pen.Width = brushSize;
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
            pen.Color = colorDialog1.Color;
        }

        private void buttonPen_Click(object sender, EventArgs e)
        {
            brushType = "pen";
        }


        private void buttonSquare_Click(object sender, EventArgs e)
        {
            brushType = "square";
        }

        private void buttonCircle_Click(object sender, EventArgs e)
        {
            brushType = "circle";
        }

        private void buttonLine_Click(object sender, EventArgs e)
        {
            brushType = "line";
        }
    }
}
