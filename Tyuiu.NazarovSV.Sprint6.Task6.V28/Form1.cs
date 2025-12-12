using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.NazarovSV.Sprint6.Task6.V28.Lib;

namespace Tyuiu.NazarovSV.Sprint6.Task6.V28
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        private void buttonSave_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonUpload_Click(object sender, EventArgs e)
        {
            string str = "**";
            textBoxOutPut.Text = ds.CollectTextFromFile(str, );
        }
    }
}
