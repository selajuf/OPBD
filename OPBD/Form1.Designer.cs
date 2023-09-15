namespace OPBD
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            button_vhod = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            mySqlDataAdapter1 = new MySqlConnector.MySqlDataAdapter();
            pictureBox1 = new PictureBox();
            regButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(60, 45);
            label1.Name = "label1";
            label1.Size = new Size(156, 33);
            label1.TabIndex = 1;
            label1.Text = "Окно входа";
            label1.Click += label1_Click;
            // 
            // button_vhod
            // 
            button_vhod.AccessibleRole = AccessibleRole.None;
            button_vhod.BackgroundImage = Properties.Resources._1;
            button_vhod.BackgroundImageLayout = ImageLayout.Stretch;
            button_vhod.Cursor = Cursors.Hand;
            button_vhod.FlatAppearance.BorderColor = Color.FromArgb(20, 20, 50);
            button_vhod.FlatAppearance.BorderSize = 0;
            button_vhod.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 20, 30);
            button_vhod.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 20, 30);
            button_vhod.FlatStyle = FlatStyle.Flat;
            button_vhod.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button_vhod.ForeColor = SystemColors.ControlLight;
            button_vhod.Location = new Point(26, 278);
            button_vhod.Name = "button_vhod";
            button_vhod.Size = new Size(219, 39);
            button_vhod.TabIndex = 6;
            button_vhod.Text = "Войти";
            button_vhod.UseVisualStyleBackColor = false;
            button_vhod.Click += button_vhod_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(20, 20, 30);
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = SystemColors.Menu;
            textBox1.Location = new Point(26, 133);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(219, 29);
            textBox1.TabIndex = 7;
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.Enter += textBox1_Enter;
            textBox1.Leave += textBox1_Leave;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(20, 20, 30);
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Cursor = Cursors.IBeam;
            textBox2.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.ForeColor = SystemColors.Window;
            textBox2.Location = new Point(26, 170);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(219, 29);
            textBox2.TabIndex = 8;
            textBox2.TextAlign = HorizontalAlignment.Center;
            textBox2.TextChanged += textBox2_TextChanged;
            textBox2.Enter += textBox2_Enter;
            textBox2.Leave += textBox2_Leave;
            // 
            // mySqlDataAdapter1
            // 
            mySqlDataAdapter1.DeleteCommand = null;
            mySqlDataAdapter1.InsertCommand = null;
            mySqlDataAdapter1.SelectCommand = null;
            mySqlDataAdapter1.UpdateBatchSize = 0;
            mySqlDataAdapter1.UpdateCommand = null;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.скуые;
            pictureBox1.Location = new Point(237, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(21, 15);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
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
            regButton.Location = new Point(91, 323);
            regButton.Name = "regButton";
            regButton.Size = new Size(87, 23);
            regButton.TabIndex = 10;
            regButton.Text = "Регистрация";
            regButton.UseVisualStyleBackColor = true;
            regButton.Click += regButton_Click;
            // 
            // Form1
            // 
            AccessibleRole = AccessibleRole.None;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 30);
            ClientSize = new Size(270, 355);
            Controls.Add(regButton);
            Controls.Add(pictureBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button_vhod);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            ImeMode = ImeMode.Off;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            Enter += button_vhod_Click;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button_vhod;
        private TextBox textBox1;
        private TextBox textBox2;
        private MySqlConnector.MySqlDataAdapter mySqlDataAdapter1;
        private PictureBox pictureBox1;
        private Button regButton;
    }
}