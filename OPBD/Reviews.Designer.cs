namespace OPBD
{
    partial class Reviews
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
            button_vhod = new Button();
            label1 = new Label();
            panel1 = new Panel();
            label14 = new Label();
            panel2 = new Panel();
            label4 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            panel3 = new Panel();
            label15 = new Label();
            panel4 = new Panel();
            label5 = new Label();
            comboBox2 = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            panel5 = new Panel();
            label16 = new Label();
            panel6 = new Panel();
            label8 = new Label();
            comboBox3 = new ComboBox();
            label9 = new Label();
            label10 = new Label();
            panel7 = new Panel();
            label17 = new Label();
            panel8 = new Panel();
            label11 = new Label();
            comboBox4 = new ComboBox();
            label12 = new Label();
            label13 = new Label();
            regButton = new Button();
            label18 = new Label();
            comboBox5 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.скуые;
            pictureBox1.Location = new Point(395, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(21, 15);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button_vhod
            // 
            button_vhod.AccessibleRole = AccessibleRole.None;
            button_vhod.BackgroundImage = Properties.Resources.btn7;
            button_vhod.BackgroundImageLayout = ImageLayout.Stretch;
            button_vhod.Cursor = Cursors.Hand;
            button_vhod.FlatAppearance.BorderColor = Color.FromArgb(20, 20, 30);
            button_vhod.FlatAppearance.BorderSize = 0;
            button_vhod.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 20, 30);
            button_vhod.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 20, 30);
            button_vhod.FlatStyle = FlatStyle.Flat;
            button_vhod.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button_vhod.ForeColor = SystemColors.ControlLight;
            button_vhod.Location = new Point(90, 378);
            button_vhod.Name = "button_vhod";
            button_vhod.Size = new Size(232, 39);
            button_vhod.TabIndex = 11;
            button_vhod.Text = "Оставить отзыв";
            button_vhod.UseVisualStyleBackColor = false;
            button_vhod.Click += button_vhod_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(61, 12);
            label1.Name = "label1";
            label1.Size = new Size(315, 33);
            label1.TabIndex = 10;
            label1.Text = "Оценка преподавателей";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 30, 50);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(27, 65);
            panel1.Name = "panel1";
            panel1.Size = new Size(166, 113);
            panel1.TabIndex = 23;
            panel1.Paint += panel1_Paint;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.ForeColor = Color.DimGray;
            label14.Location = new Point(12, 90);
            label14.Name = "label14";
            label14.Size = new Size(45, 13);
            label14.TabIndex = 17;
            label14.Text = "Форма1";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(30, 30, 50);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(comboBox1);
            panel2.Location = new Point(12, 33);
            panel2.Name = "panel2";
            panel2.Size = new Size(144, 68);
            panel2.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Gray;
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(113, 26);
            label4.TabIndex = 16;
            label4.Text = "Как хорошо препод \r\nзнает свой предмет?";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(20, 20, 30);
            comboBox1.Cursor = Cursors.Hand;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FlatStyle = FlatStyle.Popup;
            comboBox1.ForeColor = Color.Transparent;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Превосходно!", "Хорошо", "Средне", "Плохо", "Очень плохо" });
            comboBox1.Location = new Point(2, 33);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(125, 21);
            comboBox1.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(14, 10);
            label2.Name = "label2";
            label2.Size = new Size(122, 18);
            label2.TabIndex = 20;
            label2.Text = "Компетентность";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(6, 33);
            label3.Name = "label3";
            label3.Size = new Size(0, 13);
            label3.TabIndex = 21;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(30, 30, 50);
            panel3.Controls.Add(label15);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label7);
            panel3.Location = new Point(212, 65);
            panel3.Name = "panel3";
            panel3.Size = new Size(187, 113);
            panel3.TabIndex = 24;
            panel3.Paint += panel3_Paint;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.ForeColor = Color.DimGray;
            label15.Location = new Point(12, 90);
            label15.Name = "label15";
            label15.Size = new Size(45, 13);
            label15.TabIndex = 24;
            label15.Text = "Форма2";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(30, 30, 50);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(comboBox2);
            panel4.Location = new Point(12, 33);
            panel4.Name = "panel4";
            panel4.Size = new Size(165, 68);
            panel4.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Gray;
            label5.Location = new Point(-1, 1);
            label5.Name = "label5";
            label5.Size = new Size(126, 26);
            label5.TabIndex = 16;
            label5.Text = "Cправедливо ли \r\nпрепод ставит оценки?";
            // 
            // comboBox2
            // 
            comboBox2.BackColor = Color.FromArgb(20, 20, 30);
            comboBox2.Cursor = Cursors.Hand;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FlatStyle = FlatStyle.Popup;
            comboBox2.ForeColor = Color.Transparent;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Превосходно!", "Хорошо", "Средне", "Плохо", "Очень плохо" });
            comboBox2.Location = new Point(0, 33);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(145, 21);
            comboBox2.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(11, 10);
            label6.Name = "label6";
            label6.Size = new Size(120, 18);
            label6.TabIndex = 20;
            label6.Text = "Справедливость";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(6, 33);
            label7.Name = "label7";
            label7.Size = new Size(0, 13);
            label7.TabIndex = 21;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(30, 30, 50);
            panel5.Controls.Add(label16);
            panel5.Controls.Add(panel6);
            panel5.Controls.Add(label9);
            panel5.Controls.Add(label10);
            panel5.Location = new Point(27, 192);
            panel5.Name = "panel5";
            panel5.Size = new Size(166, 110);
            panel5.TabIndex = 25;
            panel5.Paint += panel5_Paint;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.ForeColor = Color.DimGray;
            label16.Location = new Point(12, 90);
            label16.Name = "label16";
            label16.Size = new Size(45, 13);
            label16.TabIndex = 25;
            label16.Text = "Форма3";
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(30, 30, 50);
            panel6.Controls.Add(label8);
            panel6.Controls.Add(comboBox3);
            panel6.Location = new Point(12, 33);
            panel6.Name = "panel6";
            panel6.Size = new Size(144, 63);
            panel6.TabIndex = 23;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Gray;
            label8.Location = new Point(0, 1);
            label8.Name = "label8";
            label8.Size = new Size(107, 26);
            label8.TabIndex = 16;
            label8.Text = "Как хорошо препод\r\nдоносит материал?";
            // 
            // comboBox3
            // 
            comboBox3.BackColor = Color.FromArgb(20, 20, 30);
            comboBox3.Cursor = Cursors.Hand;
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.FlatStyle = FlatStyle.Popup;
            comboBox3.ForeColor = Color.Transparent;
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Превосходно!", "Хорошо", "Средне", "Плохо", "Очень плохо" });
            comboBox3.Location = new Point(2, 33);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(125, 21);
            comboBox3.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.Control;
            label9.Location = new Point(11, 10);
            label9.Name = "label9";
            label9.Size = new Size(128, 18);
            label9.TabIndex = 20;
            label9.Text = "Донос материала";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = SystemColors.Control;
            label10.Location = new Point(6, 33);
            label10.Name = "label10";
            label10.Size = new Size(0, 13);
            label10.TabIndex = 21;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(30, 30, 50);
            panel7.Controls.Add(label17);
            panel7.Controls.Add(panel8);
            panel7.Controls.Add(label12);
            panel7.Controls.Add(label13);
            panel7.Location = new Point(212, 192);
            panel7.Name = "panel7";
            panel7.Size = new Size(187, 110);
            panel7.TabIndex = 26;
            panel7.Paint += panel7_Paint;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.ForeColor = Color.DimGray;
            label17.Location = new Point(12, 90);
            label17.Name = "label17";
            label17.Size = new Size(45, 13);
            label17.TabIndex = 26;
            label17.Text = "Форма4";
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(30, 30, 50);
            panel8.Controls.Add(label11);
            panel8.Controls.Add(comboBox4);
            panel8.Location = new Point(12, 33);
            panel8.Name = "panel8";
            panel8.Size = new Size(165, 63);
            panel8.TabIndex = 23;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Tahoma", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.Gray;
            label11.Location = new Point(0, 0);
            label11.Name = "label11";
            label11.Size = new Size(147, 26);
            label11.TabIndex = 16;
            label11.Text = "Ваша оценка если бы \r\nне было прошлых пунктов?";
            // 
            // comboBox4
            // 
            comboBox4.BackColor = Color.FromArgb(20, 20, 30);
            comboBox4.Cursor = Cursors.Hand;
            comboBox4.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox4.FlatStyle = FlatStyle.Popup;
            comboBox4.ForeColor = Color.Transparent;
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "Превосходно!", "Хорошо", "Средне", "Плохо", "Очень плохо" });
            comboBox4.Location = new Point(2, 33);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(143, 21);
            comboBox4.TabIndex = 15;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = SystemColors.Control;
            label12.Location = new Point(11, 10);
            label12.Name = "label12";
            label12.Size = new Size(109, 18);
            label12.TabIndex = 20;
            label12.Text = "Общая оценка";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = SystemColors.Control;
            label13.Location = new Point(6, 33);
            label13.Name = "label13";
            label13.Size = new Size(0, 13);
            label13.TabIndex = 21;
            // 
            // regButton
            // 
            regButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            regButton.BackgroundImageLayout = ImageLayout.Center;
            regButton.Cursor = Cursors.Hand;
            regButton.FlatAppearance.BorderColor = Color.FromArgb(20, 20, 30);
            regButton.FlatAppearance.BorderSize = 0;
            regButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 20, 30);
            regButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 20, 30);
            regButton.FlatStyle = FlatStyle.Flat;
            regButton.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            regButton.ForeColor = Color.Gray;
            regButton.Location = new Point(164, 419);
            regButton.Name = "regButton";
            regButton.Size = new Size(87, 23);
            regButton.TabIndex = 25;
            regButton.Text = "Назад";
            regButton.UseVisualStyleBackColor = true;
            regButton.Click += regButton_Click;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label18.ForeColor = SystemColors.Control;
            label18.Location = new Point(38, 330);
            label18.Name = "label18";
            label18.Size = new Size(164, 18);
            label18.TabIndex = 27;
            label18.Text = "Сейчас мы оценивали ";
            label18.Click += label18_Click;
            // 
            // comboBox5
            // 
            comboBox5.BackColor = Color.FromArgb(20, 20, 30);
            comboBox5.Cursor = Cursors.Hand;
            comboBox5.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox5.FlatStyle = FlatStyle.Popup;
            comboBox5.ForeColor = Color.Transparent;
            comboBox5.FormattingEnabled = true;
            comboBox5.Items.AddRange(new object[] { "Валерий Германович", "Быков Денис Владиславович", "Наталия Руслановна", "Арсений Ярославович", "Анна Тимуровна", "Григорий Эмильевич", "Елизавета Семёновна", "Алиса Константиновна", "Артём Ярославович", "Виктория Львовна" });
            comboBox5.Location = new Point(212, 329);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(177, 21);
            comboBox5.TabIndex = 28;
            // 
            // Reviews
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(20, 20, 30);
            ClientSize = new Size(428, 450);
            Controls.Add(comboBox5);
            Controls.Add(label18);
            Controls.Add(regButton);
            Controls.Add(panel7);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(button_vhod);
            Controls.Add(label1);
            Font = new Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.AppWorkspace;
            FormBorderStyle = FormBorderStyle.None;
            HelpButton = true;
            Name = "Reviews";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reviews";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button_vhod;
        private Label label1;
        private Panel panel1;
        private Label label2;
        private Label label3;
        private Panel panel2;
        private Label label4;
        private ComboBox comboBox1;
        private Panel panel3;
        private Panel panel4;
        private Label label5;
        private ComboBox comboBox2;
        private Label label6;
        private Label label7;
        private Panel panel5;
        private Panel panel6;
        private Label label8;
        private ComboBox comboBox3;
        private Label label9;
        private Label label10;
        private Panel panel7;
        private Panel panel8;
        private Label label11;
        private ComboBox comboBox4;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Button regButton;
        private Label label18;
        private ComboBox comboBox5;
    }
}