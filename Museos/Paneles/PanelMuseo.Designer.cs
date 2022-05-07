namespace Museos.Paneles
{
    partial class PanelMuseo
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.historia = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fechaFundación = new System.Windows.Forms.DateTimePicker();
            this.botonGuardar = new System.Windows.Forms.Button();
            this.btnImagenInterativa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(25, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Museo";
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(23, 93);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(240, 23);
            this.nombre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // historia
            // 
            this.historia.Location = new System.Drawing.Point(23, 137);
            this.historia.Name = "historia";
            this.historia.Size = new System.Drawing.Size(240, 155);
            this.historia.TabIndex = 3;
            this.historia.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Historia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Fecha de fundación";
            // 
            // fechaFundación
            // 
            this.fechaFundación.Location = new System.Drawing.Point(23, 313);
            this.fechaFundación.Name = "fechaFundación";
            this.fechaFundación.Size = new System.Drawing.Size(240, 23);
            this.fechaFundación.TabIndex = 6;
            // 
            // botonGuardar
            // 
            this.botonGuardar.Location = new System.Drawing.Point(188, 357);
            this.botonGuardar.Name = "botonGuardar";
            this.botonGuardar.Size = new System.Drawing.Size(75, 23);
            this.botonGuardar.TabIndex = 7;
            this.botonGuardar.Text = "Guardar";
            this.botonGuardar.UseVisualStyleBackColor = true;
            this.botonGuardar.Click += new System.EventHandler(this.botonGuardar_Click);
            // 
            // btnImagenInterativa
            // 
            this.btnImagenInterativa.Location = new System.Drawing.Point(23, 357);
            this.btnImagenInterativa.Name = "btnImagenInterativa";
            this.btnImagenInterativa.Size = new System.Drawing.Size(109, 23);
            this.btnImagenInterativa.TabIndex = 8;
            this.btnImagenInterativa.Text = "Imagen interativa";
            this.btnImagenInterativa.UseVisualStyleBackColor = true;
            this.btnImagenInterativa.Click += new System.EventHandler(this.btnImagenInterativa_Click);
            // 
            // PanelMuseo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.btnImagenInterativa);
            this.Controls.Add(this.botonGuardar);
            this.Controls.Add(this.fechaFundación);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.historia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.label1);
            this.Name = "PanelMuseo";
            this.Size = new System.Drawing.Size(802, 432);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox nombre;
        private Label label2;
        private RichTextBox historia;
        private Label label3;
        private Label label4;
        private DateTimePicker fechaFundación;
        private Button botonGuardar;
        private Button btnImagenInterativa;
    }
}
