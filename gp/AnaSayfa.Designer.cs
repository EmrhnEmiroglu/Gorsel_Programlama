﻿namespace gp
{
    partial class AnaSayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaSayfa));
            pictureBox1 = new PictureBox();
            button1 = new Button();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            button4 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 450);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            button1.ForeColor = Color.Crimson;
            button1.Location = new Point(182, 12);
            button1.Name = "button1";
            button1.Size = new Size(147, 38);
            button1.TabIndex = 1;
            button1.Text = "Üye Ekle";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(button3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 53);
            panel1.TabIndex = 5;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(139, 45);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            button4.ForeColor = Color.Crimson;
            button4.Location = new Point(488, 12);
            button4.Name = "button4";
            button4.Size = new Size(147, 38);
            button4.TabIndex = 8;
            button4.Text = "Güncelle/Sil";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            button2.ForeColor = Color.Crimson;
            button2.Location = new Point(641, 12);
            button2.Name = "button2";
            button2.Size = new Size(147, 38);
            button2.TabIndex = 6;
            button2.Text = "Ödeme";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            button3.ForeColor = Color.Crimson;
            button3.Location = new Point(335, 12);
            button3.Name = "button3";
            button3.Size = new Size(147, 38);
            button3.TabIndex = 10;
            button3.Text = "Üye Listesi";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // AnaSayfa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AnaSayfa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AnaSayfa";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private Panel panel1;
        private Button button2;
        private Button button4;
        private PictureBox pictureBox2;
        private Button button3;
    }
}