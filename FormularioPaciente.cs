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
    public partial class FormularioPaciente : Form
    {
        public FormularioPaciente()
        {
            InitializeComponent();
        }

        long cod;

        bool movimiento = false;

     

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            try
            {
                cod = long.Parse(txtcodigo.Text);

            this.dATOS_DEL_PACIENTETableAdapter.Registro(cod,txt1.Text,txt2.Text,txt3.Text, txt4.Text, txt5.Text, txt6.Text, txt7.Text, txt8.Text,
                txt9.Text, txt10.Text, txt11.Text, txt12.Text, txt13.Text, txt14.Text, txt15.Text,txt16.Text, txt17.Text, txt18.Text, txt19.Text, txt20.Text, txt21.Text, txt22.Text, txt23.Text, txt24.Text, txt25.Text, txt26.Text, txt27.Text, txt28.Text);

            this.dATOS_DEL_PACIENTETableAdapter.Fill(this.cONSULTORIOSOGDENTALDataSet1.DATOS_DEL_PACIENTE);

                MessageBox.Show("Registro de " + txt1.Text + " Exitoso");

            }
            catch(Exception i)
            {
                MessageBox.Show("Debes llenar los campos.");
            }

            LimpiarTextbox Limpiar = new LimpiarTextbox();
            Limpiar.BorrarCampos(this);

        }

        private void dATOS_DEL_PACIENTEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dATOS_DEL_PACIENTEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cONSULTORIOSOGDENTALDataSet1);

        }

        private void FormularioPaciente_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'cONSULTORIOSOGDENTALDataSet1.DATOS_DEL_PACIENTE' Puede moverla o quitarla según sea necesario.
            this.dATOS_DEL_PACIENTETableAdapter.Fill(this.cONSULTORIOSOGDENTALDataSet1.DATOS_DEL_PACIENTE);

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

        private void btnactualizarpaciente_Click(object sender, EventArgs e)
        {
            try
            {
                cod = long.Parse(txtcodigo.Text);

                this.dATOS_DEL_PACIENTETableAdapter.Actualizar(cod, txt1.Text, txt2.Text, txt3.Text, txt4.Text, txt5.Text, txt6.Text, txt7.Text, txt8.Text,
                    txt9.Text, txt10.Text, txt11.Text, txt12.Text, txt13.Text, txt14.Text, txt15.Text, txt16.Text, txt17.Text, txt18.Text, txt19.Text, txt20.Text, txt21.Text, txt22.Text, txt23.Text, txt24.Text, txt25.Text, txt26.Text, txt27.Text, txt28.Text);

                this.dATOS_DEL_PACIENTETableAdapter.Fill(this.cONSULTORIOSOGDENTALDataSet1.DATOS_DEL_PACIENTE);

                MessageBox.Show("Se actualizaron los datos de " + txt1.Text);

            }
            catch(Exception o)
            {
                MessageBox.Show("Debes completar los campos");
            }

            LimpiarTextbox Limpiar = new LimpiarTextbox();
            Limpiar.BorrarCampos(this);
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

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            {


                SqlConnection conexion = new SqlConnection(@"Server=DESKTOP-PP2RB31\SQLEXPRESS;Database=CONSULTORIOSOGDENTAL;Trusted_Connection=True;");

                conexion.Open();

                try
                {

                    long cod = long.Parse(txtcodigo.Text);

                    //string cod = (txtbuscar.Text);

                    string cadena = "select Nombre,Cédula,Teléfono,Estado_Civil,Edad,Dirección,Ocupación,Teléfono_Familiar,Embarazada,Medicamento_Actual,Alergico_a_Medicamentos,Tipo_Medicamento,Somníferos,Padece_Enfermedad,Problemas_Cardiacos,Enfermedad_Hereditaria,Hemorragia,Cirugías,Flujo_Salival,Uso_Colutorios,Hilo_Dental,Cepillado,Caries,Ult_Visita,Inflamación_Leve,Inflamación_Moderada,Inflamación_Severa,Observaciones from DATOS_DEL_PACIENTE where codigo =" + cod;
                    SqlCommand comando = new SqlCommand(cadena, conexion);
                    SqlDataReader registro = comando.ExecuteReader();



                    if (registro.Read())
                    {
                        txt1.Text = registro["Nombre"].ToString();
                        txt2.Text = registro["Cédula"].ToString();
                        txt3.Text = registro["Teléfono"].ToString();
                        txt4.Text = registro["Estado_Civil"].ToString();
                        txt5.Text = registro["Edad"].ToString();
                        txt6.Text = registro["Dirección"].ToString();
                        txt7.Text = registro["Ocupación"].ToString();
                        txt8.Text = registro["Teléfono_Familiar"].ToString();
                        txt9.Text = registro["Embarazada"].ToString();
                        txt10.Text = registro["Medicamento_Actual"].ToString();
                        txt11.Text = registro["Alergico_a_Medicamentos"].ToString();
                        txt12.Text = registro["Tipo_Medicamento"].ToString();
                        txt13.Text = registro["Somníferos"].ToString();
                        txt14.Text = registro["Padece_Enfermedad"].ToString();
                        txt15.Text = registro["Problemas_Cardiacos"].ToString();
                        txt16.Text = registro["Enfermedad_Hereditaria"].ToString();
                        txt17.Text = registro["Hemorragia"].ToString();
                        txt18.Text = registro["Cirugías"].ToString();
                        txt19.Text = registro["Flujo_Salival"].ToString();
                        txt20.Text = registro["Uso_Colutorios"].ToString();
                        txt21.Text = registro["Hilo_Dental"].ToString();
                        txt22.Text = registro["Cepillado"].ToString();
                        txt23.Text = registro["Caries"].ToString();
                        txt24.Text = registro["Ult_Visita"].ToString();
                        txt25.Text = registro["Inflamación_Leve"].ToString();
                        txt26.Text = registro["Inflamación_Moderada"].ToString();
                        txt27.Text = registro["Inflamación_Severa"].ToString();
                        txt28.Text = registro["Observaciones"].ToString();


                    }
                    else
                    {
                        MessageBox.Show("Codigo no Existe");

                    }

                }
                catch (Exception o)
                {
                    MessageBox.Show("Debes agregar una consulta");
                }
            }

           
        }

        private void btnborrarregistro_Click(object sender, EventArgs e)
        {
            try
            {

                cod = long.Parse(txtcodigo.Text);

                this.dATOS_DEL_PACIENTETableAdapter.BorrarRegistro(cod);
                this.dATOS_DEL_PACIENTETableAdapter.Fill(this.cONSULTORIOSOGDENTALDataSet1.DATOS_DEL_PACIENTE);

                MessageBox.Show("Registro borrado con exito");

            }
            catch (Exception q)
            {
                MessageBox.Show("Introduce la información");
            }

            LimpiarTextbox Limpiar = new LimpiarTextbox();
            Limpiar.BorrarCampos(this);
        }

        private void txtcodigo_KeyPress(object sender, KeyPressEventArgs e)
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
                txt1.Focus();
            }
        }

        private void txt1_KeyPress(object sender, KeyPressEventArgs e)
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
                txt10.Focus();
            }
        }

        private void txt10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txt11.Focus();
            }
        }

        private void txt11_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txt12.Focus();
            }
        }

        private void txt12_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txt13.Focus();
            }
        }

        private void txt13_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txt14.Focus();
            }
        }

        private void txt14_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txt15.Focus();
            }
        }

        private void txt15_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txt16.Focus();
            }
        }

        private void txt16_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txt17.Focus();
            }
        }

        private void txt17_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txt18.Focus();
            }
        }

        private void txt18_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txt19.Focus();
            }
        }

        private void txt19_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txt20.Focus();
            }
        }

        private void txt20_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txt21.Focus();
            }
        }

        private void txt21_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txt22.Focus();
            }
        }

        private void txt22_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txt23.Focus();
            }
        }

        private void txt23_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txt24.Focus();
            }
        }

        private void txt24_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txt25.Focus();
            }
        }

        private void txt25_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txt26.Focus();
            }
        }

        private void txt26_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txt27.Focus();
            }
        }

        private void txt27_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txt28.Focus();
            }
        }

        private void txt28_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnregistrar.Focus();
            }
        }
    }
}
