namespace Museos
{
    partial class Publico
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.botonInicio = new System.Windows.Forms.Button();
            this.botonMuseo = new System.Windows.Forms.Button();
            this.botonObras = new System.Windows.Forms.Button();
            this.botonBoleto = new System.Windows.Forms.Button();
            this.tabla = new System.Windows.Forms.TableLayoutPanel();
            this.button5 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabla.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.botonInicio);
            this.flowLayoutPanel1.Controls.Add(this.botonMuseo);
            this.flowLayoutPanel1.Controls.Add(this.botonObras);
            this.flowLayoutPanel1.Controls.Add(this.botonBoleto);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 386);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(844, 33);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // botonInicio
            // 
            this.botonInicio.Location = new System.Drawing.Point(13, 3);
            this.botonInicio.Name = "botonInicio";
            this.botonInicio.Size = new System.Drawing.Size(75, 23);
            this.botonInicio.TabIndex = 0;
            this.botonInicio.Text = "Inicio";
            this.botonInicio.UseVisualStyleBackColor = true;
            this.botonInicio.Click += new System.EventHandler(this.botonInicio_Click);
            // 
            // botonMuseo
            // 
            this.botonMuseo.Location = new System.Drawing.Point(94, 3);
            this.botonMuseo.Name = "botonMuseo";
            this.botonMuseo.Size = new System.Drawing.Size(75, 23);
            this.botonMuseo.TabIndex = 1;
            this.botonMuseo.Text = "Museo";
            this.botonMuseo.UseVisualStyleBackColor = true;
            this.botonMuseo.Click += new System.EventHandler(this.botonMuseo_Click);
            // 
            // botonObras
            // 
            this.botonObras.Location = new System.Drawing.Point(175, 3);
            this.botonObras.Name = "botonObras";
            this.botonObras.Size = new System.Drawing.Size(75, 23);
            this.botonObras.TabIndex = 2;
            this.botonObras.Text = "Obras";
            this.botonObras.UseVisualStyleBackColor = true;
            this.botonObras.Click += new System.EventHandler(this.botonObras_Click);
            // 
            // botonBoleto
            // 
            this.botonBoleto.Location = new System.Drawing.Point(256, 3);
            this.botonBoleto.Name = "botonBoleto";
            this.botonBoleto.Size = new System.Drawing.Size(75, 23);
            this.botonBoleto.TabIndex = 3;
            this.botonBoleto.Text = "Boleto";
            this.botonBoleto.UseVisualStyleBackColor = true;
            this.botonBoleto.Click += new System.EventHandler(this.botonBoleto_Click);
            // 
            // tabla
            // 
            this.tabla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabla.ColumnCount = 1;
            this.tabla.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tabla.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tabla.Location = new System.Drawing.Point(12, 45);
            this.tabla.Name = "tabla";
            this.tabla.RowCount = 2;
            this.tabla.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tabla.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tabla.Size = new System.Drawing.Size(850, 422);
            this.tabla.TabIndex = 2;
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.Location = new System.Drawing.Point(748, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(114, 27);
            this.button5.TabIndex = 1;
            this.button5.Text = "Pantalla completa";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Publico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 479);
            this.Controls.Add(this.tabla);
            this.Controls.Add(this.button5);
            this.Name = "Publico";
            this.Text = "Publico";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Publico_FormClosing);
            this.Load += new System.EventHandler(this.Publico_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tabla.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button botonInicio;
        private Button botonMuseo;
        private Button botonObras;
        private Button botonBoleto;
        private TableLayoutPanel tabla;
        private Button button5;
    }
}