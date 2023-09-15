namespace OPBD
{
    partial class AllReviews
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
            dataGridView1 = new DataGridView();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            button_vhod = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(20, 20, 30);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Cursor = Cursors.No;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.FromArgb(20, 20, 30);
            dataGridView1.Location = new Point(31, 51);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 35;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(680, 240);
            dataGridView1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.скуые;
            pictureBox1.Location = new Point(713, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(21, 15);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(29, 15);
            label1.Name = "label1";
            label1.Size = new Size(316, 24);
            label1.TabIndex = 15;
            label1.Text = "Таблица оценок (Только чтение)";
            label1.Click += label1_Click;
            // 
            // button_vhod
            // 
            button_vhod.AccessibleRole = AccessibleRole.None;
            button_vhod.BackgroundImage = Properties.Resources.btn2;
            button_vhod.BackgroundImageLayout = ImageLayout.Stretch;
            button_vhod.Cursor = Cursors.Hand;
            button_vhod.FlatAppearance.BorderColor = Color.FromArgb(20, 20, 50);
            button_vhod.FlatAppearance.BorderSize = 0;
            button_vhod.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 20, 30);
            button_vhod.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 20, 30);
            button_vhod.FlatStyle = FlatStyle.Flat;
            button_vhod.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button_vhod.ForeColor = SystemColors.ControlLight;
            button_vhod.Location = new Point(289, 306);
            button_vhod.Name = "button_vhod";
            button_vhod.Size = new Size(179, 39);
            button_vhod.TabIndex = 24;
            button_vhod.Text = "Вернуться обратно";
            button_vhod.UseVisualStyleBackColor = false;
            button_vhod.Click += button_vhod_Click;
            // 
            // AllReviews
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 30);
            ClientSize = new Size(746, 357);
            Controls.Add(button_vhod);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AllReviews";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AllReviews";
            Load += AllReviews_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
        private Label label1;
        private Button button_vhod;
    }
}