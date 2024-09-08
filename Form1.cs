﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Login.Controllers;
using Login.Views.Acesos;
using Login.Views.Bodega;
using Login.Views.Financiero;
using Login.Views;
using Login.Config;
using Login.Views.Usuarios;


namespace Login
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Guardar_Click_1(object sender, EventArgs e)
        {
            try
            {
                UsuariosController _usuariosController = new UsuariosController();
                var usuariomodel = _usuariosController.AutenticarUsuario(txt_usuario.Text.Trim(), txt_contrasenia.Text.Trim());

                if (usuariomodel != null)
                {

                    ConfiguracionProyecto.IDusuario = (int)usuariomodel.ID;
                    ConfiguracionProyecto.usuario = usuariomodel.NombreUsuario;
                    ConfiguracionProyecto.rol = usuariomodel.Roles;
                    this.Hide();

                    Dashboard _dashboard = new Dashboard();
                    _dashboard.Show();
                }
                else
                {
                    lbl_mensaje.Text = "Usuario o contraseña incorrecta";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ha ocurrido un error: {ex.Message}", "Error", MessageBoxButtons.OK);
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            txt_contrasenia.Text = "";
            txt_usuario.Text = "";

        }

        private void btn_CambiarContrasenia_Click(object sender, EventArgs e)
        {
            UsuariosController _usuariosController = new UsuariosController();
            var usuariomodel = _usuariosController.AutenticarUsuario(txt_usuario.Text.Trim(), txt_contrasenia.Text.Trim());

            if (usuariomodel != null)
            {
                frm_Usuarios_Contrsenia cambioContrasenia = new frm_Usuarios_Contrsenia((int)usuariomodel.ID);
                cambioContrasenia.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecta. No se puede cambiar la contraseña.");
            }

        }
    }


}
