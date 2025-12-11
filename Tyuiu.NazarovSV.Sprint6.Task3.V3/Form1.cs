using Tyuiu.NazarovSV.Sprint6.Task3.V3.Lib;
using System.Windows.Forms;

namespace Tyuiu.NazarovSV.Sprint6.Task3.V3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Class1 dataService = new Class1();
        int[,] defaultMatrix = new int[5, 5] {
                { -18 , 21 , 10 , -2 , 12 },
                { -18, -10 , 33 ,-20 , 32 },
                { 14, -15, -14,  12, -18},
                { -19 ,  5 , -3 , 28, -17},
                { -14 , -9 , 23, -13 , 11}
        };

        private void buttonFuncStart_AY_Click(object sender, EventArgs e)
        {
            int rows = 5;
            int cols = 5;

            dataGridView1.ColumnCount = cols;
            dataGridView1.RowCount = rows;

            int[,] res = dataService.Calculate(defaultMatrix);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = Convert.ToString(res[i, j]);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
