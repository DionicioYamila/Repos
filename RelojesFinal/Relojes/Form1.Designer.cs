namespace Relojes
{
    partial class frmRelojes
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
            this.btnIniciar1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIniciar2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnIniciar3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnIniciar1
            // 
            this.btnIniciar1.Location = new System.Drawing.Point(77, 70);
            this.btnIniciar1.Name = "btnIniciar1";
            this.btnIniciar1.Size = new System.Drawing.Size(111, 41);
            this.btnIniciar1.TabIndex = 0;
            this.btnIniciar1.Text = "Contador 1";
            this.btnIniciar1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // btnIniciar2
            // 
            this.btnIniciar2.Location = new System.Drawing.Point(77, 145);
            this.btnIniciar2.Name = "btnIniciar2";
            this.btnIniciar2.Size = new System.Drawing.Size(111, 41);
            this.btnIniciar2.TabIndex = 0;
            this.btnIniciar2.Text = "Contador 2";
            this.btnIniciar2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label1";
            // 
            // btnIniciar3
            // 
            this.btnIniciar3.Location = new System.Drawing.Point(77, 229);
            this.btnIniciar3.Name = "btnIniciar3";
            this.btnIniciar3.Size = new System.Drawing.Size(111, 41);
            this.btnIniciar3.TabIndex = 0;
            this.btnIniciar3.Text = "Contador 3";
            this.btnIniciar3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "label1";
            // 
            // frmRelojes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 335);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIniciar3);
            this.Controls.Add(this.btnIniciar2);
            this.Controls.Add(this.btnIniciar1);
            this.Name = "frmRelojes";
            this.Text = "yddionicioRelojes";
            this.Load += new System.EventHandler(this.frmRelojes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIniciar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIniciar2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnIniciar3;
        private System.Windows.Forms.Label label3;
    }
}

