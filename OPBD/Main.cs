using MySqlConnector;
using System.Runtime.InteropServices;

namespace OPBD
{
    public partial class Main : Form
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
        public Main()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            SetStyle(ControlStyles.ResizeRedraw, true); // Это необходимо для перерисовки обводки при изменении размеров панели
            
            DB db = new DB();


            MySqlCommand command2 = new MySqlCommand("SELECT competence, justice, material, estimation, name FROM justice_table ORDER BY id DESC LIMIT 1", db.getConnection());

            db.openConnection();
            MySqlDataReader reader = command2.ExecuteReader();
            string result = "";
            while (reader.Read())
            {
                result += "Компетенция: " + reader.GetString(0) + "\n";
                result += "Справедливость: " + reader.GetString(1) + "\n";
                result += "Материал: " + reader.GetString(2) + "\n";
                result += "Оценка: " + reader.GetString(3) + "\n";
                result += "ФИО: " + reader.GetString(4) + "\n";
            }
            db.closeConnection();

            MySqlCommand command = new MySqlCommand("SELECT COUNT(*) FROM users", db.getConnection());
            db.openConnection();
            int count = Convert.ToInt32(command.ExecuteScalar());


            label5.Text = string.Format("{0}\nВсего\nАккаунтов\nВ базе", count);
            label5.AutoSize = false;
            label5.TextAlign = ContentAlignment.TopRight;
            label5.ForeColor = Color.White;
            label4.Text = string.Format("{0}\nВсего\nАккаунтов\nВ базе", count);
            label9.Text = GetLastFact();
            label9.TextAlign = ContentAlignment.TopRight;
            label9.ForeColor = Color.White;
            label4.Text = result;

            db.closeConnection();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            int arcSize = 20; // Задайте значение радиуса закругления, как вам нужно
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
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            int arcSize = 10; // Задайте значение радиуса закругления, как вам нужно
            int x = 0;
            int y = 0;
            int width = panel2.Width;
            int height = panel2.Height;

            path.AddArc(x, y, arcSize, arcSize, 180, 90);
            path.AddArc(width - arcSize, y, arcSize, arcSize, 270, 90);
            path.AddArc(width - arcSize, height - arcSize, arcSize, arcSize, 0, 90);
            path.AddArc(x, height - arcSize, arcSize, arcSize, 90, 90);
            path.CloseAllFigures();

            panel2.Region = new System.Drawing.Region(path);
        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            int arcSize = 20; // Задайте значение радиуса закругления, как вам нужно
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
        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            int arcSize = 10; // Задайте значение радиуса закругления, как вам нужно
            int x = 0;
            int y = 0;
            int width = panel4.Width;
            int height = panel4.Height;

            path.AddArc(x, y, arcSize, arcSize, 180, 90);
            path.AddArc(width - arcSize, y, arcSize, arcSize, 270, 90);
            path.AddArc(width - arcSize, height - arcSize, arcSize, arcSize, 0, 90);
            path.AddArc(x, height - arcSize, arcSize, arcSize, 90, 90);
            path.CloseAllFigures();

            panel4.Region = new System.Drawing.Region(path);
        }
        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            int arcSize = 20; // Задайте значение радиуса закругления, как вам нужно
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
        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            int arcSize = 10; // Задайте значение радиуса закругления, как вам нужно
            int x = 0;
            int y = 0;
            int width = panel6.Width;
            int height = panel6.Height;

            path.AddArc(x, y, arcSize, arcSize, 180, 90);
            path.AddArc(width - arcSize, y, arcSize, arcSize, 270, 90);
            path.AddArc(width - arcSize, height - arcSize, arcSize, arcSize, 0, 90);
            path.AddArc(x, height - arcSize, arcSize, arcSize, 90, 90);
            path.CloseAllFigures();

            panel6.Region = new System.Drawing.Region(path);
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        public string GetLastFact()
        {
            string lastFact = "";

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("SELECT faxes FROM faxes_table ORDER BY id DESC LIMIT 1", db.getConnection());

            try
            {
                db.openConnection();

                object result = command.ExecuteScalar();

                if (result != null)
                {
                    lastFact = result.ToString();
                }

                db.closeConnection();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            return lastFact;
        }

        private void Main_Load_1(object sender, EventArgs e)
        {
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            // Получение всех фактов из базы данных
            List<string> allReviews = GetAllReviews();

            if (allReviews.Count > 0)
            {
                // Получение случайного факта из базы данных
                Random random = new Random();
                string randomReview = allReviews[random.Next(allReviews.Count)];

                // Вывод случайного факта
                label4.Text = randomReview;
                label6.Text = "Рандомный отзыв";
            }
            else
            {
                label4.Text = "База данных пуста.";
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            // Получение всех фактов из базы данных
            List<string> allFacts = GetAllFacts();


            // Получение случайного факта из базы данных
            Random random = new Random();
            string randomReview = allFacts[random.Next(allFacts.Count)];

            // Вывод случайного факта
            label9.Text = randomReview;
            label8.Text = "Рандомный факт из БД";
        }

        public List<string> GetAllFacts()
        {
            List<string> allFacts = new List<string>();

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("SELECT faxes FROM faxes_table", db.getConnection());

            try
            {
                db.openConnection();

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string fact = reader.GetString("faxes");
                    allFacts.Add(fact);
                }

                reader.Close();
                db.closeConnection();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            return allFacts;
        }
        public List<string> GetAllReviews()
        {
            List<string> reviews = new List<string>();
            DB db = new DB();


            MySqlCommand command = new MySqlCommand("SELECT competence, justice, material, estimation, name FROM justice_table", db.getConnection());

            db.openConnection();
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string result = "";
                result += "Компетенция: " + reader.GetString(0) + "\n";
                result += "Справедливость: " + reader.GetString(1) + "\n";
                result += "Материал: " + reader.GetString(2) + "\n";
                result += "Оценка: " + reader.GetString(3) + "\n";
                result += "ФИО: " + reader.GetString(4) + "\n";

                reviews.Add(result);
            }

            db.closeConnection();

            return reviews;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            New_Fax NewFax = new New_Fax();
            NewFax.Show();
            Hide();
            this.CenterToScreen();
        }

        private void button_vhod_Click(object sender, EventArgs e)
        {
            Reviews reviews = new Reviews();
            reviews.Show();
            Hide();
            this.CenterToScreen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AllReviews allreviews = new AllReviews();
            allreviews.Show();
            Hide();
            this.CenterToScreen();
        }
    }

}
