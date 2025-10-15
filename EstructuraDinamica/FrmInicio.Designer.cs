namespace EstructuraDinamica
{
    partial class FrmInicio
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
            this.btnPila = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPila
            // 
            this.btnPila.Location = new System.Drawing.Point(83, 80);
            this.btnPila.Name = "btnPila";
            this.btnPila.Size = new System.Drawing.Size(124, 40);
            this.btnPila.TabIndex = 0;
            this.btnPila.Text = "Pila";
            this.btnPila.UseVisualStyleBackColor = true;
            this.btnPila.Click += new System.EventHandler(this.btnPila_Click);
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPila);
            this.Name = "FrmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estructuras Dinamicas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPila;
    }
}

