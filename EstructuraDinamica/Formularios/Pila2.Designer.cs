namespace EstructuraDinamica.Formularios
{
    partial class Pila2
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNombres = new System.Windows.Forms.TextBox();
            this.tbApellidos = new System.Windows.Forms.TextBox();
            this.tbPromedio = new System.Windows.Forms.TextBox();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbPromedios = new System.Windows.Forms.ListBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.gbDatos.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombres:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellidos";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Promedio";
            // 
            // tbNombres
            // 
            this.tbNombres.Location = new System.Drawing.Point(172, 43);
            this.tbNombres.Name = "tbNombres";
            this.tbNombres.Size = new System.Drawing.Size(195, 22);
            this.tbNombres.TabIndex = 3;
            // 
            // tbApellidos
            // 
            this.tbApellidos.Location = new System.Drawing.Point(172, 109);
            this.tbApellidos.Name = "tbApellidos";
            this.tbApellidos.Size = new System.Drawing.Size(195, 22);
            this.tbApellidos.TabIndex = 4;
            // 
            // tbPromedio
            // 
            this.tbPromedio.Location = new System.Drawing.Point(172, 188);
            this.tbPromedio.Name = "tbPromedio";
            this.tbPromedio.Size = new System.Drawing.Size(100, 22);
            this.tbPromedio.TabIndex = 5;
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.btnAgregar);
            this.gbDatos.Location = new System.Drawing.Point(483, 43);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(200, 184);
            this.gbDatos.TabIndex = 6;
            this.gbDatos.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbPromedios);
            this.groupBox1.Location = new System.Drawing.Point(81, 285);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(135, 153);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Promedios";
            // 
            // lbPromedios
            // 
            this.lbPromedios.FormattingEnabled = true;
            this.lbPromedios.ItemHeight = 16;
            this.lbPromedios.Location = new System.Drawing.Point(6, 21);
            this.lbPromedios.Name = "lbPromedios";
            this.lbPromedios.Size = new System.Drawing.Size(120, 132);
            this.lbPromedios.TabIndex = 0;
            this.lbPromedios.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(56, 31);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // Pila2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbDatos);
            this.Controls.Add(this.tbPromedio);
            this.Controls.Add(this.tbApellidos);
            this.Controls.Add(this.tbNombres);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Pila2";
            this.Text = "Becas";
            this.gbDatos.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNombres;
        private System.Windows.Forms.TextBox tbApellidos;
        private System.Windows.Forms.TextBox tbPromedio;
        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbPromedios;
        private System.Windows.Forms.Button btnAgregar;
    }
}