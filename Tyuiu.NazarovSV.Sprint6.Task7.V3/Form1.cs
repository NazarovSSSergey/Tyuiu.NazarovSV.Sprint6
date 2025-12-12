using Tyuiu.NazarovSV.Sprint6.Task7.V3.Lib;
namespace Tyuiu.NazarovSV.Sprint6.Task7.V3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            openFileDialogTask.Filter = "Значение, разделённое запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            openFileDialogMatrix.Filter = "Значение, разделённое запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridViewIn.ColumnCount = 50;
            dataGridViewOut.ColumnCount = 50;
            dataGridViewOut.RowCount = 50;
            dataGridViewIn.RowCount = 50;
            for (int i = 0; i < 50; i++)
            {
                dataGridViewIn.Columns[i].Width = 50;
                dataGridViewOut.Columns[i].Width = 50;
            }

        }
        static int rows;
        static int columns;
        static string openFilePath;
        DataService ds = new DataService();
        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            int rows = lines.Length;
            int columns = lines[0].Split(';').Length;
            int[,] arrayValues = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                string[] line_i = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    arrayValues[i, j] = Convert.ToInt32(line_i[j]);
                }
            }
            return arrayValues;
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialogTask.ShowDialog();
            openFilePath = openFileDialogTask.FileName;

            int[,] arrayValues = LoadFromFileData(openFilePath);

            
            if (arrayValues == null || arrayValues.GetLength(0) == 0 || arrayValues.GetLength(1) == 0)
            {
                MessageBox.Show("файл не содержит данных или данные некорректны.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            rows = arrayValues.GetLength(0); 
            columns = arrayValues.GetLength(1); 

            
            dataGridViewIn.ColumnCount = columns;
            dataGridViewIn.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewIn.Columns[i].Width = 25;
            }

     
            for (int j = 0; j < rows; j++)
            {
                for (int k = 0; k < columns; k++)
                {
                    dataGridViewIn.Rows[j].Cells[k].Value = arrayValues[j, k];
                }
            }

            buttonDone.Enabled = true; 
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            int[,] resultArrayValues = ds.GetMatrix(openFilePath);

            if (resultArrayValues == null || resultArrayValues.GetLength(0) == 0 || resultArrayValues.GetLength(1) == 0)
            {
                MessageBox.Show("Нет данных для отображения.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dataGridViewOut.ColumnCount = resultArrayValues.GetLength(1);
            dataGridViewOut.RowCount = resultArrayValues.GetLength(0);

            for (int i = 0; i < resultArrayValues.GetLength(1); i++)
            {
                dataGridViewOut.Columns[i].Width = 25;
            }
            for (int i = 0; i < resultArrayValues.GetLength(0); i++)
            {
                for (int j = 0; j < resultArrayValues.GetLength(1); j++)
                {
                    dataGridViewOut.Rows[i].Cells[j].Value = resultArrayValues[i, j];
                }
            }

            buttonSave.Enabled = true;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix.FileName = "OutPutFileTask7V3.scv";
            saveFileDialogMatrix.InitialDirectory = Path.GetTempPath();
            saveFileDialogMatrix.ShowDialog();
            string path = saveFileDialogMatrix.FileName;
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }
            int rows = dataGridViewOut.RowCount;
            int columns = dataGridViewOut.ColumnCount;
            string str = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOut.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOut.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";

            }
        }
        private void buttonOpenFile_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton.ToolTipTitle = "Открыть файл";
        }
        private void buttonDone_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton.ToolTipTitle = "Выполнить";
        }
        private void buttonSave_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton.ToolTipTitle = "Сохранить в файл";
        }
        private void buttonHelp_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton.ToolTipTitle = "Справка";
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
