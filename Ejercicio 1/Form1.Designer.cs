namespace Ejercicio_1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox lstConteo;
        private System.Windows.Forms.Button btnLanzar;
        private System.Windows.Forms.Label lblDado;
        private System.Windows.Forms.Label lblDado2;
        private System.Windows.Forms.Label lblSuma;

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
            this.lstConteo = new System.Windows.Forms.ListBox();
            this.btnLanzar = new System.Windows.Forms.Button();
            this.lblDado = new System.Windows.Forms.Label();
            this.lblDado2 = new System.Windows.Forms.Label();
            this.lblSuma = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstConteo
            // 
            this.lstConteo.FormattingEnabled = true;
            this.lstConteo.Location = new System.Drawing.Point(12, 202);
            this.lstConteo.Name = "lstConteo";
            this.lstConteo.Size = new System.Drawing.Size(208, 173);
            this.lstConteo.TabIndex = 1;
            // 
            // btnLanzar
            // 
            this.btnLanzar.Image = global::Ejercicio_1.Properties.Resources.dados__1_;
            this.btnLanzar.Location = new System.Drawing.Point(57, 111);
            this.btnLanzar.Name = "btnLanzar";
            this.btnLanzar.Size = new System.Drawing.Size(63, 59);
            this.btnLanzar.TabIndex = 2;
            this.btnLanzar.UseVisualStyleBackColor = true;
            this.btnLanzar.Click += new System.EventHandler(this.btnLanzarDados_Click);
            // 
            // lblDado
            // 
            this.lblDado.AutoSize = true;
            this.lblDado.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDado.Location = new System.Drawing.Point(27, 9);
            this.lblDado.Name = "lblDado";
            this.lblDado.Size = new System.Drawing.Size(64, 16);
            this.lblDado.TabIndex = 3;
            this.lblDado.Text = "Dado 1: ";
            // 
            // lblDado2
            // 
            this.lblDado2.AutoSize = true;
            this.lblDado2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDado2.Location = new System.Drawing.Point(27, 43);
            this.lblDado2.Name = "lblDado2";
            this.lblDado2.Size = new System.Drawing.Size(64, 16);
            this.lblDado2.TabIndex = 4;
            this.lblDado2.Text = "Dado 2: ";
            // 
            // lblSuma
            // 
            this.lblSuma.AutoSize = true;
            this.lblSuma.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuma.Location = new System.Drawing.Point(12, 183);
            this.lblSuma.Name = "lblSuma";
            this.lblSuma.Size = new System.Drawing.Size(88, 16);
            this.lblSuma.TabIndex = 5;
            this.lblSuma.Text = "Resultado: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Lanzar";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(369, 399);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSuma);
            this.Controls.Add(this.lblDado2);
            this.Controls.Add(this.lblDado);
            this.Controls.Add(this.btnLanzar);
            this.Controls.Add(this.lstConteo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Dados";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label1;
    }
}