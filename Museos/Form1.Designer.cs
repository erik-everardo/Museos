namespace Museos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonOpenAdmin = new System.Windows.Forms.Button();
            this.buttonOpenPublic = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonOpenAdmin
            // 
            this.buttonOpenAdmin.Location = new System.Drawing.Point(12, 109);
            this.buttonOpenAdmin.Name = "buttonOpenAdmin";
            this.buttonOpenAdmin.Size = new System.Drawing.Size(305, 23);
            this.buttonOpenAdmin.TabIndex = 0;
            this.buttonOpenAdmin.Text = "Administrador";
            this.buttonOpenAdmin.UseVisualStyleBackColor = true;
            this.buttonOpenAdmin.Click += new System.EventHandler(this.buttonOpenAdmin_Click);
            // 
            // buttonOpenPublic
            // 
            this.buttonOpenPublic.Location = new System.Drawing.Point(12, 138);
            this.buttonOpenPublic.Name = "buttonOpenPublic";
            this.buttonOpenPublic.Size = new System.Drawing.Size(305, 23);
            this.buttonOpenPublic.TabIndex = 1;
            this.buttonOpenPublic.Text = "Público";
            this.buttonOpenPublic.UseVisualStyleBackColor = true;
            this.buttonOpenPublic.Click += new System.EventHandler(this.buttonOpenPublic_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 177);
            this.Controls.Add(this.buttonOpenPublic);
            this.Controls.Add(this.buttonOpenAdmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonOpenAdmin;
        private Button buttonOpenPublic;
    }
}