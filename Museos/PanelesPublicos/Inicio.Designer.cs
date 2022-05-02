namespace Museos.PanelesPublicos
{
    partial class Inicio
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
            this.textoBienvenidoA = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textoBienvenidoA
            // 
            this.textoBienvenidoA.AutoSize = true;
            this.textoBienvenidoA.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textoBienvenidoA.Location = new System.Drawing.Point(21, 21);
            this.textoBienvenidoA.Name = "textoBienvenidoA";
            this.textoBienvenidoA.Size = new System.Drawing.Size(385, 72);
            this.textoBienvenidoA.TabIndex = 0;
            this.textoBienvenidoA.Text = "Bienvenido/a a";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textoBienvenidoA);
            this.Name = "Inicio";
            this.Size = new System.Drawing.Size(885, 581);
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label textoBienvenidoA;
    }
}
