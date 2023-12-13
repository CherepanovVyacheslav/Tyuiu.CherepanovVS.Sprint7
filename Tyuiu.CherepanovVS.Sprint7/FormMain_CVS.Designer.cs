
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
            this.buttonOpenFile_CVS = new System.Windows.Forms.Button();
            this.buttonInfo_CVS = new System.Windows.Forms.Button();
            this.panelButton_CVS.SuspendLayout();
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
            // buttonOpenFile_CVS
            // 
            this.buttonOpenFile_CVS.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile_CVS.Image")));
            this.buttonOpenFile_CVS.Location = new System.Drawing.Point(12, 12);
            this.buttonOpenFile_CVS.Name = "buttonOpenFile_CVS";
            this.buttonOpenFile_CVS.Size = new System.Drawing.Size(114, 74);
            this.buttonOpenFile_CVS.TabIndex = 0;
            this.buttonOpenFile_CVS.UseVisualStyleBackColor = true;
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
            // FormMain_CVS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelButton_CVS);
            this.Name = "FormMain_CVS";
            this.Text = "Спринт 7 | Task Project | Вариант 11 | Черепанов В.С.";
            this.panelButton_CVS.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelButton_CVS;
        private System.Windows.Forms.Button buttonInfo_CVS;
        private System.Windows.Forms.Button buttonOpenFile_CVS;
    }
}

