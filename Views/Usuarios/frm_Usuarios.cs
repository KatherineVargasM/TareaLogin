using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using Login.Controllers;
using Login.Models;
using Login.Config;
using Login.config;

namespace Login.Views.Usuarios
{
    public partial class frm_Usuarios : Form
    {
        SerialPort _arduino;

        UsuariosController _usuariosController = new UsuariosController();

        int id = 0;

        public frm_Usuarios()
        {
            InitializeComponent();
            /* _arduino = new SerialPort();
             _arduino.PortName = "COM4";
             _arduino.BaudRate = 9600;
             _arduino.Open();*/
        }


        private void frm_Usuarios_Load(object sender, EventArgs e)
        {
            cargalista();
            cmb_roles.SelectedIndex = 0;

        }

        private void cargalista()
        {

            var listausuarios = _usuariosController.ObtenerTodosLosUsuarios();
            lst_usuarios.DataSource = null;
            lst_usuarios.DataSource = listausuarios;
            lst_usuarios.DisplayMember = "NombreUsuario";
            lst_usuarios.ValueMember = "ID";
        }

        private void frm_Usuarios_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*if (_arduino.IsOpen) {
                _arduino.Close();}*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //_arduino.Write("E");
            // txt_nombre.Text = _arduino.Read().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //_arduino.Write("F");
        }

        private void limpiarCampos()
        {
            txt_nombre.Text = "";
            txt_contrasenia.Text = "";
            txt_repita.Text = "";
            cmb_roles.SelectedIndex = 0;
            id = 0;
        }

        public bool comprobar()
        {
            if (txt_nombre.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el nombre del usuario.");
                return false;
            }
            else if (txt_contrasenia.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese la contraseña.");
                return false;
            }
            else if (txt_repita.Text.Trim() == "")
            {
                MessageBox.Show("Repita la contraseña.");
                return false;
            }
            else if (cmb_roles.SelectedIndex == -1 || cmb_roles.SelectedIndex == 0)
            {
                MessageBox.Show("Seleccione un rol.");
                return false;
            }
            else if (txt_contrasenia.Text.Trim() != txt_repita.Text.Trim())
            {
                MessageBox.Show("Las contraseñas no coinciden.");
                return false;
            }
            else
            {
                return true;
            }

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (comprobar())
            {
                var resultado = new UsuariosModel();
                var res = "";
                var usuario = new UsuariosModel
                {
                    ID = this.id,
                    NombreUsuario = txt_nombre.Text.Trim().ToString(),
                    Password = txt_contrasenia.Text.Trim().ToString(),
                    Roles = cmb_roles.SelectedItem.ToString()
                };

                if (this.id != 0)
                {
                    res = _usuariosController.ActualizarUsuario(usuario);
                }
                else
                {
                    resultado = _usuariosController.InsertarUsuario(usuario);
                    res = resultado.ID > 0 ? "OK" : "Error";
                }

                if (res == "OK")
                {
                    MessageBox.Show("Operación realizada con éxito.");
                    cargalista();
                    limpiarCampos();
                }
                else
                {
                    MessageBox.Show("Ocurrió un error al guardar.");
                }

            }
        }

        private void btn_cancelar_Click_1(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            if (lst_usuarios.SelectedValue != null)
            {
                if (comprobar())
                {
                    var usuario = new UsuariosModel
                    {
                        ID = this.id,
                        NombreUsuario = txt_nombre.Text.Trim(),
                        Password = txt_contrasenia.Text.Trim(),
                        Roles = cmb_roles.SelectedItem.ToString()
                    };

                    var resultado = _usuariosController.ActualizarUsuario(usuario);
                    if (resultado == "OK")
                    {
                        MessageBox.Show("Usuario modificado con éxito.");
                        cargalista();
                        limpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("Ocurrió un error al modificar el usuario");
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un usuario de la lista para modificar.");
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (lst_usuarios.SelectedValue != null)
            {
                var result = MessageBox.Show("¿Está seguro de que desea eliminar este usuario?", "Confirmar eliminación", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    var usuarioId = (int)lst_usuarios.SelectedValue;
                    var res = _usuariosController.EliminarUsuario(usuarioId);

                    if (res == "OK")
                    {
                        MessageBox.Show("Usuario eliminado con éxito.");
                        cargalista();
                    }
                    else
                    {
                        MessageBox.Show("Ocurrió un error al eliminar, inténtelo más tarde.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un usuario para eliminar.");
            }

        }

        private void lst_usuarios_DoubleClick(object sender, EventArgs e)
        {
            if (lst_usuarios.SelectedValue != null)
            {
                var usuario = _usuariosController.ObtenerUsuarioPorId((int)lst_usuarios.SelectedValue);
                this.id = (int)usuario.ID;
                txt_nombre.Text = usuario.NombreUsuario;
                txt_contrasenia.Text = usuario.Password;
                txt_repita.Text = usuario.Password;
                cmb_roles.SelectedItem = usuario.Roles;
            }
            else
            {
                MessageBox.Show("Seleccione un usuario de la lista para modificar.");
            }

        }
    }
}
