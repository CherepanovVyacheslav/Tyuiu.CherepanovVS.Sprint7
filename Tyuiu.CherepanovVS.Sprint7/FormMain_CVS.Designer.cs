
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
            this.buttonMenu_CVS = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelButton_CVS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelButton_CVS
            // 
            this.panelButton_CVS.BackColor = System.Drawing.Color.PapayaWhip;
            this.panelButton_CVS.Controls.Add(this.buttonInfo_CVS);
            this.panelButton_CVS.Controls.Add(this.buttonMenu_CVS);
            this.panelButton_CVS.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelButton_CVS.Location = new System.Drawing.Point(0, 0);
            this.panelButton_CVS.Name = "panelButton_CVS";
            this.panelButton_CVS.Size = new System.Drawing.Size(142, 450);
            this.panelButton_CVS.TabIndex = 0;
            // 
            // buttonInfo_CVS
            // 
            this.buttonInfo_CVS.BackColor = System.Drawing.Color.LightSalmon;
            this.buttonInfo_CVS.Image = ((System.Drawing.Image)(resources.GetObject("buttonInfo_CVS.Image")));
            this.buttonInfo_CVS.Location = new System.Drawing.Point(12, 101);
            this.buttonInfo_CVS.Name = "buttonInfo_CVS";
            this.buttonInfo_CVS.Size = new System.Drawing.Size(114, 71);
            this.buttonInfo_CVS.TabIndex = 0;
            this.buttonInfo_CVS.UseVisualStyleBackColor = false;
            this.buttonInfo_CVS.Click += new System.EventHandler(this.buttonInfo_CVS_Click);
            // 
            // buttonMenu_CVS
            // 
            this.buttonMenu_CVS.BackColor = System.Drawing.Color.LightSalmon;
            this.buttonMenu_CVS.Image = ((System.Drawing.Image)(resources.GetObject("buttonMenu_CVS.Image")));
            this.buttonMenu_CVS.Location = new System.Drawing.Point(12, 12);
            this.buttonMenu_CVS.Name = "buttonMenu_CVS";
            this.buttonMenu_CVS.Size = new System.Drawing.Size(114, 74);
            this.buttonMenu_CVS.TabIndex = 0;
            this.buttonMenu_CVS.UseVisualStyleBackColor = false;
            this.buttonMenu_CVS.Click += new System.EventHandler(this.buttonMenu_CVS_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.PapayaWhip;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(142, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(628, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FormMain_CVS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelButton_CVS);
            this.MinimumSize = new System.Drawing.Size(792, 506);
            this.Name = "FormMain_CVS";
            this.Text = "Спринт 7 | Task Project | Вариант 11 | Черепанов В.С.";
            this.panelButton_CVS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelButton_CVS;
        private System.Windows.Forms.Button buttonInfo_CVS;
        private System.Windows.Forms.Button buttonMenu_CVS;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

