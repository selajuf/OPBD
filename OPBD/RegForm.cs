using MySqlConnector;
using System.Data;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;

namespace OPBD
{
    public partial class RegForm : Form
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
        public RegForm()
        {
            InitializeComponent();

            textBox1.Text = "Логин";
            textBox1.ForeColor = Color.Gray;
            textBox2.Text = "Пароль";
            textBox2.ForeColor = Color.Gray;
            textBox3.Text = "Как вас зовут?";
            textBox3.ForeColor = Color.Gray;
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        public class RoundButton : Button
        {
            protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
            {
                GraphicsPath grPath = new GraphicsPath();
                grPath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
                this.Region = new System.Drawing.Region(grPath);
                base.OnPaint(e);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {


        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_vhod_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Логин")
            {
                MessageBox.Show("Введите имя!");
                return;
            }

            if (textBox2.Text == "Пароль")
            {
                MessageBox.Show("Введите пароль!");
                return;
            }

            if (textBox3.Text == "Как вас зовут?")
            {
                MessageBox.Show("Введите своё имя!!!");
                return;
            }

            if (checkUser())
                return;


            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO users VALUES (0, @login, @pass, @name) ", db.getConnection());

            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = textBox1.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = textBox2.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = textBox3.Text;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                this.Hide();
                Main main = new Main();
                main.Show();
                this.CenterToScreen();

            }
            else
                MessageBox.Show("Аккаунт НЕ создан");

            db.closeConnection();


        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Логин")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.White;

            }

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Логин";
                textBox1.ForeColor = Color.Gray;
            }

        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Пароль";
                textBox2.ForeColor = Color.Gray;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Пароль")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.White;

            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "Как вас зовут?";
                textBox3.ForeColor = Color.Gray;
            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "Как вас зовут?")
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.White;

            }
        }

        public Boolean checkUser()
        {
            DB db = new DB();

            DataTable table = new DataTable(); // Помещаем в таблицу

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL", db.getConnection());

            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = textBox1.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table); // Заполняем бд

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Логин уже занят, используйте другой");
                return true;
            }
            else
                return false;

        }

        private void regButton_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            Hide();
            this.CenterToScreen();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
