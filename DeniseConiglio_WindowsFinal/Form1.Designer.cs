namespace DeniseConiglio_WindowsFinal
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
            this.btbValidaciones = new System.Windows.Forms.Button();
            this.ibiNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.ibiApellido = new System.Windows.Forms.Label();
            this.ibiSueldo = new System.Windows.Forms.Label();
            this.ibiPuesto = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.txtPuesto = new System.Windows.Forms.TextBox();
            this.btbMostrar = new System.Windows.Forms.Button();
            this.btbIngresarHoras = new System.Windows.Forms.Button();
            this.btbLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btbValidaciones
            // 
            this.btbValidaciones.Location = new System.Drawing.Point(421, 75);
            this.btbValidaciones.Name = "btbValidaciones";
            this.btbValidaciones.Size = new System.Drawing.Size(166, 30);
            this.btbValidaciones.TabIndex = 0;
            this.btbValidaciones.Text = "VALIDACIONES";
            this.btbValidaciones.UseVisualStyleBackColor = true;
            this.btbValidaciones.Click += new System.EventHandler(this.btbValidaciones_Click);
            // 
            // ibiNombre
            // 
            this.ibiNombre.AutoSize = true;
            this.ibiNombre.Location = new System.Drawing.Point(76, 83);
            this.ibiNombre.Name = "ibiNombre";
            this.ibiNombre.Size = new System.Drawing.Size(66, 16);
            this.ibiNombre.TabIndex = 1;
            this.ibiNombre.Text = "NOMBRE";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(225, 83);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(113, 22);
            this.txtNombre.TabIndex = 2;
            // 
            // ibiApellido
            // 
            this.ibiApellido.AutoSize = true;
            this.ibiApellido.Location = new System.Drawing.Point(76, 158);
            this.ibiApellido.Name = "ibiApellido";
            this.ibiApellido.Size = new System.Drawing.Size(71, 16);
            this.ibiApellido.TabIndex = 3;
            this.ibiApellido.Text = "APELLIDO";
            // 
            // ibiSueldo
            // 
            this.ibiSueldo.AutoSize = true;
            this.ibiSueldo.Location = new System.Drawing.Point(76, 236);
            this.ibiSueldo.Name = "ibiSueldo";
            this.ibiSueldo.Size = new System.Drawing.Size(62, 16);
            this.ibiSueldo.TabIndex = 4;
            this.ibiSueldo.Text = "SUELDO";
            // 
            // ibiPuesto
            // 
            this.ibiPuesto.AutoSize = true;
            this.ibiPuesto.Location = new System.Drawing.Point(76, 317);
            this.ibiPuesto.Name = "ibiPuesto";
            this.ibiPuesto.Size = new System.Drawing.Size(63, 16);
            this.ibiPuesto.TabIndex = 5;
            this.ibiPuesto.Text = "PUESTO";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(225, 155);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(113, 22);
            this.txtApellido.TabIndex = 6;
            // 
            // txtSueldo
            // 
            this.txtSueldo.Location = new System.Drawing.Point(225, 236);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(113, 22);
            this.txtSueldo.TabIndex = 7;
            // 
            // txtPuesto
            // 
            this.txtPuesto.Location = new System.Drawing.Point(225, 311);
            this.txtPuesto.Name = "txtPuesto";
            this.txtPuesto.Size = new System.Drawing.Size(113, 22);
            this.txtPuesto.TabIndex = 8;
            // 
            // btbMostrar
            // 
            this.btbMostrar.Location = new System.Drawing.Point(421, 158);
            this.btbMostrar.Name = "btbMostrar";
            this.btbMostrar.Size = new System.Drawing.Size(166, 30);
            this.btbMostrar.TabIndex = 9;
            this.btbMostrar.Text = "MOSTRAR";
            this.btbMostrar.UseVisualStyleBackColor = true;
            this.btbMostrar.Click += new System.EventHandler(this.btbMostrar_Click);
            // 
            // btbIngresarHoras
            // 
            this.btbIngresarHoras.Location = new System.Drawing.Point(421, 236);
            this.btbIngresarHoras.Name = "btbIngresarHoras";
            this.btbIngresarHoras.Size = new System.Drawing.Size(166, 30);
            this.btbIngresarHoras.TabIndex = 10;
            this.btbIngresarHoras.Text = "INGRESAR HORAS";
            this.btbIngresarHoras.UseVisualStyleBackColor = true;
            this.btbIngresarHoras.Click += new System.EventHandler(this.btbIngresarHoras_Click);
            // 
            // btbLimpiar
            // 
            this.btbLimpiar.Location = new System.Drawing.Point(421, 307);
            this.btbLimpiar.Name = "btbLimpiar";
            this.btbLimpiar.Size = new System.Drawing.Size(166, 30);
            this.btbLimpiar.TabIndex = 11;
            this.btbLimpiar.Text = "LIMPIAR";
            this.btbLimpiar.UseVisualStyleBackColor = true;
//            this.btbLimpiar.Click += new System.EventHandler(this.btbLimpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btbLimpiar);
            this.Controls.Add(this.btbIngresarHoras);
            this.Controls.Add(this.btbMostrar);
            this.Controls.Add(this.txtPuesto);
            this.Controls.Add(this.txtSueldo);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.ibiPuesto);
            this.Controls.Add(this.ibiSueldo);
            this.Controls.Add(this.ibiApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.ibiNombre);
            this.Controls.Add(this.btbValidaciones);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btbValidaciones;
        private System.Windows.Forms.Label ibiNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label ibiApellido;
        private System.Windows.Forms.Label ibiSueldo;
        private System.Windows.Forms.Label ibiPuesto;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtSueldo;
        private System.Windows.Forms.TextBox txtPuesto;
        private System.Windows.Forms.Button btbMostrar;
        private System.Windows.Forms.Button btbIngresarHoras;
        private System.Windows.Forms.Button btbLimpiar;
    }
}

