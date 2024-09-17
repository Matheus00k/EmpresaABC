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
    public partial class frmTaxaDeFrequencia : Form
    {
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);
        public frmTaxaDeFrequencia()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            MenuPrincipal abrir = new MenuPrincipal();
            abrir.Show();
            this.Hide();
        }

        private void frmTaxaDeFrequencia_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }

        public void limpaTudo()
        {
            txtAcidentados.Clear();
            txtFuncionarios.Clear();
            txtHoras.Clear();
            lblMostraResult.Text = ("");
            lblMostraQuali.Text = ("");
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpaTudo();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double acidentes, funcionarios, horas,hht, resultado = 0;
                string qualidade;

                acidentes = Convert.ToDouble(txtAcidentados.Text);
                funcionarios = Convert.ToDouble(txtFuncionarios.Text);
                horas = Convert.ToDouble(txtHoras.Text);

                hht = funcionarios * horas;
                resultado = (acidentes * 1000000) / hht;
                qualidade = ("");

                if (resultado < 20 )
                {
                    qualidade = ("Muito Bom");
                }
                else if (resultado > 20.1 && resultado < 40)
                {
                    qualidade = ("Bom");
                }
                else if (resultado > 40.1 && resultado < 60)
                {
                    qualidade = ("Ruim");
                }
                else if (resultado > 60)
                {
                    qualidade = ("Muito Ruim");
                }

                lblMostraQuali.Text = string.Format("{0:n2}", qualidade);
                lblMostraResult.Text = string.Format("{0:n2}", resultado);
            }
            catch (Exception)
            {
                MessageBox.Show("Preencha os Campos vazios ou Digite Corretamente", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
