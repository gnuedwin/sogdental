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
    public partial class Borrar_Registro : Form
    {
        public Borrar_Registro()
        {
            InitializeComponent();
        }

        long cod;

        bool movimiento = false;


        private void btnborrarregistro_Click(object sender, EventArgs e)
        {
            try
            {

                cod = long.Parse(txtborrar.Text);

                this.dATOS_DEL_PACIENTETableAdapter.BorrarRegistro(cod);
                this.dATOS_DEL_PACIENTETableAdapter.Fill(this.cONSULTORIOSOGDENTALDataSet1.DATOS_DEL_PACIENTE);

                MessageBox.Show("Registro borrado con exito");

            }
            catch(Exception q)
            {
                MessageBox.Show("Introduce la información");
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnatras_Click(object sender, EventArgs e)
        {
            Menu_Principal atras = new Menu_Principal();
            atras.Show();

            this.Close();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            movimiento = true;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if(movimiento == true)
            {
                this.Location = Cursor.Position;
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            movimiento = false;
        }
    }
}
