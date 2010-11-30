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
            this.panel1 = new System.Windows.Forms.Panel();
            this.New = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.ChooseColor = new System.Windows.Forms.Button();
            this.Bigger = new System.Windows.Forms.Button();
            this.Smaller = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(592, 307);
            this.panel1.TabIndex = 0;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // New
            // 
            this.New.Location = new System.Drawing.Point(0, 0);
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(78, 24);
            this.New.TabIndex = 1;
            this.New.Text = "New";
            this.New.UseVisualStyleBackColor = true;
            this.New.Click += new System.EventHandler(this.New_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(84, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 24);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(168, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(78, 24);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(252, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(78, 24);
            this.button4.TabIndex = 4;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(336, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(78, 24);
            this.button5.TabIndex = 5;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(420, 0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(78, 24);
            this.button6.TabIndex = 6;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(504, 0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(78, 24);
            this.button7.TabIndex = 7;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // ChooseColor
            // 
            this.ChooseColor.Location = new System.Drawing.Point(0, 343);
            this.ChooseColor.Name = "ChooseColor";
            this.ChooseColor.Size = new System.Drawing.Size(78, 24);
            this.ChooseColor.TabIndex = 8;
            this.ChooseColor.Text = "Choose Color";
            this.ChooseColor.UseVisualStyleBackColor = true;
            this.ChooseColor.Click += new System.EventHandler(this.ChooseColor_Click);
            // 
            // Bigger
            // 
            this.Bigger.Font = new System.Drawing.Font("Arial", 14F);
            this.Bigger.Location = new System.Drawing.Point(100, 343);
            this.Bigger.Name = "Bigger";
            this.Bigger.Size = new System.Drawing.Size(35, 24);
            this.Bigger.TabIndex = 9;
            this.Bigger.Text = "+";
            this.Bigger.UseVisualStyleBackColor = true;
            this.Bigger.Click += new System.EventHandler(this.Bigger_Click);
            // 
            // Smaller
            // 
            this.Smaller.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Smaller.Location = new System.Drawing.Point(141, 343);
            this.Smaller.Name = "Smaller";
            this.Smaller.Size = new System.Drawing.Size(35, 24);
            this.Smaller.TabIndex = 10;
            this.Smaller.Text = "-";
            this.Smaller.UseVisualStyleBackColor = true;
            this.Smaller.Click += new System.EventHandler(this.Smaller_Click);
            // 
            // Painter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 366);
            this.Controls.Add(this.Smaller);
            this.Controls.Add(this.Bigger);
            this.Controls.Add(this.ChooseColor);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.New);
            this.Controls.Add(this.panel1);
            this.Name = "Painter";
            this.Text = "Painter";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button New;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button ChooseColor;
        private System.Windows.Forms.Button Bigger;
        private System.Windows.Forms.Button Smaller;
    }
}

