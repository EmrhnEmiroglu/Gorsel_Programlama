namespace gp
{
    partial class UyeleriGoruntule
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UyeleriGoruntule));
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            UyeDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            AraUyeTb = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button7 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)UyeDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.Crimson;
            label2.Location = new Point(314, 47);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(173, 30);
            label2.TabIndex = 5;
            label2.Text = "Üyeleri Listele";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.Crimson;
            label1.Location = new Point(314, 7);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(187, 28);
            label1.TabIndex = 4;
            label1.Text = "FITNESS CENTER";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.Crimson;
            label3.Location = new Point(831, 7);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(28, 28);
            label3.TabIndex = 6;
            label3.Text = "X";
            label3.Click += label3_Click;
            // 
            // UyeDGV
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            UyeDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            UyeDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            UyeDGV.ColumnHeadersHeight = 30;
            UyeDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            UyeDGV.DefaultCellStyle = dataGridViewCellStyle3;
            UyeDGV.GridColor = Color.FromArgb(231, 229, 255);
            UyeDGV.Location = new Point(12, 144);
            UyeDGV.Name = "UyeDGV";
            UyeDGV.RowHeadersVisible = false;
            UyeDGV.Size = new Size(835, 347);
            UyeDGV.TabIndex = 41;
            UyeDGV.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            UyeDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            UyeDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            UyeDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            UyeDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            UyeDGV.ThemeStyle.BackColor = Color.White;
            UyeDGV.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            UyeDGV.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            UyeDGV.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            UyeDGV.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            UyeDGV.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            UyeDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            UyeDGV.ThemeStyle.HeaderStyle.Height = 30;
            UyeDGV.ThemeStyle.ReadOnly = false;
            UyeDGV.ThemeStyle.RowsStyle.BackColor = Color.White;
            UyeDGV.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            UyeDGV.ThemeStyle.RowsStyle.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            UyeDGV.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            UyeDGV.ThemeStyle.RowsStyle.Height = 25;
            UyeDGV.ThemeStyle.RowsStyle.SelectionBackColor = Color.Crimson;
            UyeDGV.ThemeStyle.RowsStyle.SelectionForeColor = Color.White;
            // 
            // AraUyeTb
            // 
            AraUyeTb.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            AraUyeTb.ForeColor = Color.Crimson;
            AraUyeTb.Location = new Point(274, 101);
            AraUyeTb.Name = "AraUyeTb";
            AraUyeTb.Size = new Size(203, 27);
            AraUyeTb.TabIndex = 42;
            // 
            // button1
            // 
            button1.BackColor = Color.Crimson;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(505, 100);
            button1.Margin = new Padding(5, 4, 5, 4);
            button1.Name = "button1";
            button1.Size = new Size(99, 33);
            button1.TabIndex = 43;
            button1.Text = "Ara";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Crimson;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(614, 100);
            button2.Margin = new Padding(5, 4, 5, 4);
            button2.Name = "button2";
            button2.Size = new Size(99, 33);
            button2.TabIndex = 44;
            button2.Text = "Yenile";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.Crimson;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.ForeColor = Color.White;
            button7.Location = new Point(316, 498);
            button7.Margin = new Padding(5, 4, 5, 4);
            button7.Name = "button7";
            button7.Size = new Size(161, 42);
            button7.TabIndex = 45;
            button7.Text = "Geri";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(134, 103);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 46;
            pictureBox1.TabStop = false;
            // 
            // UyeleriGoruntule
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(873, 591);
            Controls.Add(pictureBox1);
            Controls.Add(button7);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(AraUyeTb);
            Controls.Add(UyeDGV);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UyeleriGoruntule";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UyeleriGoruntule";
            Load += UyeleriGoruntule_Load;
            ((System.ComponentModel.ISupportInitialize)UyeDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Label label3;
        private Guna.UI2.WinForms.Guna2DataGridView UyeDGV;
        private TextBox AraUyeTb;
        private Button button1;
        private Button button2;
        private Button button7;
        private PictureBox pictureBox1;
    }
}