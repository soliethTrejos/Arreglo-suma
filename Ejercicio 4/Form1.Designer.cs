namespace Ejercicio_4
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtVentas = new System.Windows.Forms.TextBox();
            this.lstReporte = new System.Windows.Forms.ListBox();
            this.lblVentas = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMostrarReporte = new System.Windows.Forms.Button();
            this.btnAgregarVenta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtVentas
            // 
            this.txtVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVentas.ForeColor = System.Drawing.Color.Teal;
            this.txtVentas.Location = new System.Drawing.Point(174, 23);
            this.txtVentas.Name = "txtVentas";
            this.txtVentas.Size = new System.Drawing.Size(100, 29);
            this.txtVentas.TabIndex = 4;
            // 
            // lstReporte
            // 
            this.lstReporte.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstReporte.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lstReporte.FormattingEnabled = true;
            this.lstReporte.Location = new System.Drawing.Point(33, 244);
            this.lstReporte.Name = "lstReporte";
            this.lstReporte.Size = new System.Drawing.Size(279, 134);
            this.lstReporte.TabIndex = 0;
            // 
            // lblVentas
            // 
            this.lblVentas.AutoSize = true;
            this.lblVentas.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentas.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblVentas.Location = new System.Drawing.Point(30, 30);
            this.lblVentas.Name = "lblVentas";
            this.lblVentas.Size = new System.Drawing.Size(138, 18);
            this.lblVentas.TabIndex = 3;
            this.lblVentas.Text = "Ventas Brutas:";
            this.lblVentas.Click += new System.EventHandler(this.lblVentas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label1.Location = new System.Drawing.Point(31, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Agregar Venta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label2.Location = new System.Drawing.Point(210, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mostrar Reporte";
            // 
            // btnMostrarReporte
            // 
            this.btnMostrarReporte.Image = global::Ejercicio_4.Properties.Resources.archivo;
            this.btnMostrarReporte.Location = new System.Drawing.Point(237, 125);
            this.btnMostrarReporte.Name = "btnMostrarReporte";
            this.btnMostrarReporte.Size = new System.Drawing.Size(75, 81);
            this.btnMostrarReporte.TabIndex = 1;
            this.btnMostrarReporte.UseVisualStyleBackColor = true;
            this.btnMostrarReporte.Click += new System.EventHandler(this.btnMostrarReporte_Click);
            // 
            // btnAgregarVenta
            // 
            this.btnAgregarVenta.Image = global::Ejercicio_4.Properties.Resources.plus_insert_add_new_icon_181537;
            this.btnAgregarVenta.Location = new System.Drawing.Point(54, 125);
            this.btnAgregarVenta.Name = "btnAgregarVenta";
            this.btnAgregarVenta.Size = new System.Drawing.Size(72, 81);
            this.btnAgregarVenta.TabIndex = 2;
            this.btnAgregarVenta.UseVisualStyleBackColor = true;
            this.btnAgregarVenta.Click += new System.EventHandler(this.btnAgregarVenta_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(412, 451);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstReporte);
            this.Controls.Add(this.btnMostrarReporte);
            this.Controls.Add(this.btnAgregarVenta);
            this.Controls.Add(this.lblVentas);
            this.Controls.Add(this.txtVentas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Salarios Vendedores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox txtVentas;
        private System.Windows.Forms.Button btnAgregarVenta;
        private System.Windows.Forms.Button btnMostrarReporte;
        private System.Windows.Forms.ListBox lstReporte;
        private System.Windows.Forms.Label lblVentas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}