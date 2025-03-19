namespace LaCaguama.Formularios
{
    partial class FormAdmin
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
            this.btnCerrarSesion_Click = new System.Windows.Forms.Button();
            this.btnGestionUsuarios = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(381, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnCerrarSesion_Click
            // 
            this.btnCerrarSesion_Click.Location = new System.Drawing.Point(384, 167);
            this.btnCerrarSesion_Click.Name = "btnCerrarSesion_Click";
            this.btnCerrarSesion_Click.Size = new System.Drawing.Size(75, 23);
            this.btnCerrarSesion_Click.TabIndex = 1;
            this.btnCerrarSesion_Click.Text = "Cerrar Sesion";
            this.btnCerrarSesion_Click.UseVisualStyleBackColor = true;
            this.btnCerrarSesion_Click.Click += new System.EventHandler(this.btnCerrarSesion_Click_Click);
            // 
            // btnGestionUsuarios
            // 
            this.btnGestionUsuarios.Location = new System.Drawing.Point(506, 143);
            this.btnGestionUsuarios.Name = "btnGestionUsuarios";
            this.btnGestionUsuarios.Size = new System.Drawing.Size(126, 47);
            this.btnGestionUsuarios.TabIndex = 2;
            this.btnGestionUsuarios.Text = "Administrar Usuarios";
            this.btnGestionUsuarios.UseVisualStyleBackColor = true;
            this.btnGestionUsuarios.Click += new System.EventHandler(this.btnGestionUsuarios_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGestionUsuarios);
            this.Controls.Add(this.btnCerrarSesion_Click);
            this.Controls.Add(this.label1);
            this.Name = "FormAdmin";
            this.Text = "FormAdmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCerrarSesion_Click;
        private System.Windows.Forms.Button btnGestionUsuarios;
    }
}