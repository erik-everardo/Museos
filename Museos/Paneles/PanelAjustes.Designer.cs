namespace Museos.Paneles
{
    partial class PanelAjustes
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
            this.btnCambiarPass = new System.Windows.Forms.Button();
            this.btnCrearCuenta = new System.Windows.Forms.Button();
            this.nombre = new System.Windows.Forms.Label();
            this.btnCambiarNombre = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(14, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ajustes";
            // 
            // btnCambiarPass
            // 
            this.btnCambiarPass.Location = new System.Drawing.Point(14, 116);
            this.btnCambiarPass.Name = "btnCambiarPass";
            this.btnCambiarPass.Size = new System.Drawing.Size(214, 23);
            this.btnCambiarPass.TabIndex = 1;
            this.btnCambiarPass.Text = "Cambiar contraseña";
            this.btnCambiarPass.UseVisualStyleBackColor = true;
            this.btnCambiarPass.Click += new System.EventHandler(this.btnCambiarPass_Click);
            // 
            // btnCrearCuenta
            // 
            this.btnCrearCuenta.Location = new System.Drawing.Point(14, 145);
            this.btnCrearCuenta.Name = "btnCrearCuenta";
            this.btnCrearCuenta.Size = new System.Drawing.Size(214, 23);
            this.btnCrearCuenta.TabIndex = 2;
            this.btnCrearCuenta.Text = "Crear nueva cuenta de administrador";
            this.btnCrearCuenta.UseVisualStyleBackColor = true;
            this.btnCrearCuenta.Click += new System.EventHandler(this.btnCrearCuenta_Click);
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Location = new System.Drawing.Point(14, 52);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(0, 15);
            this.nombre.TabIndex = 4;
            // 
            // btnCambiarNombre
            // 
            this.btnCambiarNombre.Location = new System.Drawing.Point(14, 87);
            this.btnCambiarNombre.Name = "btnCambiarNombre";
            this.btnCambiarNombre.Size = new System.Drawing.Size(214, 23);
            this.btnCambiarNombre.TabIndex = 5;
            this.btnCambiarNombre.Text = "Cambiar nombre";
            this.btnCambiarNombre.UseVisualStyleBackColor = true;
            this.btnCambiarNombre.Click += new System.EventHandler(this.btnCambiarNombre_Click);
            // 
            // PanelAjustes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.btnCambiarNombre);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.btnCrearCuenta);
            this.Controls.Add(this.btnCambiarPass);
            this.Controls.Add(this.label1);
            this.Name = "PanelAjustes";
            this.Size = new System.Drawing.Size(484, 303);
            this.Load += new System.EventHandler(this.PanelAjustes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btnCambiarPass;
        private Button btnCrearCuenta;
        private Label nombre;
        private Button btnCambiarNombre;
    }
}
