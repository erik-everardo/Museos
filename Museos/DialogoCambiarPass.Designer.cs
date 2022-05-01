namespace Museos
{
    partial class DialogoCambiarPass
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPassActual = new System.Windows.Forms.TextBox();
            this.textBoxNuevaPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Contraseña actual";
            // 
            // textBoxPassActual
            // 
            this.textBoxPassActual.Location = new System.Drawing.Point(12, 43);
            this.textBoxPassActual.Name = "textBoxPassActual";
            this.textBoxPassActual.PasswordChar = '*';
            this.textBoxPassActual.Size = new System.Drawing.Size(305, 23);
            this.textBoxPassActual.TabIndex = 1;
            // 
            // textBoxNuevaPass
            // 
            this.textBoxNuevaPass.Location = new System.Drawing.Point(12, 92);
            this.textBoxNuevaPass.Name = "textBoxNuevaPass";
            this.textBoxNuevaPass.PasswordChar = '*';
            this.textBoxNuevaPass.Size = new System.Drawing.Size(305, 23);
            this.textBoxNuevaPass.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nueva contraseña";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(242, 143);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // DialogoCambiarPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 178);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNuevaPass);
            this.Controls.Add(this.textBoxPassActual);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "DialogoCambiarPass";
            this.Text = "Cambiar contraseña";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBoxPassActual;
        private TextBox textBoxNuevaPass;
        private Label label2;
        private Button btnAceptar;
    }
}