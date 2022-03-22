namespace Museos
{
    partial class Administrador
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.botonMuseo = new System.Windows.Forms.Button();
            this.botonObras = new System.Windows.Forms.Button();
            this.botonOpiniones = new System.Windows.Forms.Button();
            this.botonAjustes = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(814, 476);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanel1.Controls.Add(this.botonMuseo);
            this.flowLayoutPanel1.Controls.Add(this.botonObras);
            this.flowLayoutPanel1.Controls.Add(this.botonOpiniones);
            this.flowLayoutPanel1.Controls.Add(this.botonAjustes);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(208, 470);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // botonMuseo
            // 
            this.botonMuseo.AutoSize = true;
            this.botonMuseo.Location = new System.Drawing.Point(3, 3);
            this.botonMuseo.Name = "botonMuseo";
            this.botonMuseo.Size = new System.Drawing.Size(200, 40);
            this.botonMuseo.TabIndex = 0;
            this.botonMuseo.Text = "Museo";
            this.botonMuseo.UseVisualStyleBackColor = true;
            this.botonMuseo.Click += new System.EventHandler(this.botonMuseo_Click);
            // 
            // botonObras
            // 
            this.botonObras.AutoSize = true;
            this.botonObras.Location = new System.Drawing.Point(3, 49);
            this.botonObras.Name = "botonObras";
            this.botonObras.Size = new System.Drawing.Size(200, 40);
            this.botonObras.TabIndex = 1;
            this.botonObras.Text = "Obras";
            this.botonObras.UseVisualStyleBackColor = true;
            this.botonObras.Click += new System.EventHandler(this.botonObras_Click);
            // 
            // botonOpiniones
            // 
            this.botonOpiniones.AutoSize = true;
            this.botonOpiniones.Location = new System.Drawing.Point(3, 95);
            this.botonOpiniones.Name = "botonOpiniones";
            this.botonOpiniones.Size = new System.Drawing.Size(200, 40);
            this.botonOpiniones.TabIndex = 2;
            this.botonOpiniones.Text = "Opiniones";
            this.botonOpiniones.UseVisualStyleBackColor = true;
            this.botonOpiniones.Click += new System.EventHandler(this.botonOpiniones_Click);
            // 
            // botonAjustes
            // 
            this.botonAjustes.AutoSize = true;
            this.botonAjustes.Location = new System.Drawing.Point(3, 141);
            this.botonAjustes.Name = "botonAjustes";
            this.botonAjustes.Size = new System.Drawing.Size(200, 40);
            this.botonAjustes.TabIndex = 3;
            this.botonAjustes.Text = "Ajustes";
            this.botonAjustes.UseVisualStyleBackColor = true;
            this.botonAjustes.Click += new System.EventHandler(this.botonAjustes_Click);
            // 
            // Administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 500);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(854, 539);
            this.Name = "Administrador";
            this.Text = "Administrador";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Administrador_FormClosing);
            this.Load += new System.EventHandler(this.Administrador_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button botonMuseo;
        private Button botonObras;
        private Button botonOpiniones;
        private Button botonAjustes;
    }
}