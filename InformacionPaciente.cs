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
    public partial class InformacionPaciente : Form
    {

        long cod;

        public InformacionPaciente()
        {
            InitializeComponent();
        }

        bool movimiento = false;

      

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

        private void InformacionPaciente_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'cONSULTORIOSOGDENTALDataSet2.citaspacientes' Puede moverla o quitarla según sea necesario.
            this.citaspacientesTableAdapter.Fill(this.cONSULTORIOSOGDENTALDataSet2.citaspacientes);

        }

        private void btnagregarcita_Click(object sender, EventArgs e)
        {
            try
            {
                cod = long.Parse(txt0.Text);

                this.citaspacientesTableAdapter.Agregarcita(cod, txt1.Text, txt2.Text, txt3.Text, txt4.Text, txt5.Text, txt6.Text, txt7.Text, txt8.Text,
                    txt9.Text);

                this.citaspacientesTableAdapter.Fill(this.cONSULTORIOSOGDENTALDataSet2.citaspacientes);

                MessageBox.Show("Cita de " + txt1.Text + " Exitoso");

            }
            catch (Exception i)
            {
                MessageBox.Show("Debes llenar los campos.");
            }

            LimpiarTextbox Limpiar = new LimpiarTextbox();
            Limpiar.BorrarCampos(this);
        }

        private void btnactualizarcita_Click(object sender, EventArgs e)
        {
            try
            {
                cod = long.Parse(txt0.Text);

                this.citaspacientesTableAdapter.Actualizarcita(cod, txt1.Text, txt2.Text, txt3.Text, txt4.Text, txt5.Text, txt6.Text, txt7.Text, txt8.Text,
                    txt9.Text);

                this.citaspacientesTableAdapter.Fill(this.cONSULTORIOSOGDENTALDataSet2.citaspacientes);

                MessageBox.Show("Se actualizaron los datos de " + txt1.Text);

            }
            catch (Exception o)
            {
                MessageBox.Show("Debes completar los campos");
            }

            LimpiarTextbox Limpiar = new LimpiarTextbox();
            Limpiar.BorrarCampos(this);
        }

        private void btnbuscarcita_Click(object sender, EventArgs e)
        {
            try
            {
               
                    cod = long.Parse(txt0.Text);

                    this.citaspacientesTableAdapter.Consultacita(this.cONSULTORIOSOGDENTALDataSet2.citaspacientes, cod);
               
                





            }
            catch (Exception o)
            {
                MessageBox.Show("Debes realizar una consulta");
            }

            LimpiarTextbox Limpiar = new LimpiarTextbox();
            Limpiar.BorrarCampos(this);
        }

        private void btneliminarcita_Click(object sender, EventArgs e)
        {
            try
            {

                cod = long.Parse(txt0.Text);

                this.citaspacientesTableAdapter.Eliminarcita(cod);
                this.citaspacientesTableAdapter.Fill(this.cONSULTORIOSOGDENTALDataSet2.citaspacientes);

                MessageBox.Show("Cita borrada con exito");

            }
            catch (Exception q)
            {
                MessageBox.Show("Introduce la información");
            }

            LimpiarTextbox Limpiar = new LimpiarTextbox();
            Limpiar.BorrarCampos(this);
        }

        private void txt0_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txt1.Focus();
            }
        }

        private void txt1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txt2.Focus();
            }
        }

        private void txt2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txt3.Focus();
            }
        }

        private void txt3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txt4.Focus();
            }
        }

        private void txt4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txt5.Focus();
            }
        }

        private void txt5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txt6.Focus();
            }
        }

        private void txt6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txt7.Focus();
            }
        }

        private void txt7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txt8.Focus();
            }
        }

        private void txt8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txt9.Focus();
            }
        }

        private void txt9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnagregarcita.Focus();
            }
        }
    }
    
}
