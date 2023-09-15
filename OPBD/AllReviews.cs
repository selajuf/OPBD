using MySqlConnector;
using System.Runtime.InteropServices;

namespace OPBD
{
    public partial class AllReviews : Form

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
        public AllReviews()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            SetStyle(ControlStyles.ResizeRedraw, true); // Это необходимо для перерисовки обводки при изменении размеров панели
            // Добавление столбцов в DataGridView
            dataGridView1.Columns.Add("competence", "Компетенция");
            dataGridView1.Columns.Add("justice", "Справедливость");
            dataGridView1.Columns.Add("material", "Материал");
            dataGridView1.Columns.Add("estimation", "Оценка");
            dataGridView1.Columns.Add("name", "ФИО");

            // Установка свойств столбцов
            dataGridView1.Columns["competence"].Width = 100;
            dataGridView1.Columns["justice"].Width = 100;
            dataGridView1.Columns["material"].Width = 100;
            dataGridView1.Columns["estimation"].Width = 100;
            dataGridView1.Columns["name"].Width = 250;
            // Получение данных из базы данных
            List<string[]> rows = GetAllReviewsAsRows();

            // Добавление данных в DataGridView
            foreach (string[] row in rows)
            {
                dataGridView1.Rows.Add(row);
            }

        }
        // Функция для получения всех записей из базы данных
        private List<string[]> GetAllReviewsAsRows()
        {
            List<string[]> rows = new List<string[]>();
            DB db = new DB();

            MySqlCommand command = new MySqlCommand("SELECT competence, justice, material, estimation, name FROM justice_table", db.getConnection());

            db.openConnection();
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string[] row = new string[5];
                row[0] = reader.GetString(0);
                row[1] = reader.GetString(1);
                row[2] = reader.GetString(2);
                row[3] = reader.GetString(3);
                row[4] = reader.GetString(4);

                rows.Add(row);
            }

            db.closeConnection();

            return rows;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AllReviews_Load(object sender, EventArgs e)
        {

        }

        private void button_vhod_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            Hide();
            this.CenterToScreen();
        }
    }

}
