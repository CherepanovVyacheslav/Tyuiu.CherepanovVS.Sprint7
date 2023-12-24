using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Tyuiu.CherepanovVS.Sprint7
{
    public partial class FormMain_CVS : Form
    {
        public FormMain_CVS()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonInfo_CVS_Click(object sender, EventArgs e)
        {
            FormInfo_CVS form = new FormInfo_CVS();
            form.ShowDialog();
        }

        private void buttonMenu_CVS_Click(object sender, EventArgs e)
        {
            FormInputData_CVS form = new FormInputData_CVS();
            form.ShowDialog();
        }
    }
}
