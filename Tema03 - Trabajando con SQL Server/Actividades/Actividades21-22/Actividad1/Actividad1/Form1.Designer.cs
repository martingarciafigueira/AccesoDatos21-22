
namespace Actividad1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnInsertarFabricante = new System.Windows.Forms.Button();
            this.btnVerBDActualizada = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFabricantes = new System.Windows.Forms.TextBox();
            this.lstFabricantes = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 61);
            this.button1.TabIndex = 0;
            this.button1.Text = "Conexión BD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(194, 70);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 61);
            this.button2.TabIndex = 1;
            this.button2.Text = "Desconexión BD";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Conexión/desconexión";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(140, 250);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 22);
            this.txtCodigo.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(140, 297);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 22);
            this.txtNombre.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Insertar valores";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Codigo";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nombre";
            // 
            // btnInsertarFabricante
            // 
            this.btnInsertarFabricante.Location = new System.Drawing.Point(246, 250);
            this.btnInsertarFabricante.Name = "btnInsertarFabricante";
            this.btnInsertarFabricante.Size = new System.Drawing.Size(142, 67);
            this.btnInsertarFabricante.TabIndex = 8;
            this.btnInsertarFabricante.Text = "Insertar fabricante";
            this.btnInsertarFabricante.UseVisualStyleBackColor = true;
            this.btnInsertarFabricante.Click += new System.EventHandler(this.btnInsertarFabricante_Click);
            // 
            // btnVerBDActualizada
            // 
            this.btnVerBDActualizada.Location = new System.Drawing.Point(28, 421);
            this.btnVerBDActualizada.Name = "btnVerBDActualizada";
            this.btnVerBDActualizada.Size = new System.Drawing.Size(142, 67);
            this.btnVerBDActualizada.TabIndex = 14;
            this.btnVerBDActualizada.Text = "Ver BD actualizada";
            this.btnVerBDActualizada.UseVisualStyleBackColor = true;
            this.btnVerBDActualizada.Click += new System.EventHandler(this.btnVerBDActualizada_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 371);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Ver valores";
            // 
            // txtFabricantes
            // 
            this.txtFabricantes.Location = new System.Drawing.Point(688, 89);
            this.txtFabricantes.Multiline = true;
            this.txtFabricantes.Name = "txtFabricantes";
            this.txtFabricantes.ReadOnly = true;
            this.txtFabricantes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtFabricantes.Size = new System.Drawing.Size(283, 327);
            this.txtFabricantes.TabIndex = 15;
            // 
            // lstFabricantes
            // 
            this.lstFabricantes.FormattingEnabled = true;
            this.lstFabricantes.ItemHeight = 16;
            this.lstFabricantes.Location = new System.Drawing.Point(413, 89);
            this.lstFabricantes.Name = "lstFabricantes";
            this.lstFabricantes.Size = new System.Drawing.Size(243, 372);
            this.lstFabricantes.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 528);
            this.Controls.Add(this.lstFabricantes);
            this.Controls.Add(this.txtFabricantes);
            this.Controls.Add(this.btnVerBDActualizada);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnInsertarFabricante);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnInsertarFabricante;
        private System.Windows.Forms.Button btnVerBDActualizada;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFabricantes;
        private System.Windows.Forms.ListBox lstFabricantes;
    }
}

