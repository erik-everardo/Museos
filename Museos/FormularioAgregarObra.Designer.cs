namespace Museos
{
    partial class FormularioAgregarObra
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
            this.label2 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.descripcion = new System.Windows.Forms.RichTextBox();
            this.vistaPrevia = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.botonAgregarObra = new System.Windows.Forms.Button();
            this.dialogoSeleccionarImagen = new System.Windows.Forms.OpenFileDialog();
            this.fechaIncorporacion = new System.Windows.Forms.DateTimePicker();
            this.Fecha = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vistaPrevia)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nueva obra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // nombre
            // 
            this.nombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nombre.Location = new System.Drawing.Point(12, 64);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(355, 23);
            this.nombre.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Descripción";
            // 
            // descripcion
            // 
            this.descripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descripcion.Location = new System.Drawing.Point(12, 108);
            this.descripcion.Name = "descripcion";
            this.descripcion.Size = new System.Drawing.Size(355, 96);
            this.descripcion.TabIndex = 4;
            this.descripcion.Text = "";
            // 
            // vistaPrevia
            // 
            this.vistaPrevia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.vistaPrevia.Location = new System.Drawing.Point(12, 297);
            this.vistaPrevia.Name = "vistaPrevia";
            this.vistaPrevia.Size = new System.Drawing.Size(147, 108);
            this.vistaPrevia.TabIndex = 5;
            this.vistaPrevia.TabStop = false;
            this.vistaPrevia.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fotografía";
            // 
            // botonAgregarObra
            // 
            this.botonAgregarObra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.botonAgregarObra.Location = new System.Drawing.Point(292, 388);
            this.botonAgregarObra.Name = "botonAgregarObra";
            this.botonAgregarObra.Size = new System.Drawing.Size(75, 23);
            this.botonAgregarObra.TabIndex = 7;
            this.botonAgregarObra.Text = "Agregar";
            this.botonAgregarObra.UseVisualStyleBackColor = true;
            this.botonAgregarObra.Click += new System.EventHandler(this.botonAgregarObra_Click);
            // 
            // dialogoSeleccionarImagen
            // 
            this.dialogoSeleccionarImagen.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF";
            this.dialogoSeleccionarImagen.Title = "Seleccionar imagen";
            this.dialogoSeleccionarImagen.FileOk += new System.ComponentModel.CancelEventHandler(this.dialogoSeleccionarImagen_FileOk);
            // 
            // fechaIncorporacion
            // 
            this.fechaIncorporacion.Location = new System.Drawing.Point(12, 225);
            this.fechaIncorporacion.Name = "fechaIncorporacion";
            this.fechaIncorporacion.Size = new System.Drawing.Size(355, 23);
            this.fechaIncorporacion.TabIndex = 8;
            // 
            // Fecha
            // 
            this.Fecha.AutoSize = true;
            this.Fecha.Location = new System.Drawing.Point(12, 207);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(131, 15);
            this.Fecha.TabIndex = 9;
            this.Fecha.Text = "Fecha de incorporación";
            // 
            // FormularioAgregarObra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 423);
            this.Controls.Add(this.Fecha);
            this.Controls.Add(this.fechaIncorporacion);
            this.Controls.Add(this.botonAgregarObra);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.vistaPrevia);
            this.Controls.Add(this.descripcion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormularioAgregarObra";
            this.Text = "Agregar obra";
            ((System.ComponentModel.ISupportInitialize)(this.vistaPrevia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox nombre;
        private Label label3;
        private RichTextBox descripcion;
        private PictureBox vistaPrevia;
        private Label label4;
        private Button botonAgregarObra;
        private OpenFileDialog dialogoSeleccionarImagen;
        private DateTimePicker fechaIncorporacion;
        private Label Fecha;
    }
}