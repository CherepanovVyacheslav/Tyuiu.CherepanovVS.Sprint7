using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.CherepanovVS.Sprint7.Lib;

namespace Tyuiu.CherepanovVS.Sprint7
{
    public partial class FormInputData_CVS : Form
    {
        public FormInputData_CVS()
        {
            InitializeComponent();
        }

        private void textBoxInputData_CVS_TextChanged(object sender, EventArgs e)
        {

        }


        private void buttonOk_CVS_Click(object sender, EventArgs e)
        {


            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                dataGridViewOutPutData_CVS.Rows.Clear();

                dataGridViewOutPutData_CVS.Columns.Add("Column1", "Строка");

                try
                {
                    using (StreamReader sr = new StreamReader(openFileDialog1.FileName))
                    {

                        string line;
                        int count = -1;

                        while ((line = sr.ReadLine()) != null)
                        {
                            FormInputData_CVS input = new FormInputData_CVS();
                            string[] data = line.Split('\t');
                            dataGridViewOutPutData_CVS.Rows.Add(data);

                            count++;
                            if (count >= Convert.ToInt32(textBoxInputData_CVS.Text)) break;
                           

                        }
                        if (Convert.ToInt32(textBoxInputData_CVS.Text) > 25)
                        {
                            MessageBox.Show("Введено неверное значение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Ошибка: " + ex.Message);
                }
            }
           
            
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                
                string filePath = dialog.FileName;

               
                using (StreamReader reader = new StreamReader(filePath))
                {
                    List<string> lines = new List<string>();

                    
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                      lines.Add(line);
                    }

                   
                    foreach (string filteredLine in lines)
                    {
                        chartOutputData_CVS.Series[0].Points.AddY(filteredLine);
                    }
                }
            }
        }

        private void dataGridViewOutPutData_CVS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void chartOutputData_CVS_Click(object sender, EventArgs e)
        {

        }

        private void buttonSave_CVS_Click(object sender, EventArgs e)
        {
            
            try
            {
                string filePath = $@"{ Directory.GetCurrentDirectory()}\OutPutFileTaskProject.txt";


                using (StreamWriter sw = new StreamWriter(filePath))
                {

                    for (int i = 0; i < dataGridViewOutPutData_CVS.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridViewOutPutData_CVS.Columns.Count; j++)
                        {

                            sw.Write(dataGridViewOutPutData_CVS.Rows[i].Cells[j].Value?.ToString() + "\t");
                        }

                        sw.WriteLine();
                    }
                }

                DialogResult dialog = MessageBox.Show("Файл" + filePath + " сохранен успешно.\nОткрыть его?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialog == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = filePath;
                    txt.Start();
                }

            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void buttonMath_CVS_Click(object sender, EventArgs e)
        {

        }

        private void buttonOklad_CVS_Click(object sender, EventArgs e)
        {
            FormMath_CVS form = new FormMath_CVS();
            form.ShowDialog();
        }
    }
}
