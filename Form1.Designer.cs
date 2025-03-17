namespace LaCaguama
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
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.btnLogin_Click = new System.Windows.Forms.Button();
            this.btnMostrarContrasena = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(351, 126);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            // 
            // txtContrasena
            // 
            this.txtContrasena.Location = new System.Drawing.Point(351, 167);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(100, 20);
            this.txtContrasena.TabIndex = 1;
            this.txtContrasena.TextChanged += new System.EventHandler(this.txtContrasena_TextChanged);
            // 
            // btnLogin_Click
            // 
            this.btnLogin_Click.Location = new System.Drawing.Point(363, 207);
            this.btnLogin_Click.Name = "btnLogin_Click";
            this.btnLogin_Click.Size = new System.Drawing.Size(75, 23);
            this.btnLogin_Click.TabIndex = 2;
            this.btnLogin_Click.Text = "Login";
            this.btnLogin_Click.UseVisualStyleBackColor = true;
            this.btnLogin_Click.Click += new System.EventHandler(this.btnLogin_Click_Click);
            // 
            // btnMostrarContrasena
            // 
            this.btnMostrarContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.25F);
            this.btnMostrarContrasena.Location = new System.Drawing.Point(457, 167);
            this.btnMostrarContrasena.Name = "btnMostrarContrasena";
            this.btnMostrarContrasena.Size = new System.Drawing.Size(29, 23);
            this.btnMostrarContrasena.TabIndex = 3;
            this.btnMostrarContrasena.UseVisualStyleBackColor = true;
            this.btnMostrarContrasena.Click += new System.EventHandler(this.btnMostrarContrasena_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(348, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Usuario";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(351, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Contraseña";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LaCaguama.Properties.Resources.Rectangle_52;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMostrarContrasena);
            this.Controls.Add(this.btnLogin_Click);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.txtUsuario);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Button btnLogin_Click;
        private System.Windows.Forms.Button btnMostrarContrasena;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

