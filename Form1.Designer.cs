
namespace Login
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
            this.btn_CambiarContrasenia = new System.Windows.Forms.Button();
            this.lbl_mensaje = new System.Windows.Forms.Label();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_contrasenia = new System.Windows.Forms.TextBox();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_CambiarContrasenia
            // 
            this.btn_CambiarContrasenia.Location = new System.Drawing.Point(97, 291);
            this.btn_CambiarContrasenia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_CambiarContrasenia.Name = "btn_CambiarContrasenia";
            this.btn_CambiarContrasenia.Size = new System.Drawing.Size(169, 38);
            this.btn_CambiarContrasenia.TabIndex = 17;
            this.btn_CambiarContrasenia.Text = "Cambiar Contraseña";
            this.btn_CambiarContrasenia.UseVisualStyleBackColor = true;
            this.btn_CambiarContrasenia.Click += new System.EventHandler(this.btn_CambiarContrasenia_Click);
            // 
            // lbl_mensaje
            // 
            this.lbl_mensaje.AutoSize = true;
            this.lbl_mensaje.ForeColor = System.Drawing.Color.Red;
            this.lbl_mensaje.Location = new System.Drawing.Point(76, 343);
            this.lbl_mensaje.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_mensaje.Name = "lbl_mensaje";
            this.lbl_mensaje.Size = new System.Drawing.Size(0, 20);
            this.lbl_mensaje.TabIndex = 16;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(190, 245);
            this.btn_Cancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(112, 36);
            this.btn_Cancelar.TabIndex = 15;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(290, 27);
            this.label3.TabIndex = 14;
            this.label3.Text = "Sistema de Acceso Vehicular";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 155);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Contraseña:";
            // 
            // txt_contrasenia
            // 
            this.txt_contrasenia.Location = new System.Drawing.Point(67, 185);
            this.txt_contrasenia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_contrasenia.Name = "txt_contrasenia";
            this.txt_contrasenia.PasswordChar = '*';
            this.txt_contrasenia.Size = new System.Drawing.Size(235, 26);
            this.txt_contrasenia.TabIndex = 12;
            // 
            // txt_usuario
            // 
            this.txt_usuario.Location = new System.Drawing.Point(67, 106);
            this.txt_usuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(235, 26);
            this.txt_usuario.TabIndex = 11;
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Location = new System.Drawing.Point(68, 245);
            this.btn_Guardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(112, 36);
            this.btn_Guardar.TabIndex = 10;
            this.btn_Guardar.Text = "Ingresar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 81);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Usuario:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 384);
            this.Controls.Add(this.btn_CambiarContrasenia);
            this.Controls.Add(this.lbl_mensaje);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_contrasenia);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control de Acceso";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_CambiarContrasenia;
        private System.Windows.Forms.Label lbl_mensaje;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_contrasenia;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Label label4;
    }
}

