using MySqlConnector;

namespace OPBD
{
    public partial class New_Fax : Form
    {
        public New_Fax()
        {
            InitializeComponent();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Какой факт вы хотите добавить?";
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Какой факт вы хотите добавить?")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.White;

            }

        }

        private void button_vhod_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Какой факт вы хотите добавить?")
            {
                MessageBox.Show("Введите факт, нельзя добавить пустоту");
                return;
            }

            if (textBox1.Text.Length > 100)
            {
                MessageBox.Show("Факт НЕ создан\nМного символов. (больше 100)");
                return;
            }
            //if (checkUser())
            //    return;


            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO faxes_table VALUES (0, @fax)", db.getConnection());

            command.Parameters.Add("@fax", MySqlDbType.VarChar).Value = textBox1.Text;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                this.Hide();
                Main main = new Main();
                main.Show();
                this.CenterToScreen();
                MessageBox.Show("Факт успешно добавлен");

            }
            else
                MessageBox.Show("Факт НЕ создан\nВозможно много символов. (больше 100)");

            db.closeConnection();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.Show();
            this.CenterToScreen();
        }
    }
}
