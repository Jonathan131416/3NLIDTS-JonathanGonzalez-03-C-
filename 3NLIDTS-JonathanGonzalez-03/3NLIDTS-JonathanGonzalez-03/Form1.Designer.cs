namespace _3NLIDTS_JonathanGonzalez_03
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbCe = new System.Windows.Forms.TextBox();
            this.tbFa = new System.Windows.Forms.TextBox();
            this.btnFC = new System.Windows.Forms.Button();
            this.btnCF = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbCe
            // 
            this.tbCe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCe.Location = new System.Drawing.Point(536, 112);
            this.tbCe.Name = "tbCe";
            this.tbCe.Size = new System.Drawing.Size(158, 28);
            this.tbCe.TabIndex = 0;
            this.tbCe.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbFa
            // 
            this.tbFa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFa.Location = new System.Drawing.Point(132, 112);
            this.tbFa.Name = "tbFa";
            this.tbFa.Size = new System.Drawing.Size(167, 28);
            this.tbFa.TabIndex = 1;
            // 
            // btnFC
            // 
            this.btnFC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFC.Location = new System.Drawing.Point(351, 99);
            this.btnFC.Name = "btnFC";
            this.btnFC.Size = new System.Drawing.Size(131, 48);
            this.btnFC.TabIndex = 2;
            this.btnFC.Text = "F to C ->";
            this.btnFC.UseVisualStyleBackColor = true;
            this.btnFC.Click += new System.EventHandler(this.btnFC_Click);
            // 
            // btnCF
            // 
            this.btnCF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCF.Location = new System.Drawing.Point(351, 195);
            this.btnCF.Name = "btnCF";
            this.btnCF.Size = new System.Drawing.Size(131, 48);
            this.btnCF.TabIndex = 3;
            this.btnCF.Text = "<- C to F ";
            this.btnCF.UseVisualStyleBackColor = true;
            this.btnCF.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(351, 286);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(131, 48);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCF);
            this.Controls.Add(this.btnFC);
            this.Controls.Add(this.tbFa);
            this.Controls.Add(this.tbCe);
            this.Name = "Form1";
            this.Text = "COVERSION FAHRENHEIT/CELCIUS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCe;
        private System.Windows.Forms.TextBox tbFa;
        private System.Windows.Forms.Button btnFC;
        private System.Windows.Forms.Button btnCF;
        private System.Windows.Forms.Button btnClear;
    }
}

