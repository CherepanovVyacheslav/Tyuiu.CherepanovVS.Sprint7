using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.CherepanovVS.Sprint7.Lib;

namespace Tyuiu.CherepanovVS.Sprint7
{
    public partial class FormMath_CVS : Form
    {
        public FormMath_CVS()
        {
            InitializeComponent();
        }

        private void buttonMath_CVS_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            string path = @"C:\Users\Вячеслав\source\repos\Tyuiu.CherepanovVS.Sprint7\Tyuiu.CherepanovVS.Sprint7\bin\Debug\InputFileTaskProject.V11(числа).csv";
            double result = ds.LoadFromDataFile(path);
            textBoxMath_CVS.Text = Convert.ToString(result);
        }
    }
}
