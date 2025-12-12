using Tyuiu.NazarovSV.Sprint6.Task4.V20.Lib;
namespace Tyuiu.NazarovSV.Sprint6.Task4.V20
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService dataservice = new DataService();

        private void buttonStart_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep.Text);
                int len = dataservice.GetMassFunction(startStep, stopStep).Length;
                double[] valueArray;
                valueArray = new double[len];
                valueArray = dataservice.GetMassFunction(startStep, stopStep);
                textBoxResult.Text = "";
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", " Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $"{Path.GetTempPath()}\\OutPutFileTask4.txt";
                File.WriteAllText(path, textBoxResult.Text);
                DialogResult dialogResult = MessageBox.Show("Файл " + path + " сохранён успешно \n Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
