namespace Museos.PanelesPublicos
{
    partial class Obras
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
            this.listaDeObras = new System.Windows.Forms.FlowLayoutPanel();
            this.fotografia = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.nombre = new System.Windows.Forms.Label();
            this.detalles = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.fotografia)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listaDeObras
            // 
            this.listaDeObras.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listaDeObras.AutoScroll = true;
            this.listaDeObras.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.listaDeObras.Location = new System.Drawing.Point(3, 3);
            this.listaDeObras.Name = "listaDeObras";
            this.listaDeObras.Size = new System.Drawing.Size(233, 407);
            this.listaDeObras.TabIndex = 4;
            // 
            // fotografia
            // 
            this.fotografia.Location = new System.Drawing.Point(3, 3);
            this.fotografia.Name = "fotografia";
            this.fotografia.Size = new System.Drawing.Size(576, 91);
            this.fotografia.TabIndex = 5;
            this.fotografia.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.fotografia);
            this.flowLayoutPanel1.Controls.Add(this.nombre);
            this.flowLayoutPanel1.Controls.Add(this.detalles);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(242, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(589, 407);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nombre.Location = new System.Drawing.Point(3, 97);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(105, 45);
            this.nombre.TabIndex = 6;
            this.nombre.Text = "label1";
            // 
            // detalles
            // 
            this.detalles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.detalles.BackColor = System.Drawing.SystemColors.Window;
            this.detalles.Location = new System.Drawing.Point(3, 145);
            this.detalles.Name = "detalles";
            this.detalles.ReadOnly = true;
            this.detalles.Size = new System.Drawing.Size(576, 96);
            this.detalles.TabIndex = 7;
            this.detalles.Text = "";
            // 
            // Obras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.listaDeObras);
            this.Name = "Obras";
            this.Size = new System.Drawing.Size(834, 413);
            this.Load += new System.EventHandler(this.Obras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fotografia)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel listaDeObras;
        private PictureBox fotografia;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label nombre;
        private RichTextBox detalles;
    }
}
