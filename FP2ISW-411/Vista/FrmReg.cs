using FP2ISW_411.Modelos;
using FP2ISW_411.Procesos;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace FP2ISW_411.Vista
{
    public partial class FrmReg : Form
    {
        procesos P = new procesos();
        bool Id = false;
        bool N = false;
        bool C = false;
        bool A1 = false;
        bool A2 = false;
        bool Pa = false;
        bool Pro = false;
        bool Can = false;
        bool D = false;
        public FrmReg()
        {
            InitializeComponent();
            FillCBox();
            DPN.MaxDate = DateTime.Now - (DateTime.Now.AddYears(18) - DateTime.Now);
            vainaDeBotones();
            checkBox_act.Enabled = false;
        }
        public void vainaDeBotones()
        {
            BtnS.Enabled = Id;
            BtnReg.Enabled = (Id && N && C && A1 && A2 && Pa && Pro && Can && D);
            BtnDel.Enabled = (Id && N && A1 && A2 && Pa && Pro && Can && D);
            BtnE.Enabled = (Id && N && A1 && A2 && Pa && Pro && Can && D);
        }
        public void FillCBox()
        {
            List<string> puestos = P.tipo_puestos();
            foreach (string i in puestos)
            {
                CBoxRol.Items.Add(i);
            }
            CBoxRol.SelectedIndex = 0;
        }

        public void Register()
        {
            try
            {
                double e1 = (DateTime.Now.Subtract(DPN.Value).TotalDays) / 365;
                //int edad = Convert.ToInt32(Convert.ToString(e1).Split(',')[0]);
                int edad = Convert.ToInt32(Convert.ToString(e1).Split('.')[0]);
                encriptar E = new encriptar();
                usuario usu = new usuario(Convert.ToInt64(TxtCed.Text),TxtName.Text,TxtApe1.Text,TxtApe2.Text,E.Encriptar(TxtPassword.Text),edad,DPN.Value,TxtPais.Text,TxtProvin.Text,TxtCan.Text,TxtDir.Text,DateTime.Now,P.codigo_puest(CBoxRol.Text),1);
                if (P.insert_usuario(usu)&& P.insert_direc(usu))
                {
                    MessageBox.Show("Se ha registrado exitosamente!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un problema, por favor vuelva a intentarlo.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                TxtCed.Text = "";
                Clear();
            }
            catch
            {
                MessageBox.Show("No se pudo realizar el registro.\nPor favor verifique la información", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);;
            }
        }

        public void Clear()
        {
            TxtName.Text = "";
            TxtApe1.Text = "";
            TxtApe2.Text = "";
            TxtDir.Text = "";
            TxtPassword.Text = "";
            TxtCan.Text = "";
            TxtPais.Text = "";
            TxtProvin.Text = "";
            checkBox_act.Enabled = false;
            checkBox_act.Checked = false;
        }
        
        private void TxtCed_TextChanged(object sender, EventArgs e)
        {
            if (TxtCed.Text == "")
            {
                this.Id = false;
            }
            else
            {
                this.Id = true;
            }
            vainaDeBotones();
            Clear();
        }

        private void BtnReg_Click(object sender, EventArgs e)
        {
            Register();
        }

        private void TxtProvin_TextChanged(object sender, EventArgs e)
        {
            if (TxtProvin.Text == "")
            {
                this.Pro= false;
            }
            else
            {
                this.Pro = true;
            }
            vainaDeBotones();
        }
        
        private void TxtCan_TextChanged(object sender, EventArgs e)
        {
            if (TxtCan.Text == "")
            {
                this.Can = false;
            }
            else
            {
                this.Can = true;
            }
            vainaDeBotones();
        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {
            if (TxtName.Text == "")
            {
                this.N = false;
            }
            else
            {
                this.N = true;
            }
            vainaDeBotones();
        }

        private void TxtPass_TextChanged(object sender, EventArgs e)
        {
            if (TxtPassword.Text == "")
            {
                this.C = false;
            }
            else
            {
                this.C = true;
            }
            vainaDeBotones();
        }

        private void TxtApe1_TextChanged(object sender, EventArgs e)
        {
            if (TxtApe1.Text == "")
            {
                this.A1 = false;
            }
            else
            {
                this.A1 = true;
            }
            vainaDeBotones();
        }

        private void TxtApe2_TextChanged(object sender, EventArgs e)
        {
            if (TxtApe2.Text == "")
            {
                this.A2 = false;
            }
            else
            {
                this.A2 = true;
            }
            vainaDeBotones();
        }

        private void TxtPais_TextChanged(object sender, EventArgs e)
        {
            if (TxtPais.Text == "")
            {
                this.Pa = false;
            }
            else
            {
                this.Pa = true;
            }
            vainaDeBotones();
        }

        private void TxtDir_TextChanged(object sender, EventArgs e)
        {
            if (TxtDir.Text == "")
            {
                this.D = false;
            }
            else
            {
                this.D = true;
            }
            vainaDeBotones();
        }

        private void BtnS_Click(object sender, EventArgs e)
        {
            try
            {
                usuario U = P.info_usu(Convert.ToInt64(TxtCed.Text));
                if(U == null)
                {
                    MessageBox.Show("El usuario " + TxtCed.Text + " no esta registrado.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    TxtName.Text = U.nombre;
                    TxtApe1.Text = U.Apellido1;
                    TxtApe2.Text = U.Apellido2;
                    DPN.Value = U.Fecha_nac;
                    TxtPais.Text = U.Pais;
                    TxtProvin.Text = U.Provincia;
                    TxtCan.Text = U.Canton;
                    TxtDir.Text = U.Direccion;
                    if (U.Activo == 1)
                    {
                        checkBox_act.Checked = true;
                        checkBox_act.Enabled = true;
                    }
                    else
                    {
                        checkBox_act.Checked = false;
                        checkBox_act.Enabled = true;
                    }
                    CBoxRol.SelectedItem = P.nombre_puesto(U.Puesto);
                }
            }
            catch
            {
                MessageBox.Show("Verifique la información.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            if (P.desac_usu(Convert.ToInt64(TxtCed.Text)))
            {
                MessageBox.Show("Se ha eliminado exitosamente!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtCed.Text = "";
                Clear();
            }
            else
            {
                MessageBox.Show("Verifique la información.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnE_Click(object sender, EventArgs e)
        {
            int act=0;
            if (checkBox_act.Checked)
            {
                act = 1;
            }
            else
            {
                act = 0;
            }
            double e1 = (DateTime.Now.Subtract(DPN.Value).TotalDays) / 365;
            //int edad = Convert.ToInt32(Convert.ToString(e1).Split(',')[0]);
            int edad = Convert.ToInt32(Convert.ToString(e1).Split('.')[0]);//Esta linea la tengo que usar por algo de la region de Windows xd
            usuario usu = new usuario(Convert.ToInt64(TxtCed.Text), TxtName.Text, TxtApe1.Text, TxtApe2.Text, "", edad, DPN.Value, TxtPais.Text, TxtProvin.Text, TxtCan.Text, TxtDir.Text, DateTime.Now, P.codigo_puest(CBoxRol.Text), act);
            if (P.modi_info(usu))
            {
                MessageBox.Show("Se ha modificado la información exitosamente!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtCed.Text = "";
                Clear();
            }
            else
            {
                MessageBox.Show("Verifique la información.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtCed.Text = "";
            Clear();
        }

        private void FrmReg_Load(object sender, EventArgs e)
        {

        }

        private void LblCan_Click(object sender, EventArgs e)
        {

        }
    }
}
