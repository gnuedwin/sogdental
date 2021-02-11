using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Empresa_SogDental
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        bool movimiento = false;

        private void btnentrar_Click(object sender, EventArgs e)
        {
           if(txtusuario.Text == "nolberto" && txtcontrasena.Text == "123" || txtusuario.Text == "Anabel" && txtcontrasena.Text == "221893")
            {
                Menu_Principal menu = new Menu_Principal();
                menu.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrectas");
            }
            LimpiarTextbox Limpiar = new LimpiarTextbox();
            Limpiar.BorrarCampos(this);
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //movimientos del formulario

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            movimiento = true;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (movimiento == true)
            {
                this.Location = Cursor.Position;
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            movimiento = false;
        }

       

        private void txtusuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtcontrasena.Focus();
            }
        }

       
    }
}
