namespace Tyuiu.NazarovSV.Sprint6.Task7.V3
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            openFileDialogTask.Filter = "Значения, разделённые запятимы(*.csv)|*.csv|Все"
        }
    }
}
