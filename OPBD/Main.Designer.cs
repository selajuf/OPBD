namespace OPBD
{
    partial class Main
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

        protected override void WndProc(ref Message message)
        {
            if (message.Msg == 0x201)
            {
                base.Capture = false;
                message = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            }
            base.WndProc(ref message);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            label5 = new Label();
            button_vhod = new Button();
            panel3 = new Panel();
            pictureBox4 = new PictureBox();
            panel4 = new Panel();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            label8 = new Label();
            label9 = new Label();
            panel5 = new Panel();
            pictureBox3 = new PictureBox();
            panel6 = new Panel();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.скуые;
            pictureBox1.Location = new Point(391, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(19, 12);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(12, 8);
            label2.Name = "label2";
            label2.Size = new Size(87, 18);
            label2.TabIndex = 20;
            label2.Text = "Статистика";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(6, 33);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 21;
            label3.Click += label3_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 30, 50);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(24, 51);
            panel1.Name = "panel1";
            panel1.Size = new Size(125, 152);
            panel1.TabIndex = 22;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(20, 20, 30);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(17, 33);
            panel2.Name = "panel2";
            panel2.Size = new Size(94, 105);
            panel2.TabIndex = 23;
            panel2.Paint += panel2_Paint;
            // 
            // label5
            // 
            label5.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(4, 5);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.Yes;
            label5.Size = new Size(86, 92);
            label5.TabIndex = 21;
            label5.Text = "123dfsgdsgf\\ndssdfsdf";
            label5.TextAlign = ContentAlignment.TopRight;
            label5.Click += label5_Click;
            label5.Paint += panel1_Paint;
            // 
            // button_vhod
            // 
            button_vhod.AccessibleRole = AccessibleRole.None;
            button_vhod.BackgroundImage = Properties.Resources.btn8;
            button_vhod.BackgroundImageLayout = ImageLayout.Stretch;
            button_vhod.Cursor = Cursors.Hand;
            button_vhod.FlatAppearance.BorderColor = Color.FromArgb(20, 20, 50);
            button_vhod.FlatAppearance.BorderSize = 0;
            button_vhod.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 20, 30);
            button_vhod.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 20, 30);
            button_vhod.FlatStyle = FlatStyle.Flat;
            button_vhod.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button_vhod.ForeColor = SystemColors.ControlLight;
            button_vhod.Location = new Point(23, 343);
            button_vhod.Name = "button_vhod";
            button_vhod.Size = new Size(179, 39);
            button_vhod.TabIndex = 23;
            button_vhod.Text = "Оставить отзыв";
            button_vhod.UseVisualStyleBackColor = false;
            button_vhod.Click += button_vhod_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(30, 30, 50);
            panel3.Controls.Add(pictureBox4);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label7);
            panel3.Location = new Point(155, 51);
            panel3.Name = "panel3";
            panel3.Size = new Size(237, 152);
            panel3.TabIndex = 24;
            panel3.Paint += panel3_Paint;
            // 
            // pictureBox4
            // 
            pictureBox4.Cursor = Cursors.Hand;
            pictureBox4.Image = Properties.Resources._118613_reload_icon;
            pictureBox4.Location = new Point(138, 11);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(14, 14);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 25;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(20, 20, 30);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(16, 33);
            panel4.Name = "panel4";
            panel4.Size = new Size(206, 105);
            panel4.TabIndex = 23;
            panel4.Paint += panel4_Paint;
            // 
            // label4
            // 
            label4.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(3, 5);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.Yes;
            label4.Size = new Size(200, 98);
            label4.TabIndex = 21;
            label4.Text = "Тут должен быть ласт отзыв";
            label4.TextAlign = ContentAlignment.TopRight;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(12, 8);
            label6.Name = "label6";
            label6.Size = new Size(127, 18);
            label6.TabIndex = 20;
            label6.Text = "Последний отзыв";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(6, 33);
            label7.Name = "label7";
            label7.Size = new Size(0, 15);
            label7.TabIndex = 21;
            // 
            // button1
            // 
            button1.AccessibleRole = AccessibleRole.None;
            button1.BackgroundImage = Properties.Resources.btn5;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.FromArgb(20, 20, 50);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 20, 30);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 20, 30);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlLight;
            button1.Location = new Point(213, 343);
            button1.Name = "button1";
            button1.Size = new Size(179, 39);
            button1.TabIndex = 25;
            button1.Text = "Все отзывы";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(24, 12);
            label1.Name = "label1";
            label1.Size = new Size(135, 23);
            label1.TabIndex = 27;
            label1.Text = "Главное меню";
            // 
            // button2
            // 
            button2.AccessibleRole = AccessibleRole.None;
            button2.BackgroundImage = Properties.Resources.test;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderColor = Color.FromArgb(20, 20, 50);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 20, 30);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 20, 30);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ControlLight;
            button2.Location = new Point(24, 390);
            button2.Name = "button2";
            button2.Size = new Size(368, 39);
            button2.TabIndex = 28;
            button2.Text = "Добавить новый факт";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.Control;
            label8.Location = new Point(12, 8);
            label8.Name = "label8";
            label8.Size = new Size(165, 18);
            label8.TabIndex = 20;
            label8.Text = "Последний факт из БД";
            // 
            // label9
            // 
            label9.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.Control;
            label9.Location = new Point(6, 5);
            label9.Name = "label9";
            label9.RightToLeft = RightToLeft.Yes;
            label9.Size = new Size(323, 67);
            label9.TabIndex = 21;
            label9.Text = "Тут должен быть факт";
            label9.TextAlign = ContentAlignment.TopRight;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(30, 30, 50);
            panel5.Controls.Add(pictureBox3);
            panel5.Controls.Add(panel6);
            panel5.Controls.Add(label8);
            panel5.Controls.Add(label10);
            panel5.Location = new Point(24, 209);
            panel5.Name = "panel5";
            panel5.Size = new Size(368, 124);
            panel5.TabIndex = 29;
            panel5.Paint += panel5_Paint;
            // 
            // pictureBox3
            // 
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = Properties.Resources._118613_reload_icon;
            pictureBox3.Location = new Point(182, 11);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(14, 14);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 24;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(20, 20, 30);
            panel6.Controls.Add(label9);
            panel6.Location = new Point(16, 33);
            panel6.Name = "panel6";
            panel6.Size = new Size(334, 78);
            panel6.TabIndex = 23;
            panel6.Paint += panel6_Paint;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = SystemColors.Control;
            label10.Location = new Point(6, 33);
            label10.Name = "label10";
            label10.Size = new Size(0, 15);
            label10.TabIndex = 21;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 30);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(418, 450);
            Controls.Add(panel5);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(panel3);
            Controls.Add(button_vhod);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            Load += Main_Load_1;
            Paint += panel1_Paint;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel6.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private Panel panel2;
        private Label label5;
        private Button button_vhod;
        private Panel panel3;
        private Panel panel4;
        private Label label4;
        private Label label6;
        private Label label7;
        private Button button1;
        private Label label1;
        private Button button2;
        private Label label8;
        private Label label9;
        private Panel panel5;
        private Panel panel6;
        private Label label10;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}