namespace Museos.PanelesPublicos
{
    partial class Museo
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
            this.nombreMuseo = new System.Windows.Forms.Label();
            this.detalles = new System.Windows.Forms.RichTextBox();
            this.fundado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nombreMuseo
            // 
            this.nombreMuseo.AutoSize = true;
            this.nombreMuseo.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nombreMuseo.Location = new System.Drawing.Point(14, 12);
            this.nombreMuseo.Name = "nombreMuseo";
            this.nombreMuseo.Size = new System.Drawing.Size(138, 45);
            this.nombreMuseo.TabIndex = 0;
            this.nombreMuseo.Text = "Nombre";
            // 
            // detalles
            // 
            this.detalles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.detalles.BackColor = System.Drawing.SystemColors.Control;
            this.detalles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.detalles.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.detalles.Location = new System.Drawing.Point(14, 75);
            this.detalles.Name = "detalles";
            this.detalles.ReadOnly = true;
            this.detalles.Size = new System.Drawing.Size(402, 219);
            this.detalles.TabIndex = 1;
            this.detalles.Text = "";
            // 
            // fundado
            // 
            this.fundado.AutoSize = true;
            this.fundado.Location = new System.Drawing.Point(26, 57);
            this.fundado.Name = "fundado";
            this.fundado.Size = new System.Drawing.Size(0, 15);
            this.fundado.TabIndex = 2;
            // 
            // Museo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.fundado);
            this.Controls.Add(this.detalles);
            this.Controls.Add(this.nombreMuseo);
            this.Name = "Museo";
            this.Size = new System.Drawing.Size(431, 308);
            this.Load += new System.EventHandler(this.Museo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label nombreMuseo;
        private RichTextBox detalles;
        private Label fundado;
    }
}
