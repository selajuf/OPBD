using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Data;
using MySqlConnector;
namespace OPBD
{
    public partial class Form1 : Form
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
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "Логин";
            textBox1.ForeColor = Color.Gray;
            textBox2.Text = "Пароль";
            textBox2.ForeColor = Color.Gray;
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

        private void button_vhod_Click(object sender, EventArgs e)
        {

            String loginUser = textBox1.Text; // Получаем логин из строки
            String passwordUser = textBox2.Text; // Получаем пасс из строки


            DB db = new DB();

            DataTable table = new DataTable(); // Помещаем в таблицу

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL AND `pass` = @uP", db.getConnection());
            //MySqlCommand command = new MySqlCommand("SELECT * FROM users WHERE login = @LU AND pass = @PU");

            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passwordUser;

            adapter.SelectCommand = command;
            adapter.Fill(table); // Заполняем бд

            if (table.Rows.Count > 0)
            {
                this.Hide();
                Main main = new Main();
                main.Show();
                this.CenterToScreen();
            }
            else
                MessageBox.Show("Аккаунт не найден");

        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void loginField_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordField_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void regButton_Click(object sender, EventArgs e)
        {
            RegForm regForm = new RegForm();
            regForm.Show();
            Hide();
            this.CenterToScreen();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Логин";
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Логин")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.White;

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
    }
}