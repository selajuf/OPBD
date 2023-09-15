using MySqlConnector;
using System.Runtime.InteropServices;

namespace OPBD
{
    public partial class Reviews : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );
        public Reviews()
        {
            InitializeComponent();
this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            SetStyle(ControlStyles.ResizeRedraw, true); // Это необходимо для перерисовки обводки при изменении размеров панели            

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            int arcSize = 10; // Задайте значение радиуса закругления, как вам нужно
            int x = 0;
            int y = 0;
            int width = panel1.Width;
            int height = panel1.Height;

            path.AddArc(x, y, arcSize, arcSize, 180, 90);
            path.AddArc(width - arcSize, y, arcSize, arcSize, 270, 90);
            path.AddArc(width - arcSize, height - arcSize, arcSize, arcSize, 0, 90);
            path.AddArc(x, height - arcSize, arcSize, arcSize, 90, 90);
            path.CloseAllFigures();

            panel1.Region = new System.Drawing.Region(path);
        }
        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            int arcSize = 10; // Задайте значение радиуса закругления, как вам нужно
            int x = 0;
            int y = 0;
            int width = panel5.Width;
            int height = panel5.Height;

            path.AddArc(x, y, arcSize, arcSize, 180, 90);
            path.AddArc(width - arcSize, y, arcSize, arcSize, 270, 90);
            path.AddArc(width - arcSize, height - arcSize, arcSize, arcSize, 0, 90);
            path.AddArc(x, height - arcSize, arcSize, arcSize, 90, 90);
            path.CloseAllFigures();

            panel5.Region = new System.Drawing.Region(path);
        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            int arcSize = 10; // Задайте значение радиуса закругления, как вам нужно
            int x = 0;
            int y = 0;
            int width = panel3.Width;
            int height = panel3.Height;

            path.AddArc(x, y, arcSize, arcSize, 180, 90);
            path.AddArc(width - arcSize, y, arcSize, arcSize, 270, 90);
            path.AddArc(width - arcSize, height - arcSize, arcSize, arcSize, 0, 90);
            path.AddArc(x, height - arcSize, arcSize, arcSize, 90, 90);
            path.CloseAllFigures();

            panel3.Region = new System.Drawing.Region(path);
        }
        private void panel7_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            int arcSize = 10; // Задайте значение радиуса закругления, как вам нужно
            int x = 0;
            int y = 0;
            int width = panel7.Width;
            int height = panel7.Height;

            path.AddArc(x, y, arcSize, arcSize, 180, 90);
            path.AddArc(width - arcSize, y, arcSize, arcSize, 270, 90);
            path.AddArc(width - arcSize, height - arcSize, arcSize, arcSize, 0, 90);
            path.AddArc(x, height - arcSize, arcSize, arcSize, 90, 90);
            path.CloseAllFigures();

            panel7.Region = new System.Drawing.Region(path);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void regButton_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            Hide();
            this.CenterToScreen();
        }

        private void button_vhod_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Ответьте на форму 1");
                return;
            }
            if (comboBox2.Text == "")
            {
                MessageBox.Show("Ответьте на форму 2");
                return;
            }
            if (comboBox3.Text == "")
            {
                MessageBox.Show("Ответьте на форму 3");
                return;
            }
            if (comboBox4.Text == "")
            {
                MessageBox.Show("Ответьте на форму 4");
                return;
            }

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO justice_table (id, competence, justice, material, estimation, name) VALUES (NULL, @competence, @justice, @material, @estimation, @name) ", db.getConnection());

            command.Parameters.Add("@competence", MySqlDbType.VarChar).Value = comboBox1.Text;
            command.Parameters.Add("@justice", MySqlDbType.VarChar).Value = comboBox2.Text;
            command.Parameters.Add("@material", MySqlDbType.VarChar).Value = comboBox3.Text;
            command.Parameters.Add("@estimation", MySqlDbType.VarChar).Value = comboBox4.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = comboBox5.Text;

            db.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                this.Hide();
                Main main = new Main();
                main.Show();
                this.CenterToScreen();
                MessageBox.Show("Ваши ответы успешно записаны");

            }
            else
                MessageBox.Show("Ваши ответы не были записаны :(");

            db.closeConnection();

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }
    }

}
