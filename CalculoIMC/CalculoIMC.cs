using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace CalculoIMC
{
    public partial class CalculoIMC : Form
    {
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);
       
        public CalculoIMC()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
        public void limpaTudo()
        {
            txtAltura.Clear();
            txtPeso.Clear();
            lblMostraIMC.Text = ("");
            lblMostraClass.Text = ("");
            lblMostraObe.Text = ("");
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpaTudo();
        }

        private void CalculoIMC_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double peso, altura, imc = 0;
                string classificacao, grau;
                

                peso = Convert.ToDouble(txtPeso.Text);
                altura = Convert.ToDouble(txtAltura.Text);

                imc = peso / (altura * altura);

                if (!txtAltura.Text.Contains(","))
                {
                    
                    MessageBox.Show("Coloque a virgula!","Sistema", MessageBoxButtons.OK,
                      MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    txtAltura.Clear();
                    txtPeso.Clear();
                    lblMostraIMC.Text = ("");
                    lblMostraClass.Text = ("");
                    lblMostraObe.Text = ("");
                    return;
                }

                if (imc < 18.5 )
                {
                    grau = "0";
                    classificacao = "Magreza";
                    lblMostraClass.Text = string.Format(classificacao);
                    lblMostraObe.Text = string.Format(grau);
                }
                 if (imc >= 18.5 && imc <= 24.9 )
                {
                    grau = "0";
                    classificacao = "Normal";
                    lblMostraClass.Text = string.Format(classificacao);
                    lblMostraObe.Text = string.Format(grau);
                }
                if (imc >= 25.0 && imc <= 29.9)
                {
                    grau = "1";
                    classificacao = "Sobrepeso";
                    lblMostraClass.Text = string.Format(classificacao);
                    lblMostraObe.Text = string.Format(grau);
                }
                if (imc >= 30.0 && imc <= 39.9)
                {
                    grau = "2";
                    classificacao = "Obesidade";
                    lblMostraClass.Text = string.Format(classificacao);
                    lblMostraObe.Text = string.Format(grau);
                }
                if (imc > 40.0)
                {
                    grau = "3";
                    classificacao = "Obesidade Grave";
                    lblMostraClass.Text = string.Format(classificacao);
                    lblMostraObe.Text = string.Format(grau);
                }

              
                lblMostraIMC.Text = string.Format("{0:n2}", imc);
            }
            catch (Exception)
            {

                MessageBox.Show("Preencha os Campos ou Digite Corretamente");
                txtAltura.Focus();
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            MenuPrincipal abrir = new MenuPrincipal();
            abrir.Show();
            this.Hide();
        }
    }
}
