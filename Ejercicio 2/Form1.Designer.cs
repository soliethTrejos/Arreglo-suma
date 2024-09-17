namespace Ejercicio_2
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
            this.label1 = new System.Windows.Forms.Label();
            this.rdoFumar = new System.Windows.Forms.RadioButton();
            this.rdoNoFumar = new System.Windows.Forms.RadioButton();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.lblBoardingPass = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SeaGreen;
            this.label1.Location = new System.Drawing.Point(38, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Por favor selecciona tu preferencia de asiento:";
            // 
            // rdoFumar
            // 
            this.rdoFumar.AutoSize = true;
            this.rdoFumar.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoFumar.ForeColor = System.Drawing.Color.SeaGreen;
            this.rdoFumar.Location = new System.Drawing.Point(50, 137);
            this.rdoFumar.Margin = new System.Windows.Forms.Padding(2);
            this.rdoFumar.Name = "rdoFumar";
            this.rdoFumar.Size = new System.Drawing.Size(71, 20);
            this.rdoFumar.TabIndex = 1;
            this.rdoFumar.TabStop = true;
            this.rdoFumar.Text = "Fumar";
            this.rdoFumar.UseVisualStyleBackColor = true;
            // 
            // rdoNoFumar
            // 
            this.rdoNoFumar.AutoSize = true;
            this.rdoNoFumar.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoNoFumar.ForeColor = System.Drawing.Color.SeaGreen;
            this.rdoNoFumar.Location = new System.Drawing.Point(239, 137);
            this.rdoNoFumar.Margin = new System.Windows.Forms.Padding(2);
            this.rdoNoFumar.Name = "rdoNoFumar";
            this.rdoNoFumar.Size = new System.Drawing.Size(94, 20);
            this.rdoNoFumar.TabIndex = 2;
            this.rdoNoFumar.TabStop = true;
            this.rdoNoFumar.Text = "No Fumar";
            this.rdoNoFumar.UseVisualStyleBackColor = true;
            // 
            // btnAsignar
            // 
            this.btnAsignar.Image = global::Ejercicio_2.Properties.Resources.asiento__1_;
            this.btnAsignar.Location = new System.Drawing.Point(121, 224);
            this.btnAsignar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(117, 76);
            this.btnAsignar.TabIndex = 3;
            this.btnAsignar.UseVisualStyleBackColor = true;
            this.btnAsignar.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblBoardingPass
            // 
            this.lblBoardingPass.AutoSize = true;
            this.lblBoardingPass.Location = new System.Drawing.Point(38, 166);
            this.lblBoardingPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBoardingPass.Name = "lblBoardingPass";
            this.lblBoardingPass.Size = new System.Drawing.Size(0, 13);
            this.lblBoardingPass.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Image = global::Ejercicio_2.Properties.Resources.de_fumar__3_;
            this.button1.Location = new System.Drawing.Point(41, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 77);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Image = global::Ejercicio_2.Properties.Resources.no_fumar__1_;
            this.button2.Location = new System.Drawing.Point(239, 38);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 77);
            this.button2.TabIndex = 6;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 389);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblBoardingPass);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.rdoNoFumar);
            this.Controls.Add(this.rdoFumar);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "fumador ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdoFumar;
        private System.Windows.Forms.RadioButton rdoNoFumar;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.Label lblBoardingPass;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}