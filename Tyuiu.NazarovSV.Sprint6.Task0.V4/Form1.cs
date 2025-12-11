using Tyuiu.NazarovSV.Sprint6.Task0.V4.Lib;
namespace Tyuiu.NazarovSV.Sprint6.Task0.V4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBoxInfo_AY_Enter(object sender, EventArgs e)
        {

        }

        private void labelInfo_AY_Click(object sender, EventArgs e)
        {

        }

        private void textBoxAnswer_AY_TextChanged(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            int x = 3;
            double res = ds.Calculate(x);
            string textBoxAnswer_AY = res.ToString();
        }
    }
}
