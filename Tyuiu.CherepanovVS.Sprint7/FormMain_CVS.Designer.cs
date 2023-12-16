
namespace Tyuiu.CherepanovVS.Sprint7
{
    partial class FormMain_CVS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_CVS));
            this.panelButton_CVS = new System.Windows.Forms.Panel();
            this.buttonInfo_CVS = new System.Windows.Forms.Button();
            this.buttonOpenFile_CVS = new System.Windows.Forms.Button();
            this.groupBoxInfo_CVS = new System.Windows.Forms.GroupBox();
            this.textBoxInputNameDivicion_CVS = new System.Windows.Forms.TextBox();
            this.textBoxNameDivision_CVS = new System.Windows.Forms.TextBox();
            this.panelButton_CVS.SuspendLayout();
            this.groupBoxInfo_CVS.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelButton_CVS
            // 
            this.panelButton_CVS.Controls.Add(this.buttonInfo_CVS);
            this.panelButton_CVS.Controls.Add(this.buttonOpenFile_CVS);
            this.panelButton_CVS.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButton_CVS.Location = new System.Drawing.Point(0, 0);
            this.panelButton_CVS.Name = "panelButton_CVS";
            this.panelButton_CVS.Size = new System.Drawing.Size(800, 97);
            this.panelButton_CVS.TabIndex = 0;
            // 
            // buttonInfo_CVS
            // 
            this.buttonInfo_CVS.Image = ((System.Drawing.Image)(resources.GetObject("buttonInfo_CVS.Image")));
            this.buttonInfo_CVS.Location = new System.Drawing.Point(697, 12);
            this.buttonInfo_CVS.Name = "buttonInfo_CVS";
            this.buttonInfo_CVS.Size = new System.Drawing.Size(91, 74);
            this.buttonInfo_CVS.TabIndex = 0;
            this.buttonInfo_CVS.UseVisualStyleBackColor = true;
            // 
            // buttonOpenFile_CVS
            // 
            this.buttonOpenFile_CVS.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile_CVS.Image")));
            this.buttonOpenFile_CVS.Location = new System.Drawing.Point(12, 12);
            this.buttonOpenFile_CVS.Name = "buttonOpenFile_CVS";
            this.buttonOpenFile_CVS.Size = new System.Drawing.Size(114, 74);
            this.buttonOpenFile_CVS.TabIndex = 0;
            this.buttonOpenFile_CVS.UseVisualStyleBackColor = true;
            // 
            // groupBoxInfo_CVS
            // 
            this.groupBoxInfo_CVS.Controls.Add(this.textBoxInputNameDivicion_CVS);
            this.groupBoxInfo_CVS.Controls.Add(this.textBoxNameDivision_CVS);
            this.groupBoxInfo_CVS.Location = new System.Drawing.Point(12, 103);
            this.groupBoxInfo_CVS.Name = "groupBoxInfo_CVS";
            this.groupBoxInfo_CVS.Size = new System.Drawing.Size(330, 335);
            this.groupBoxInfo_CVS.TabIndex = 1;
            this.groupBoxInfo_CVS.TabStop = false;
            this.groupBoxInfo_CVS.Text = "Данные об отделе";
            // 
            // textBoxInputNameDivicion_CVS
            // 
            this.textBoxInputNameDivicion_CVS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxInputNameDivicion_CVS.Location = new System.Drawing.Point(7, 52);
            this.textBoxInputNameDivicion_CVS.Multiline = true;
            this.textBoxInputNameDivicion_CVS.Name = "textBoxInputNameDivicion_CVS";
            this.textBoxInputNameDivicion_CVS.Size = new System.Drawing.Size(317, 26);
            this.textBoxInputNameDivicion_CVS.TabIndex = 1;
            // 
            // textBoxNameDivision_CVS
            // 
            this.textBoxNameDivision_CVS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNameDivision_CVS.Location = new System.Drawing.Point(7, 26);
            this.textBoxNameDivision_CVS.Name = "textBoxNameDivision_CVS";
            this.textBoxNameDivision_CVS.ReadOnly = true;
            this.textBoxNameDivision_CVS.Size = new System.Drawing.Size(263, 19);
            this.textBoxNameDivision_CVS.TabIndex = 0;
            this.textBoxNameDivision_CVS.Text = "Наименование подразделения";
            // 
            // FormMain_CVS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxInfo_CVS);
            this.Controls.Add(this.panelButton_CVS);
            this.Name = "FormMain_CVS";
            this.Text = "Спринт 7 | Task Project | Вариант 11 | Черепанов В.С.";
            this.panelButton_CVS.ResumeLayout(false);
            this.groupBoxInfo_CVS.ResumeLayout(false);
            this.groupBoxInfo_CVS.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelButton_CVS;
        private System.Windows.Forms.Button buttonInfo_CVS;
        private System.Windows.Forms.Button buttonOpenFile_CVS;
        private System.Windows.Forms.GroupBox groupBoxInfo_CVS;
        private System.Windows.Forms.TextBox textBoxInputNameDivicion_CVS;
        private System.Windows.Forms.TextBox textBoxNameDivision_CVS;
    }
}

