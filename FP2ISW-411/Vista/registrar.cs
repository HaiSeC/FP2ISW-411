using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FP2ISW_411.Procesos;
using FP2ISW_411.Modelos;
namespace FP2ISW_411.Vista
{
    public partial class registrar : Form
    {
        procesos P = new procesos();
        bool Id=false;
        bool N=false;
        bool C=false;
        bool A1=false;
        bool A2=false;
        bool Pa = false;
        bool Pro = false;
        bool Can = false;
        bool D = false;
        public registrar()
        {
            InitializeComponent();
            llenar_combo();
            nacimiento.MaxDate = DateTime.Now-(DateTime.Now.AddYears(18)-DateTime.Now) ;
            vainaDeBotones();
        }
        public void vainaDeBotones()
        {
            button_B.Enabled = Id;
            button1.Enabled = (Id && N && C && A1 && A2 && Pa && Pro && Can && D);
            button3.Enabled = (Id && N && C && A1 && A2 && Pa && Pro && Can && D);
            button4.Enabled = (Id && N && C && A1 && A2 && Pa && Pro && Can && D);
        }
        public void llenar_combo()
        {
            List<string> puestos = P.tipo_puestos();
            foreach (string i in puestos)
            {
                combo_puesto.Items.Add(i);
            }
            combo_puesto.SelectedIndex = 0;
        }

        public void registrarse()
        {
            try
            {
                int edad = Convert.ToInt32((DateTime.Now.Subtract(nacimiento.Value).TotalDays)/365);
                encriptar E = new encriptar();
                usuario usu = new usuario(Convert.ToInt64(cedula.Text),nombre.Text,apellido1.Text,apellido2.Text,E.Encriptar(contra.Text),edad,nacimiento.Value,pais.Text,provincia.Text,canton.Text,direccion.Text,DateTime.Now,P.codigo_puest(combo_puesto.Text),1);
                if (P.insert_usuario(usu)&& P.insert_direc(usu))
                {
                    MessageBox.Show("Se ha registrado exitosamente!!");
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un problema, por favor vuelva a intentarlo.");
                }
                cedula.Text = "";
                vaciar();
            }
            catch
            {
                MessageBox.Show("No se pudo realizar el registro.\nPor favor verifique la información");
            }
        }

        public void vaciar()
        {
            nombre.Text = "";
            apellido1.Text = "";
            apellido2.Text = "";
            direccion.Text = "";
            contra.Text = "";
            canton.Text = "";
            pais.Text = "";
            provincia.Text = "";
            act.Text = "";
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (cedula.Text == "")
            {
                this.Id = false;
            }
            else
            {
                this.Id = true;
            }
            vainaDeBotones();
            vaciar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            registrarse();
        }

        private void combo_puesto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (provincia.Text == "")
            {
                this.Pro= false;
            }
            else
            {
                this.Pro = true;
            }
            vainaDeBotones();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (canton.Text == "")
            {
                this.Can = false;
            }
            else
            {
                this.Can = true;
            }
            vainaDeBotones();
        }

        private void nombre_TextChanged(object sender, EventArgs e)
        {
            if (nombre.Text == "")
            {
                this.N = false;
            }
            else
            {
                this.N = true;
            }
            vainaDeBotones();
        }

        private void contra_TextChanged(object sender, EventArgs e)
        {
            if (contra.Text == "")
            {
                this.C = false;
            }
            else
            {
                this.C = true;
            }
            vainaDeBotones();
        }

        private void apellido1_TextChanged(object sender, EventArgs e)
        {
            if (apellido1.Text == "")
            {
                this.A1 = false;
            }
            else
            {
                this.A1 = true;
            }
            vainaDeBotones();
        }

        private void apellido2_TextChanged(object sender, EventArgs e)
        {
            if (apellido2.Text == "")
            {
                this.A2 = false;
            }
            else
            {
                this.A2 = true;
            }
            vainaDeBotones();
        }

        private void pais_TextChanged(object sender, EventArgs e)
        {
            if (pais.Text == "")
            {
                this.Pa = false;
            }
            else
            {
                this.Pa = true;
            }
            vainaDeBotones();
        }

        private void direccion_TextChanged(object sender, EventArgs e)
        {
            if (direccion.Text == "")
            {
                this.D = false;
            }
            else
            {
                this.D = true;
            }
            vainaDeBotones();
        }

        private void button_B_Click(object sender, EventArgs e)
        {
            try
            {
                usuario U = P.info_usu(Convert.ToInt64(cedula.Text));
                if(U == null)
                {
                    MessageBox.Show("El usuario " + cedula.Text + " no esta registrado.");
                }
                else
                {
                    nombre.Text=U.nombre;
                    apellido1.Text = U.Apellido1;
                    apellido2.Text = U.Apellido2;
                    nacimiento.Value = U.Fecha_nac;
                    pais.Text = U.Pais;
                    provincia.Text = U.Provincia;
                    canton.Text = U.Canton;
                    direccion.Text = U.Direccion;
                    if (U.Activo == 1)
                    {
                        act.Text = "Activo";
                    }
                    else
                    {
                        act.Text = "Inactivo";
                    }
                    combo_puesto.SelectedItem = P.nombre_puesto(U.Puesto);
                }
            }
            catch
            {
                MessageBox.Show("Verifique la información.");
            }
        }
    }
}
