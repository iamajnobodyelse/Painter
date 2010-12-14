namespace Painter
{
    partial class Painter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.New = new System.Windows.Forms.Button();
            this.buttonPen = new System.Windows.Forms.Button();
            this.buttonSquare = new System.Windows.Forms.Button();
            this.buttonCircle = new System.Windows.Forms.Button();
            this.buttonLine = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.ChooseColor = new System.Windows.Forms.Button();
            this.Bigger = new System.Windows.Forms.Button();
            this.Smaller = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // New
            // 
            this.New.Location = new System.Drawing.Point(0, 0);
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(91, 28);
            this.New.TabIndex = 1;
            this.New.Text = "New";
            this.New.UseVisualStyleBackColor = true;
            this.New.Click += new System.EventHandler(this.New_Click);
            // 
            // buttonPen
            // 
            this.buttonPen.Location = new System.Drawing.Point(98, 0);
            this.buttonPen.Name = "buttonPen";
            this.buttonPen.Size = new System.Drawing.Size(91, 28);
            this.buttonPen.TabIndex = 2;
            this.buttonPen.Text = "Pen";
            this.buttonPen.UseVisualStyleBackColor = true;
            this.buttonPen.Click += new System.EventHandler(this.buttonPen_Click);
            // 
            // buttonSquare
            // 
            this.buttonSquare.Location = new System.Drawing.Point(196, 0);
            this.buttonSquare.Name = "buttonSquare";
            this.buttonSquare.Size = new System.Drawing.Size(91, 28);
            this.buttonSquare.TabIndex = 3;
            this.buttonSquare.Text = "Square";
            this.buttonSquare.UseVisualStyleBackColor = true;
            this.buttonSquare.Click += new System.EventHandler(this.buttonSquare_Click);
            // 
            // buttonCircle
            // 
            this.buttonCircle.Location = new System.Drawing.Point(294, 0);
            this.buttonCircle.Name = "buttonCircle";
            this.buttonCircle.Size = new System.Drawing.Size(91, 28);
            this.buttonCircle.TabIndex = 4;
            this.buttonCircle.Text = "Circle";
            this.buttonCircle.UseVisualStyleBackColor = true;
            this.buttonCircle.Click += new System.EventHandler(this.buttonCircle_Click);
            // 
            // buttonLine
            // 
            this.buttonLine.Location = new System.Drawing.Point(392, 0);
            this.buttonLine.Name = "buttonLine";
            this.buttonLine.Size = new System.Drawing.Size(91, 28);
            this.buttonLine.TabIndex = 5;
            this.buttonLine.Text = "Line";
            this.buttonLine.UseVisualStyleBackColor = true;
            this.buttonLine.Click += new System.EventHandler(this.buttonLine_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(490, 0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(91, 28);
            this.button6.TabIndex = 6;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(588, 0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(91, 28);
            this.button7.TabIndex = 7;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // ChooseColor
            // 
            this.ChooseColor.Location = new System.Drawing.Point(0, 396);
            this.ChooseColor.Name = "ChooseColor";
            this.ChooseColor.Size = new System.Drawing.Size(91, 28);
            this.ChooseColor.TabIndex = 8;
            this.ChooseColor.Text = "Choose Color";
            this.ChooseColor.UseVisualStyleBackColor = true;
            this.ChooseColor.Click += new System.EventHandler(this.ChooseColor_Click);
            // 
            // Bigger
            // 
            this.Bigger.Font = new System.Drawing.Font("Arial", 14F);
            this.Bigger.Location = new System.Drawing.Point(108, 396);
            this.Bigger.Name = "Bigger";
            this.Bigger.Size = new System.Drawing.Size(41, 28);
            this.Bigger.TabIndex = 9;
            this.Bigger.Text = "+";
            this.Bigger.UseVisualStyleBackColor = true;
            this.Bigger.Click += new System.EventHandler(this.Bigger_Click);
            // 
            // Smaller
            // 
            this.Smaller.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Smaller.Location = new System.Drawing.Point(155, 396);
            this.Smaller.Name = "Smaller";
            this.Smaller.Size = new System.Drawing.Size(41, 28);
            this.Smaller.TabIndex = 10;
            this.Smaller.Text = "-";
            this.Smaller.UseVisualStyleBackColor = true;
            this.Smaller.Click += new System.EventHandler(this.Smaller_Click);
            // 
            // Painter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(691, 422);
            this.Controls.Add(this.Smaller);
            this.Controls.Add(this.Bigger);
            this.Controls.Add(this.ChooseColor);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.buttonLine);
            this.Controls.Add(this.buttonCircle);
            this.Controls.Add(this.buttonSquare);
            this.Controls.Add(this.buttonPen);
            this.Controls.Add(this.New);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Painter";
            this.Text = "Painter";
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Painter_MouseUp);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Painter_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Painter_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Painter_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button New;
        private System.Windows.Forms.Button buttonPen;
        private System.Windows.Forms.Button buttonSquare;
        private System.Windows.Forms.Button buttonCircle;
        private System.Windows.Forms.Button buttonLine;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button ChooseColor;
        private System.Windows.Forms.Button Bigger;
        private System.Windows.Forms.Button Smaller;
    }
}

