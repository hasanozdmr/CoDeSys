namespace KEPCE
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pbxGovde = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pbxKolD2 = new System.Windows.Forms.PictureBox();
            this.pbxKolD3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGovde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxKolD2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxKolD3)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxGovde
            // 
            this.pbxGovde.BackColor = System.Drawing.Color.Transparent;
            this.pbxGovde.Image = ((System.Drawing.Image)(resources.GetObject("pbxGovde.Image")));
            this.pbxGovde.Location = new System.Drawing.Point(12, 98);
            this.pbxGovde.Name = "pbxGovde";
            this.pbxGovde.Size = new System.Drawing.Size(300, 208);
            this.pbxGovde.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxGovde.TabIndex = 1;
            this.pbxGovde.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(809, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 48);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            // 
            // pbxKolD2
            // 
            this.pbxKolD2.BackColor = System.Drawing.Color.Transparent;
            this.pbxKolD2.Image = ((System.Drawing.Image)(resources.GetObject("pbxKolD2.Image")));
            this.pbxKolD2.Location = new System.Drawing.Point(306, 98);
            this.pbxKolD2.Name = "pbxKolD2";
            this.pbxKolD2.Size = new System.Drawing.Size(64, 197);
            this.pbxKolD2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxKolD2.TabIndex = 5;
            this.pbxKolD2.TabStop = false;
            // 
            // pbxKolD3
            // 
            this.pbxKolD3.BackColor = System.Drawing.Color.Transparent;
            this.pbxKolD3.Image = ((System.Drawing.Image)(resources.GetObject("pbxKolD3.Image")));
            this.pbxKolD3.Location = new System.Drawing.Point(306, 98);
            this.pbxKolD3.Name = "pbxKolD3";
            this.pbxKolD3.Size = new System.Drawing.Size(138, 82);
            this.pbxKolD3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxKolD3.TabIndex = 6;
            this.pbxKolD3.TabStop = false;
            this.pbxKolD3.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(929, 544);
            this.Controls.Add(this.pbxKolD2);
            this.Controls.Add(this.pbxGovde);
            this.Controls.Add(this.pbxKolD3);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbxGovde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxKolD2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxKolD3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pbxGovde;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pbxKolD2;
        private System.Windows.Forms.PictureBox pbxKolD3;
    }
}

