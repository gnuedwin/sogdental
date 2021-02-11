using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empresa_SogDental
{
    public partial class Menu_Principal : Form
    {
        public Menu_Principal()
        {
            InitializeComponent();

            lblhora.Text = DateTime.Now.ToLongTimeString();
        }

      

        bool movimiento = false;

      

        private void btnnuevopaciente_Click(object sender, EventArgs e)
        {
            FormularioPaciente NuevoRegisro = new FormularioPaciente();
            NuevoRegisro.Show();

            this.Close();
        }

        private void btnconsultar_Click(object sender, EventArgs e)
        {
            InformacionPaciente informacion = new InformacionPaciente();
            informacion.Show();

            this.Close();
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
      
            
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            movimiento = true;
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            if(movimiento == true)
            {
                this.Location = Cursor.Position;
            }
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            movimiento = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
