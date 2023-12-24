
namespace Tyuiu.CherepanovVS.Sprint7
{
    partial class FormMath_CVS
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
            this.buttonMath_CVS = new System.Windows.Forms.Button();
            this.textBoxMath_CVS = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonMath_CVS
            // 
            this.buttonMath_CVS.Location = new System.Drawing.Point(283, 12);
            this.buttonMath_CVS.Name = "buttonMath_CVS";
            this.buttonMath_CVS.Size = new System.Drawing.Size(115, 55);
            this.buttonMath_CVS.TabIndex = 5;
            this.buttonMath_CVS.Text = "Выполнить";
            this.buttonMath_CVS.UseVisualStyleBackColor = true;
            this.buttonMath_CVS.Click += new System.EventHandler(this.buttonMath_CVS_Click);
            // 
            // textBoxMath_CVS
            // 
            this.textBoxMath_CVS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMath_CVS.Location = new System.Drawing.Point(12, 12);
            this.textBoxMath_CVS.Multiline = true;
            this.textBoxMath_CVS.Name = "textBoxMath_CVS";
            this.textBoxMath_CVS.ReadOnly = true;
            this.textBoxMath_CVS.Size = new System.Drawing.Size(255, 55);
            this.textBoxMath_CVS.TabIndex = 6;
            // 
            // FormMath_CVS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(410, 85);
            this.Controls.Add(this.textBoxMath_CVS);
            this.Controls.Add(this.buttonMath_CVS);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimumSize = new System.Drawing.Size(432, 141);
            this.Name = "FormMath_CVS";
            this.Text = "Нахождение среднего оклада";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonMath_CVS;
        private System.Windows.Forms.TextBox textBoxMath_CVS;
    }
}