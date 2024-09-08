using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Login.Controllers;
using Login.Views;
using Login.Views.Acesos;
using Login.Views.Bodega;
using Login.Views.Financiero;
using Login.Views.Usuarios;

namespace Login.Views
{
    public partial class Dashboard : Form
    {

        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

            var roles = ConfiguracionProyecto.rol;
            var nombreusuairo = ConfiguracionProyecto.usuario;
            var diusaurios = ConfiguracionProyecto.IDusuario;

            menu.Items.Clear();

            ToolStripMenuItem usuariosItem = new ToolStripMenuItem("Usuarios");
            usuariosItem.Font = new Font("Arial", 12);
            usuariosItem.Click += new EventHandler(frm_Usuarios_click);

            ToolStripMenuItem accesosItem = new ToolStripMenuItem("Accesos");
            accesosItem.Font = new Font("Arial", 12);
            accesosItem.Click += new EventHandler(frm_Accesos_click);

            ToolStripMenuItem bodegaItem = new ToolStripMenuItem("Bodega");
            bodegaItem.Font = new Font("Arial", 12);
            bodegaItem.Click += new EventHandler(frm_Bodega_click);

            ToolStripMenuItem financieroItem = new ToolStripMenuItem("Financiero");
            financieroItem.Font = new Font("Arial", 12);
            financieroItem.Click += new EventHandler(frm_Financiero_click);


            if (roles == "Admin")
            {
                menu.Items.Add(usuariosItem);
                menu.Items.Add(accesosItem);
                menu.Items.Add(bodegaItem);
                menu.Items.Add(financieroItem);
            }

            else if (roles == "Guardia")
            {
                menu.Items.Add(usuariosItem);
                menu.Items.Add(accesosItem);
            }
            else if (roles == "Financiero")
            {
                menu.Items.Add(financieroItem);
            }
            else if (roles == "Bodega")
            {
                menu.Items.Add(bodegaItem);
            }
            else
            {

            }

        }
        private void frm_Usuarios_click(object sender, EventArgs e)
        {
            var roles = ConfiguracionProyecto.rol;

            frm_Usuarios _Usuarios = new frm_Usuarios();
            _Usuarios.ShowDialog();
        }

        private void frm_Bodega_click(object sender, EventArgs e)
        {
            frm_Bodega_Principal bodega = new frm_Bodega_Principal();
            bodega.Show();
        }

        private void frm_Financiero_click(object sender, EventArgs e)
        {
            frm_Financiero_Principal financiero = new frm_Financiero_Principal();
            financiero.Show();
        }

        private void frm_Accesos_click(object sender, EventArgs e)
        {
            frm_Accesos_Principal accesos = new frm_Accesos_Principal();
            accesos.Show();
        }

    }
}

