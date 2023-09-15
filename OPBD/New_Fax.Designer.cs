namespace OPBD
{
    partial class New_Fax
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
            textBox1 = new TextBox();
            button_vhod = new Button();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.скуые;
            pictureBox1.Location = new Point(223, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(21, 14);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(20, 20, 30);
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = SystemColors.Menu;
            textBox1.Location = new Point(19, 107);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Both;
            textBox1.Size = new Size(219, 100);
            textBox1.TabIndex = 13;
            textBox1.Enter += textBox1_Enter;
            textBox1.Leave += textBox1_Leave;
            // 
            // button_vhod
            // 
            button_vhod.AccessibleRole = AccessibleRole.None;
            button_vhod.BackgroundImage = Properties.Resources.btn3;
            button_vhod.BackgroundImageLayout = ImageLayout.Stretch;
            button_vhod.Cursor = Cursors.Hand;
            button_vhod.FlatAppearance.BorderColor = Color.FromArgb(20, 20, 50);
            button_vhod.FlatAppearance.BorderSize = 0;
            button_vhod.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 20, 30);
            button_vhod.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 20, 30);
            button_vhod.FlatStyle = FlatStyle.Flat;
            button_vhod.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button_vhod.ForeColor = SystemColors.ControlLight;
            button_vhod.Location = new Point(19, 254);
            button_vhod.Name = "button_vhod";
            button_vhod.Size = new Size(219, 36);
            button_vhod.TabIndex = 12;
            button_vhod.Text = "Добавить!";
            button_vhod.UseVisualStyleBackColor = false;
            button_vhod.Click += button_vhod_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(19, 39);
            label1.Name = "label1";
            label1.Size = new Size(223, 29);
            label1.TabIndex = 11;
            label1.Text = "Добавление факта";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(56, 68);
            label2.Name = "label2";
            label2.Size = new Size(151, 14);
            label2.TabIndex = 14;
            label2.Text = "Не больше 100 символов";
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.FromArgb(20, 20, 30);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 20, 30);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 20, 30);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(99, 296);
            button1.Name = "button1";
            button1.Size = new Size(59, 23);
            button1.TabIndex = 15;
            button1.Text = "Назад";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // New_Fax
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 30);
            ClientSize = new Size(256, 328);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(button_vhod);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "New_Fax";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "New_Fax";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Button button_vhod;
        private Label label1;
        private Label label2;
        private Button button1;
    }
}