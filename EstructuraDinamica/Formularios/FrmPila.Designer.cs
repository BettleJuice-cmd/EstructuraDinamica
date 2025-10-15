namespace EstructuraDinamica.Formularios
{
    partial class FrmPila
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbNumero = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblPila = new System.Windows.Forms.Label();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero:";
            // 
            // tbNumero
            // 
            this.tbNumero.Location = new System.Drawing.Point(150, 82);
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.Size = new System.Drawing.Size(100, 22);
            this.tbNumero.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(288, 82);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(101, 23);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblPila
            // 
            this.lblPila.AutoSize = true;
            this.lblPila.Location = new System.Drawing.Point(53, 176);
            this.lblPila.Name = "lblPila";
            this.lblPila.Size = new System.Drawing.Size(66, 16);
            this.lblPila.TabIndex = 3;
            this.lblPila.Text = "Pila vacía";
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(288, 133);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(101, 23);
            this.btnQuitar.TabIndex = 4;
            this.btnQuitar.Text = "QUITAR";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(288, 176);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(101, 42);
            this.btnMostrar.TabIndex = 5;
            this.btnMostrar.Text = "MOSTRAR ULTIMO";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // FrmPila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.lblPila);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.tbNumero);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPila";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pila Enteros";
            this.Load += new System.EventHandler(this.FrmPila_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNumero;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblPila;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnMostrar;
    }
}