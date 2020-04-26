namespace Patron
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
            this.BTN1 = new System.Windows.Forms.Button();
            this.BTN0 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LBLPrediccion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTN1
            // 
            this.BTN1.Location = new System.Drawing.Point(12, 12);
            this.BTN1.Name = "BTN1";
            this.BTN1.Size = new System.Drawing.Size(47, 44);
            this.BTN1.TabIndex = 0;
            this.BTN1.Text = "1";
            this.BTN1.UseVisualStyleBackColor = true;
            this.BTN1.Click += new System.EventHandler(this.BTN1_Click);
            // 
            // BTN0
            // 
            this.BTN0.Location = new System.Drawing.Point(77, 12);
            this.BTN0.Name = "BTN0";
            this.BTN0.Size = new System.Drawing.Size(47, 44);
            this.BTN0.TabIndex = 1;
            this.BTN0.Text = "0";
            this.BTN0.UseVisualStyleBackColor = true;
            this.BTN0.Click += new System.EventHandler(this.BTN0_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Predicción:";
            // 
            // LBLPrediccion
            // 
            this.LBLPrediccion.AutoSize = true;
            this.LBLPrediccion.Location = new System.Drawing.Point(75, 59);
            this.LBLPrediccion.Name = "LBLPrediccion";
            this.LBLPrediccion.Size = new System.Drawing.Size(35, 13);
            this.LBLPrediccion.TabIndex = 3;
            this.LBLPrediccion.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(136, 85);
            this.Controls.Add(this.LBLPrediccion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN0);
            this.Controls.Add(this.BTN1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN1;
        private System.Windows.Forms.Button BTN0;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LBLPrediccion;
    }
}

