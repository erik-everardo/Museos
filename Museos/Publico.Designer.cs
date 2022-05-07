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
            this.botonMuseo = new System.Windows.Forms.Button();
            this.botonObras = new System.Windows.Forms.Button();
            this.botonBoleto = new System.Windows.Forms.Button();
            this.tabla = new System.Windows.Forms.TableLayoutPanel();
            this.button5 = new System.Windows.Forms.Button();
            this.titulo = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabla.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanel1.Controls.Add(this.botonMuseo);
            this.flowLayoutPanel1.Controls.Add(this.botonObras);
            this.flowLayoutPanel1.Controls.Add(this.botonBoleto);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 383);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(863, 51);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // botonMuseo
            // 
            this.botonMuseo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.botonMuseo.Location = new System.Drawing.Point(13, 3);
            this.botonMuseo.Name = "botonMuseo";
            this.botonMuseo.Size = new System.Drawing.Size(82, 45);
            this.botonMuseo.TabIndex = 1;
            this.botonMuseo.Text = "Museo";
            this.botonMuseo.UseVisualStyleBackColor = true;
            this.botonMuseo.Click += new System.EventHandler(this.botonMuseo_Click);
            // 
            // botonObras
            // 
            this.botonObras.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.botonObras.Location = new System.Drawing.Point(101, 3);
            this.botonObras.Name = "botonObras";
            this.botonObras.Size = new System.Drawing.Size(75, 45);
            this.botonObras.TabIndex = 2;
            this.botonObras.Text = "Obras";
            this.botonObras.UseVisualStyleBackColor = true;
            this.botonObras.Click += new System.EventHandler(this.botonObras_Click);
            // 
            // botonBoleto
            // 
            this.botonBoleto.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.botonBoleto.Location = new System.Drawing.Point(182, 3);
            this.botonBoleto.Name = "botonBoleto";
            this.botonBoleto.Size = new System.Drawing.Size(75, 45);
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
            this.tabla.Location = new System.Drawing.Point(2, 45);
            this.tabla.Margin = new System.Windows.Forms.Padding(0);
            this.tabla.Name = "tabla";
            this.tabla.RowCount = 2;
            this.tabla.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tabla.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tabla.Size = new System.Drawing.Size(863, 434);
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
            // titulo
            // 
            this.titulo.AutoEllipsis = true;
            this.titulo.AutoSize = true;
            this.titulo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titulo.Location = new System.Drawing.Point(12, 12);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(62, 28);
            this.titulo.TabIndex = 3;
            this.titulo.Text = "Titulo";
            // 
            // Publico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(874, 479);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.tabla);
            this.Controls.Add(this.button5);
            this.Name = "Publico";
            this.Text = "Publico";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Publico_FormClosing);
            this.Load += new System.EventHandler(this.Publico_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tabla.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button botonMuseo;
        private Button botonObras;
        private Button botonBoleto;
        private TableLayoutPanel tabla;
        private Button button5;
        private Label titulo;
    }
}