using System.Data;

namespace MultiplicationTable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int[,] table = new int[10, 10];
            for (int i = 0; i < 10; i++)
                for (int j = 0; j < 10; j++)
                    table[i, j] = (i + 1) * (j + 1);
            DataTable dt = new DataTable();
            for (int c = 1; c <= 10; c++)
                dt.Columns.Add(c.ToString(), typeof(int));
            for (int i = 0; i < 10; i++)
            {
                DataRow row = dt.NewRow();
                for (int j = 0; j < 10; j++)
                    row[j] = table[i, j];
                dt.Rows.Add(row);
            }
            dataGridView1.DataSource = dt;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.RowHeadersVisible = false;
        }
    }
}
