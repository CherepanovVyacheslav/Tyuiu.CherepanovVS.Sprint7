
namespace Tyuiu.CherepanovVS.Sprint7
{
    partial class FormInputData_CVS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.textBoxInputText_CVS = new System.Windows.Forms.TextBox();
            this.textBoxInputData_CVS = new System.Windows.Forms.TextBox();
            this.buttonOk_CVS = new System.Windows.Forms.Button();
            this.groupBoxInputData_CVS = new System.Windows.Forms.GroupBox();
            this.buttonSave_CVS = new System.Windows.Forms.Button();
            this.chartOutputData_CVS = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridViewOutPutData_CVS = new System.Windows.Forms.DataGridView();
            this.buttonOklad_CVS = new System.Windows.Forms.Button();
            this.groupBoxInputData_CVS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartOutputData_CVS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPutData_CVS)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxInputText_CVS
            // 
            this.textBoxInputText_CVS.BackColor = System.Drawing.Color.PapayaWhip;
            this.textBoxInputText_CVS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxInputText_CVS.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxInputText_CVS.Location = new System.Drawing.Point(6, 25);
            this.textBoxInputText_CVS.Name = "textBoxInputText_CVS";
            this.textBoxInputText_CVS.ReadOnly = true;
            this.textBoxInputText_CVS.Size = new System.Drawing.Size(490, 23);
            this.textBoxInputText_CVS.TabIndex = 0;
            this.textBoxInputText_CVS.Text = "Какое количество сотрудников необходимо для анализа?";
            // 
            // textBoxInputData_CVS
            // 
            this.textBoxInputData_CVS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxInputData_CVS.Location = new System.Drawing.Point(6, 54);
            this.textBoxInputData_CVS.Name = "textBoxInputData_CVS";
            this.textBoxInputData_CVS.Size = new System.Drawing.Size(164, 26);
            this.textBoxInputData_CVS.TabIndex = 1;
            this.textBoxInputData_CVS.TextChanged += new System.EventHandler(this.textBoxInputData_CVS_TextChanged);
            // 
            // buttonOk_CVS
            // 
            this.buttonOk_CVS.Location = new System.Drawing.Point(176, 54);
            this.buttonOk_CVS.Name = "buttonOk_CVS";
            this.buttonOk_CVS.Size = new System.Drawing.Size(83, 31);
            this.buttonOk_CVS.TabIndex = 2;
            this.buttonOk_CVS.Text = "OK";
            this.buttonOk_CVS.UseVisualStyleBackColor = true;
            this.buttonOk_CVS.Click += new System.EventHandler(this.buttonOk_CVS_Click);
            // 
            // groupBoxInputData_CVS
            // 
            this.groupBoxInputData_CVS.Controls.Add(this.buttonOklad_CVS);
            this.groupBoxInputData_CVS.Controls.Add(this.buttonSave_CVS);
            this.groupBoxInputData_CVS.Controls.Add(this.textBoxInputData_CVS);
            this.groupBoxInputData_CVS.Controls.Add(this.textBoxInputText_CVS);
            this.groupBoxInputData_CVS.Controls.Add(this.buttonOk_CVS);
            this.groupBoxInputData_CVS.Location = new System.Drawing.Point(439, 12);
            this.groupBoxInputData_CVS.Name = "groupBoxInputData_CVS";
            this.groupBoxInputData_CVS.Size = new System.Drawing.Size(613, 91);
            this.groupBoxInputData_CVS.TabIndex = 3;
            this.groupBoxInputData_CVS.TabStop = false;
            this.groupBoxInputData_CVS.Text = "Ввод данных";
            // 
            // buttonSave_CVS
            // 
            this.buttonSave_CVS.Location = new System.Drawing.Point(265, 54);
            this.buttonSave_CVS.Name = "buttonSave_CVS";
            this.buttonSave_CVS.Size = new System.Drawing.Size(109, 31);
            this.buttonSave_CVS.TabIndex = 3;
            this.buttonSave_CVS.Text = "Сохранить";
            this.buttonSave_CVS.UseVisualStyleBackColor = true;
            this.buttonSave_CVS.Click += new System.EventHandler(this.buttonSave_CVS_Click);
            // 
            // chartOutputData_CVS
            // 
            chartArea1.Name = "ChartArea1";
            this.chartOutputData_CVS.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartOutputData_CVS.Legends.Add(legend1);
            this.chartOutputData_CVS.Location = new System.Drawing.Point(439, 110);
            this.chartOutputData_CVS.Name = "chartOutputData_CVS";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartOutputData_CVS.Series.Add(series1);
            this.chartOutputData_CVS.Size = new System.Drawing.Size(613, 474);
            this.chartOutputData_CVS.TabIndex = 4;
            this.chartOutputData_CVS.Text = "chart1";
            this.chartOutputData_CVS.Click += new System.EventHandler(this.chartOutputData_CVS_Click);
            // 
            // dataGridViewOutPutData_CVS
            // 
            this.dataGridViewOutPutData_CVS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridViewOutPutData_CVS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutPutData_CVS.ColumnHeadersVisible = false;
            this.dataGridViewOutPutData_CVS.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewOutPutData_CVS.Name = "dataGridViewOutPutData_CVS";
            this.dataGridViewOutPutData_CVS.RowHeadersVisible = false;
            this.dataGridViewOutPutData_CVS.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewOutPutData_CVS.RowTemplate.Height = 28;
            this.dataGridViewOutPutData_CVS.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewOutPutData_CVS.Size = new System.Drawing.Size(421, 572);
            this.dataGridViewOutPutData_CVS.TabIndex = 5;
            this.dataGridViewOutPutData_CVS.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOutPutData_CVS_CellContentClick);
            // 
            // buttonOklad_CVS
            // 
            this.buttonOklad_CVS.Location = new System.Drawing.Point(380, 54);
            this.buttonOklad_CVS.Name = "buttonOklad_CVS";
            this.buttonOklad_CVS.Size = new System.Drawing.Size(159, 31);
            this.buttonOklad_CVS.TabIndex = 4;
            this.buttonOklad_CVS.Text = "Средний оклад";
            this.buttonOklad_CVS.UseVisualStyleBackColor = true;
            this.buttonOklad_CVS.Click += new System.EventHandler(this.buttonOklad_CVS_Click);
            // 
            // FormInputData_CVS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(1064, 595);
            this.Controls.Add(this.dataGridViewOutPutData_CVS);
            this.Controls.Add(this.chartOutputData_CVS);
            this.Controls.Add(this.groupBoxInputData_CVS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormInputData_CVS";
            this.Text = "Ввод данных";
            this.groupBoxInputData_CVS.ResumeLayout(false);
            this.groupBoxInputData_CVS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartOutputData_CVS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPutData_CVS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInputText_CVS;
        private System.Windows.Forms.TextBox textBoxInputData_CVS;
        private System.Windows.Forms.Button buttonOk_CVS;
        private System.Windows.Forms.GroupBox groupBoxInputData_CVS;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartOutputData_CVS;
        private System.Windows.Forms.DataGridView dataGridViewOutPutData_CVS;
        private System.Windows.Forms.Button buttonSave_CVS;
        private System.Windows.Forms.Button buttonOklad_CVS;
    }
}