
namespace Actividad7
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
            this.btnEstablecerConexion = new System.Windows.Forms.Button();
            this.lstProductos = new System.Windows.Forms.ListBox();
            this.lstFabricantes = new System.Windows.Forms.ListBox();
            this.btnMostrarProductosFabricantes = new System.Windows.Forms.Button();
            this.btnInsertarFabricante = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreFabricante = new System.Windows.Forms.TextBox();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnInsertarProducto = new System.Windows.Forms.Button();
            this.txtPrecioProducto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBorrarProductos = new System.Windows.Forms.Button();
            this.btnBorrarFabricantes = new System.Windows.Forms.Button();
            this.btnActualizarFabricante = new System.Windows.Forms.Button();
            this.btnActualizarProducto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEstablecerConexion
            // 
            this.btnEstablecerConexion.Location = new System.Drawing.Point(12, 12);
            this.btnEstablecerConexion.Name = "btnEstablecerConexion";
            this.btnEstablecerConexion.Size = new System.Drawing.Size(124, 66);
            this.btnEstablecerConexion.TabIndex = 0;
            this.btnEstablecerConexion.Text = "Establecer conexión";
            this.btnEstablecerConexion.UseVisualStyleBackColor = true;
            this.btnEstablecerConexion.Click += new System.EventHandler(this.btnEstablecerConexion_Click);
            // 
            // lstProductos
            // 
            this.lstProductos.FormattingEnabled = true;
            this.lstProductos.ItemHeight = 16;
            this.lstProductos.Location = new System.Drawing.Point(218, 12);
            this.lstProductos.Name = "lstProductos";
            this.lstProductos.Size = new System.Drawing.Size(247, 228);
            this.lstProductos.TabIndex = 1;
            this.lstProductos.DoubleClick += new System.EventHandler(this.lstProductos_DoubleClick);
            // 
            // lstFabricantes
            // 
            this.lstFabricantes.FormattingEnabled = true;
            this.lstFabricantes.ItemHeight = 16;
            this.lstFabricantes.Location = new System.Drawing.Point(496, 12);
            this.lstFabricantes.Name = "lstFabricantes";
            this.lstFabricantes.ScrollAlwaysVisible = true;
            this.lstFabricantes.Size = new System.Drawing.Size(283, 228);
            this.lstFabricantes.TabIndex = 2;
            this.lstFabricantes.DoubleClick += new System.EventHandler(this.lstFabricantes_DoubleClick);
            // 
            // btnMostrarProductosFabricantes
            // 
            this.btnMostrarProductosFabricantes.Location = new System.Drawing.Point(12, 123);
            this.btnMostrarProductosFabricantes.Name = "btnMostrarProductosFabricantes";
            this.btnMostrarProductosFabricantes.Size = new System.Drawing.Size(124, 66);
            this.btnMostrarProductosFabricantes.TabIndex = 3;
            this.btnMostrarProductosFabricantes.Text = "Mostrar productos y fabricantes";
            this.btnMostrarProductosFabricantes.UseVisualStyleBackColor = true;
            this.btnMostrarProductosFabricantes.Click += new System.EventHandler(this.btnMostrarProductosFabricantes_Click);
            // 
            // btnInsertarFabricante
            // 
            this.btnInsertarFabricante.Location = new System.Drawing.Point(870, 86);
            this.btnInsertarFabricante.Name = "btnInsertarFabricante";
            this.btnInsertarFabricante.Size = new System.Drawing.Size(87, 52);
            this.btnInsertarFabricante.TabIndex = 4;
            this.btnInsertarFabricante.Text = "Insertar fabricante";
            this.btnInsertarFabricante.UseVisualStyleBackColor = true;
            this.btnInsertarFabricante.Click += new System.EventHandler(this.btnInsertarFabricante_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(867, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre fabricante";
            // 
            // txtNombreFabricante
            // 
            this.txtNombreFabricante.Location = new System.Drawing.Point(998, 43);
            this.txtNombreFabricante.Name = "txtNombreFabricante";
            this.txtNombreFabricante.Size = new System.Drawing.Size(100, 22);
            this.txtNombreFabricante.TabIndex = 6;
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(998, 193);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(100, 22);
            this.txtNombreProducto.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(867, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nombre producto";
            // 
            // btnInsertarProducto
            // 
            this.btnInsertarProducto.Location = new System.Drawing.Point(870, 277);
            this.btnInsertarProducto.Name = "btnInsertarProducto";
            this.btnInsertarProducto.Size = new System.Drawing.Size(87, 52);
            this.btnInsertarProducto.TabIndex = 7;
            this.btnInsertarProducto.Text = "Insertar producto";
            this.btnInsertarProducto.UseVisualStyleBackColor = true;
            this.btnInsertarProducto.Click += new System.EventHandler(this.btnInsertarProducto_Click);
            // 
            // txtPrecioProducto
            // 
            this.txtPrecioProducto.Location = new System.Drawing.Point(998, 229);
            this.txtPrecioProducto.Name = "txtPrecioProducto";
            this.txtPrecioProducto.Size = new System.Drawing.Size(100, 22);
            this.txtPrecioProducto.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(867, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Precio producto";
            // 
            // btnBorrarProductos
            // 
            this.btnBorrarProductos.Location = new System.Drawing.Point(302, 262);
            this.btnBorrarProductos.Name = "btnBorrarProductos";
            this.btnBorrarProductos.Size = new System.Drawing.Size(75, 23);
            this.btnBorrarProductos.TabIndex = 12;
            this.btnBorrarProductos.Text = "Borrar";
            this.btnBorrarProductos.UseVisualStyleBackColor = true;
            this.btnBorrarProductos.Click += new System.EventHandler(this.btnBorrarProductos_Click);
            // 
            // btnBorrarFabricantes
            // 
            this.btnBorrarFabricantes.Location = new System.Drawing.Point(602, 262);
            this.btnBorrarFabricantes.Name = "btnBorrarFabricantes";
            this.btnBorrarFabricantes.Size = new System.Drawing.Size(75, 23);
            this.btnBorrarFabricantes.TabIndex = 13;
            this.btnBorrarFabricantes.Text = "Borrar";
            this.btnBorrarFabricantes.UseVisualStyleBackColor = true;
            this.btnBorrarFabricantes.Click += new System.EventHandler(this.btnBorrarFabricantes_Click);
            // 
            // btnActualizarFabricante
            // 
            this.btnActualizarFabricante.Location = new System.Drawing.Point(1011, 86);
            this.btnActualizarFabricante.Name = "btnActualizarFabricante";
            this.btnActualizarFabricante.Size = new System.Drawing.Size(87, 52);
            this.btnActualizarFabricante.TabIndex = 14;
            this.btnActualizarFabricante.Text = "Actualizar fabricante";
            this.btnActualizarFabricante.UseVisualStyleBackColor = true;
            this.btnActualizarFabricante.Click += new System.EventHandler(this.btnActualizarFabricante_Click);
            // 
            // btnActualizarProducto
            // 
            this.btnActualizarProducto.Location = new System.Drawing.Point(1011, 277);
            this.btnActualizarProducto.Name = "btnActualizarProducto";
            this.btnActualizarProducto.Size = new System.Drawing.Size(87, 52);
            this.btnActualizarProducto.TabIndex = 15;
            this.btnActualizarProducto.Text = "Actualizar producto";
            this.btnActualizarProducto.UseVisualStyleBackColor = true;
            this.btnActualizarProducto.Click += new System.EventHandler(this.btnActualizarProducto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 613);
            this.Controls.Add(this.btnActualizarProducto);
            this.Controls.Add(this.btnActualizarFabricante);
            this.Controls.Add(this.btnBorrarFabricantes);
            this.Controls.Add(this.btnBorrarProductos);
            this.Controls.Add(this.txtPrecioProducto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombreProducto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnInsertarProducto);
            this.Controls.Add(this.txtNombreFabricante);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInsertarFabricante);
            this.Controls.Add(this.btnMostrarProductosFabricantes);
            this.Controls.Add(this.lstFabricantes);
            this.Controls.Add(this.lstProductos);
            this.Controls.Add(this.btnEstablecerConexion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEstablecerConexion;
        private System.Windows.Forms.ListBox lstProductos;
        private System.Windows.Forms.ListBox lstFabricantes;
        private System.Windows.Forms.Button btnMostrarProductosFabricantes;
        private System.Windows.Forms.Button btnInsertarFabricante;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreFabricante;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnInsertarProducto;
        private System.Windows.Forms.TextBox txtPrecioProducto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBorrarProductos;
        private System.Windows.Forms.Button btnBorrarFabricantes;
        private System.Windows.Forms.Button btnActualizarFabricante;
        private System.Windows.Forms.Button btnActualizarProducto;
    }
}

