using System.Drawing;

namespace budilnik
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.labirint = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelStart = new System.Windows.Forms.Label();
            this.labelFinish = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labirint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labirint
            // 
            this.labirint.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labirint.Controls.Add(this.pictureBox1);
            this.labirint.Controls.Add(this.label7);
            this.labirint.Controls.Add(this.label8);
            this.labirint.Controls.Add(this.label6);
            this.labirint.Controls.Add(this.label5);
            this.labirint.Controls.Add(this.label4);
            this.labirint.Controls.Add(this.label3);
            this.labirint.Controls.Add(this.label1);
            this.labirint.Controls.Add(this.label2);
            this.labirint.Controls.Add(this.labelStart);
            this.labirint.Controls.Add(this.labelFinish);
            this.labirint.Controls.Add(this.label9);
            this.labirint.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labirint.Location = new System.Drawing.Point(0, 3);
            this.labirint.Name = "labirint";
            this.labirint.Size = new System.Drawing.Size(386, 376);
            this.labirint.TabIndex = 22;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, -27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(402, 410);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.SkyBlue;
            this.label7.Location = new System.Drawing.Point(71, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(180, 23);
            this.label7.TabIndex = 45;
            this.label7.MouseEnter += new System.EventHandler(this.label71_MouseEnter);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.SkyBlue;
            this.label8.Location = new System.Drawing.Point(84, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(180, 23);
            this.label8.TabIndex = 44;
            this.label8.MouseEnter += new System.EventHandler(this.label71_MouseEnter);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.SkyBlue;
            this.label6.Location = new System.Drawing.Point(145, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(234, 23);
            this.label6.TabIndex = 42;
            this.label6.MouseEnter += new System.EventHandler(this.label71_MouseEnter);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.SkyBlue;
            this.label5.Location = new System.Drawing.Point(193, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 23);
            this.label5.TabIndex = 41;
            this.label5.MouseEnter += new System.EventHandler(this.label71_MouseEnter);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.SkyBlue;
            this.label4.Location = new System.Drawing.Point(71, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 23);
            this.label4.TabIndex = 40;
            this.label4.MouseEnter += new System.EventHandler(this.label71_MouseEnter);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.SkyBlue;
            this.label3.Location = new System.Drawing.Point(357, -2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 353);
            this.label3.TabIndex = 39;
            this.label3.MouseEnter += new System.EventHandler(this.label71_MouseEnter);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SkyBlue;
            this.label1.Location = new System.Drawing.Point(71, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 312);
            this.label1.TabIndex = 38;
            this.label1.MouseEnter += new System.EventHandler(this.label71_MouseEnter);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.SkyBlue;
            this.label2.Location = new System.Drawing.Point(-5, -2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 376);
            this.label2.TabIndex = 37;
            this.label2.MouseEnter += new System.EventHandler(this.label71_MouseEnter);
            // 
            // labelStart
            // 
            this.labelStart.BackColor = System.Drawing.Color.Green;
            this.labelStart.Location = new System.Drawing.Point(28, 6);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(37, 17);
            this.labelStart.TabIndex = 35;
            this.labelStart.Text = "Старт";
            this.labelStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFinish
            // 
            this.labelFinish.BackColor = System.Drawing.Color.Red;
            this.labelFinish.Location = new System.Drawing.Point(127, 21);
            this.labelFinish.Name = "labelFinish";
            this.labelFinish.Size = new System.Drawing.Size(124, 30);
            this.labelFinish.TabIndex = 34;
            this.labelFinish.Text = "Остановить будильник";
            this.labelFinish.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelFinish.Click += new System.EventHandler(this.labelFinish_Click);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.SkyBlue;
            this.label9.Location = new System.Drawing.Point(-5, 351);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(397, 23);
            this.label9.TabIndex = 10;
            this.label9.MouseEnter += new System.EventHandler(this.label71_MouseEnter);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 375);
            this.Controls.Add(this.labirint);
            this.Name = "Form2";
            this.Text = "Лабиринт";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.labirint.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel labirint;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelStart;
        private System.Windows.Forms.Label labelFinish;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}