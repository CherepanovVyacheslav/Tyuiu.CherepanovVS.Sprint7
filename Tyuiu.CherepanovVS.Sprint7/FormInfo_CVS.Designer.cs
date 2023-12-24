
namespace Tyuiu.CherepanovVS.Sprint7
{
    partial class FormInfo_CVS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInfo_CVS));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxInfoforPrograme_CVS = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 195);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxInfoforPrograme_CVS
            // 
            this.textBoxInfoforPrograme_CVS.BackColor = System.Drawing.Color.PapayaWhip;
            this.textBoxInfoforPrograme_CVS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxInfoforPrograme_CVS.Location = new System.Drawing.Point(236, 13);
            this.textBoxInfoforPrograme_CVS.Multiline = true;
            this.textBoxInfoforPrograme_CVS.Name = "textBoxInfoforPrograme_CVS";
            this.textBoxInfoforPrograme_CVS.ReadOnly = true;
            this.textBoxInfoforPrograme_CVS.Size = new System.Drawing.Size(455, 197);
            this.textBoxInfoforPrograme_CVS.TabIndex = 1;
            this.textBoxInfoforPrograme_CVS.Text = resources.GetString("textBoxInfoforPrograme_CVS.Text");
            this.textBoxInfoforPrograme_CVS.TextChanged += new System.EventHandler(this.textBoxInfoforPrograme_CVS_TextChanged);
            // 
            // FormInfo_CVS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(703, 220);
            this.Controls.Add(this.textBoxInfoforPrograme_CVS);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormInfo_CVS";
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxInfoforPrograme_CVS;
    }
}