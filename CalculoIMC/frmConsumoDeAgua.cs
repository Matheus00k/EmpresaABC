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
    public partial class frmConsumoDeAgua : Form
    {
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);
        public frmConsumoDeAgua()
        {
            InitializeComponent();
        }

        private void frmConsumoDeAgua_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            MenuPrincipal abrir = new MenuPrincipal();
            abrir.Show();
            this.Hide();
        }

        public void limpaTudo()
        {
            txtConsumo.Clear();
            txtIdade.Clear();
            txtPeso.Clear();
            lblMostraConsumoDiario.Text = ("");
            lblMostraValor.Text = ("");
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpaTudo();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double m3, metros, pagar = 0;

                m3 = Convert.ToDouble(txtConsumo.Text);
               
                metros = Convert.ToDouble(txtMetros.Text);

                if (!txtMetros.Text.Contains(","))
                {
                    MessageBox.Show("Coloque a virgula!", "Sistema", MessageBoxButtons.OK,
                      MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    txtMetros.Clear();
                    return;
                }

                pagar = metros * m3;

              
                lblMostraValor.Text = string.Format("{0:n2}R$", pagar);
            }
            catch (Exception)
            {

                MessageBox.Show("Preencha os Campos ou Digite Corretamente", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCalcularAgua_Click(object sender, EventArgs e)
        {
            try
            {
                double peso, idade, diario = 0;

                peso = Convert.ToDouble(txtPeso.Text);
                idade = Convert.ToDouble(txtIdade.Text);

                if (idade < 18)
                {
                    diario = peso * 40;
                }
                if (idade >= 18 && idade < 65)
                {
                    diario = peso * 35;
                }
                if (idade > 65)
                {
                    diario = peso * 25;
                }

                lblMostraConsumoDiario.Text = string.Format("{0}ml", diario);
            }
            catch (Exception)
            {

                MessageBox.Show("Preencha os Campos ou Digite Corretamente", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
