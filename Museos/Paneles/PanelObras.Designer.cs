namespace Museos.Paneles
{
    partial class PanelObras
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listaDeObras = new System.Windows.Forms.FlowLayoutPanel();
            this.botonAgregarObra = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.botonGuardarCambios = new System.Windows.Forms.Button();
            this.nombre = new System.Windows.Forms.TextBox();
            this.fotografia = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.detalles = new System.Windows.Forms.RichTextBox();
            this.dialogoSeleccionarImagen = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotografia)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(25, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Obras";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(25, 56);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listaDeObras);
            this.splitContainer1.Panel1.Controls.Add(this.botonAgregarObra);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(564, 360);
            this.splitContainer1.SplitterDistance = 187;
            this.splitContainer1.TabIndex = 1;
            // 
            // listaDeObras
            // 
            this.listaDeObras.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listaDeObras.AutoScroll = true;
            this.listaDeObras.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.listaDeObras.Location = new System.Drawing.Point(3, 36);
            this.listaDeObras.Name = "listaDeObras";
            this.listaDeObras.Size = new System.Drawing.Size(181, 321);
            this.listaDeObras.TabIndex = 3;
            // 
            // botonAgregarObra
            // 
            this.botonAgregarObra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.botonAgregarObra.Location = new System.Drawing.Point(109, 7);
            this.botonAgregarObra.Name = "botonAgregarObra";
            this.botonAgregarObra.Size = new System.Drawing.Size(75, 23);
            this.botonAgregarObra.TabIndex = 2;
            this.botonAgregarObra.Text = "Agregar";
            this.botonAgregarObra.UseVisualStyleBackColor = true;
            this.botonAgregarObra.Click += new System.EventHandler(this.botonAgregarObra_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.botonGuardarCambios);
            this.groupBox1.Controls.Add(this.nombre);
            this.groupBox1.Controls.Add(this.fotografia);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.detalles);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 354);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalles";
            // 
            // botonGuardarCambios
            // 
            this.botonGuardarCambios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.botonGuardarCambios.Location = new System.Drawing.Point(252, 323);
            this.botonGuardarCambios.Name = "botonGuardarCambios";
            this.botonGuardarCambios.Size = new System.Drawing.Size(112, 25);
            this.botonGuardarCambios.TabIndex = 6;
            this.botonGuardarCambios.Text = "Guardar cambios";
            this.botonGuardarCambios.UseVisualStyleBackColor = true;
            this.botonGuardarCambios.Click += new System.EventHandler(this.botonGuardarCambios_Click);
            // 
            // nombre
            // 
            this.nombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nombre.Location = new System.Drawing.Point(6, 33);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(358, 23);
            this.nombre.TabIndex = 1;
            // 
            // fotografia
            // 
            this.fotografia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fotografia.Location = new System.Drawing.Point(6, 199);
            this.fotografia.Name = "fotografia";
            this.fotografia.Size = new System.Drawing.Size(205, 109);
            this.fotografia.TabIndex = 4;
            this.fotografia.TabStop = false;
            this.fotografia.Click += new System.EventHandler(this.fotografia_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Foto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Detalles";
            // 
            // detalles
            // 
            this.detalles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.detalles.Location = new System.Drawing.Point(6, 82);
            this.detalles.Name = "detalles";
            this.detalles.Size = new System.Drawing.Size(358, 96);
            this.detalles.TabIndex = 3;
            this.detalles.Text = "";
            // 
            // dialogoSeleccionarImagen
            // 
            this.dialogoSeleccionarImagen.FileName = "openFileDialog1";
            this.dialogoSeleccionarImagen.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF";
            this.dialogoSeleccionarImagen.Title = "Seleccionar imagen";
            this.dialogoSeleccionarImagen.FileOk += new System.ComponentModel.CancelEventHandler(this.dialogoSeleccionarImagen_FileOk);
            // 
            // PanelObras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.label1);
            this.Name = "PanelObras";
            this.Size = new System.Drawing.Size(592, 419);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotografia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private SplitContainer splitContainer1;
        private Label label3;
        private TextBox nombre;
        private Label label2;
        private RichTextBox detalles;
        private OpenFileDialog dialogoSeleccionarImagen;
        private Label label4;
        private PictureBox fotografia;
        private Button botonAgregarObra;
        private GroupBox groupBox1;
        private Button botonGuardarCambios;
        private FlowLayoutPanel listaDeObras;
    }
}
