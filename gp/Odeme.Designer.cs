namespace gp
{
    partial class Odeme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Odeme));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            OdemeTb = new TextBox();
            label5 = new Label();
            label3 = new Label();
            Periyot = new DateTimePicker();
            label6 = new Label();
            button7 = new Button();
            button6 = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            AdSoyadCb = new ComboBox();
            OdemeDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            label7 = new Label();
            AraTb = new TextBox();
            button1 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OdemeDGV).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.Crimson;
            label4.Location = new Point(921, 9);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(28, 28);
            label4.TabIndex = 10;
            label4.Text = "X";
            label4.Click += label4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.Crimson;
            label2.Location = new Point(379, 37);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(135, 30);
            label2.TabIndex = 9;
            label2.Text = "Ödemeler";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.Crimson;
            label1.Location = new Point(358, 9);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(187, 28);
            label1.TabIndex = 8;
            label1.Text = "FITNESS CENTER";
            // 
            // OdemeTb
            // 
            OdemeTb.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            OdemeTb.ForeColor = Color.Crimson;
            OdemeTb.Location = new Point(35, 403);
            OdemeTb.Name = "OdemeTb";
            OdemeTb.Size = new Size(200, 27);
            OdemeTb.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.ForeColor = Color.MediumBlue;
            label5.Location = new Point(35, 368);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(51, 21);
            label5.TabIndex = 13;
            label5.Text = "Tutar";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.MediumBlue;
            label3.Location = new Point(35, 293);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(125, 21);
            label3.TabIndex = 12;
            label3.Text = "Üye Adı Soyadı";
            // 
            // Periyot
            // 
            Periyot.CalendarFont = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Periyot.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Periyot.Format = DateTimePickerFormat.Short;
            Periyot.Location = new Point(35, 239);
            Periyot.Name = "Periyot";
            Periyot.Size = new Size(200, 31);
            Periyot.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label6.ForeColor = Color.MediumBlue;
            label6.Location = new Point(35, 211);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(98, 21);
            label6.TabIndex = 16;
            label6.Text = "Ödeme Ayı";
            // 
            // button7
            // 
            button7.BackColor = Color.Crimson;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.ForeColor = Color.White;
            button7.Location = new Point(147, 462);
            button7.Margin = new Padding(5, 4, 5, 4);
            button7.Name = "button7";
            button7.Size = new Size(102, 42);
            button7.TabIndex = 41;
            button7.Text = "Reset";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.Crimson;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.ForeColor = Color.White;
            button6.Location = new Point(35, 462);
            button6.Margin = new Padding(5, 4, 5, 4);
            button6.Name = "button6";
            button6.Size = new Size(102, 42);
            button6.TabIndex = 40;
            button6.Text = "Ödeme";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Crimson;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(65, 512);
            button2.Margin = new Padding(5, 4, 5, 4);
            button2.Name = "button2";
            button2.Size = new Size(150, 45);
            button2.TabIndex = 42;
            button2.Text = "Geri";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(379, 71);
            pictureBox1.Margin = new Padding(5, 4, 5, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(148, 90);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 44;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(43, 9);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(180, 80);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 45;
            pictureBox2.TabStop = false;
            // 
            // AdSoyadCb
            // 
            AdSoyadCb.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            AdSoyadCb.ForeColor = Color.Crimson;
            AdSoyadCb.FormattingEnabled = true;
            AdSoyadCb.Items.AddRange(new object[] { "Bay", "Bayan" });
            AdSoyadCb.Location = new Point(35, 326);
            AdSoyadCb.Name = "AdSoyadCb";
            AdSoyadCb.Size = new Size(200, 29);
            AdSoyadCb.TabIndex = 46;
            // 
            // OdemeDGV
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            OdemeDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            OdemeDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            OdemeDGV.ColumnHeadersHeight = 30;
            OdemeDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            OdemeDGV.DefaultCellStyle = dataGridViewCellStyle3;
            OdemeDGV.GridColor = Color.FromArgb(231, 229, 255);
            OdemeDGV.Location = new Point(272, 211);
            OdemeDGV.Name = "OdemeDGV";
            OdemeDGV.RowHeadersVisible = false;
            OdemeDGV.Size = new Size(658, 318);
            OdemeDGV.TabIndex = 47;
            OdemeDGV.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            OdemeDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            OdemeDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            OdemeDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            OdemeDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            OdemeDGV.ThemeStyle.BackColor = Color.White;
            OdemeDGV.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            OdemeDGV.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            OdemeDGV.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            OdemeDGV.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            OdemeDGV.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            OdemeDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            OdemeDGV.ThemeStyle.HeaderStyle.Height = 30;
            OdemeDGV.ThemeStyle.ReadOnly = false;
            OdemeDGV.ThemeStyle.RowsStyle.BackColor = Color.White;
            OdemeDGV.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            OdemeDGV.ThemeStyle.RowsStyle.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            OdemeDGV.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            OdemeDGV.ThemeStyle.RowsStyle.Height = 25;
            OdemeDGV.ThemeStyle.RowsStyle.SelectionBackColor = Color.Crimson;
            OdemeDGV.ThemeStyle.RowsStyle.SelectionForeColor = Color.White;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label7.ForeColor = Color.Crimson;
            label7.Location = new Point(622, 115);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(135, 30);
            label7.TabIndex = 48;
            label7.Text = "Ödemeler";
            // 
            // AraTb
            // 
            AraTb.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            AraTb.ForeColor = Color.Crimson;
            AraTb.Location = new Point(358, 168);
            AraTb.Name = "AraTb";
            AraTb.Size = new Size(200, 27);
            AraTb.TabIndex = 49;
            // 
            // button1
            // 
            button1.BackColor = Color.Crimson;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(576, 162);
            button1.Margin = new Padding(5, 4, 5, 4);
            button1.Name = "button1";
            button1.Size = new Size(100, 42);
            button1.TabIndex = 50;
            button1.Text = "Ara";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Crimson;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Location = new Point(695, 162);
            button3.Margin = new Padding(5, 4, 5, 4);
            button3.Name = "button3";
            button3.Size = new Size(98, 42);
            button3.TabIndex = 51;
            button3.Text = "Yenile";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Odeme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(963, 591);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(AraTb);
            Controls.Add(label7);
            Controls.Add(OdemeDGV);
            Controls.Add(AdSoyadCb);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(label6);
            Controls.Add(Periyot);
            Controls.Add(OdemeTb);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Odeme";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Odeme";
            Load += Odeme_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)OdemeDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label2;
        private Label label1;
        private TextBox OdemeTb;
        private Label label5;
        private Label label3;
        private DateTimePicker Periyot;
        private Label label6;
        private Button button7;
        private Button button6;
        private Button button2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private ComboBox AdSoyadCb;
        private Guna.UI2.WinForms.Guna2DataGridView OdemeDGV;
        private Label label7;
        private TextBox AraTb;
        private Button button1;
        private Button button3;
    }
}