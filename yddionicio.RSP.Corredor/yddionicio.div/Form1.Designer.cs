namespace yddionicio.div
{
    partial class frmRsp
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
            this.btnCorrer = new System.Windows.Forms.Button();
            this.pgbCarril1 = new System.Windows.Forms.ProgressBar();
            this.lblCarril1 = new System.Windows.Forms.Label();
            this.lblCarril2 = new System.Windows.Forms.Label();
            this.pgbCarril2 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // btnCorrer
            // 
            this.btnCorrer.Location = new System.Drawing.Point(517, 234);
            this.btnCorrer.Name = "btnCorrer";
            this.btnCorrer.Size = new System.Drawing.Size(139, 51);
            this.btnCorrer.TabIndex = 0;
            this.btnCorrer.Text = "Correr";
            this.btnCorrer.UseVisualStyleBackColor = true;
            this.btnCorrer.Click += new System.EventHandler(this.btnCorrer_Click);
            // 
            // pgbCarril1
            // 
            this.pgbCarril1.Location = new System.Drawing.Point(155, 120);
            this.pgbCarril1.Name = "pgbCarril1";
            this.pgbCarril1.Size = new System.Drawing.Size(501, 25);
            this.pgbCarril1.TabIndex = 1;
            // 
            // lblCarril1
            // 
            this.lblCarril1.AutoSize = true;
            this.lblCarril1.Location = new System.Drawing.Point(65, 120);
            this.lblCarril1.Name = "lblCarril1";
            this.lblCarril1.Size = new System.Drawing.Size(58, 20);
            this.lblCarril1.TabIndex = 2;
            this.lblCarril1.Text = "Carril 1";
            // 
            // lblCarril2
            // 
            this.lblCarril2.AutoSize = true;
            this.lblCarril2.Location = new System.Drawing.Point(65, 163);
            this.lblCarril2.Name = "lblCarril2";
            this.lblCarril2.Size = new System.Drawing.Size(58, 20);
            this.lblCarril2.TabIndex = 2;
            this.lblCarril2.Text = "Carril 2";
            // 
            // pgbCarril2
            // 
            this.pgbCarril2.Location = new System.Drawing.Point(155, 160);
            this.pgbCarril2.Name = "pgbCarril2";
            this.pgbCarril2.Size = new System.Drawing.Size(501, 25);
            this.pgbCarril2.TabIndex = 1;
            // 
            // frmRsp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 307);
            this.Controls.Add(this.lblCarril2);
            this.Controls.Add(this.lblCarril1);
            this.Controls.Add(this.pgbCarril2);
            this.Controls.Add(this.pgbCarril1);
            this.Controls.Add(this.btnCorrer);
            this.Name = "frmRsp";
            this.Text = "RSP";
            this.Load += new System.EventHandler(this.frmRsp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCorrer;
        private System.Windows.Forms.ProgressBar pgbCarril1;
        private System.Windows.Forms.Label lblCarril1;
        private System.Windows.Forms.Label lblCarril2;
        private System.Windows.Forms.ProgressBar pgbCarril2;
    }
}

