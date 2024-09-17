using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoIMC
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }   
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btnFP_Click(object sender, EventArgs e)
        {
            frmFolhadePagamento abrir = new frmFolhadePagamento();
            abrir.Show();
            this.Hide();
        }

        private void btnIMC_Click(object sender, EventArgs e)
        {
            CalculoIMC abrir = new CalculoIMC();
            abrir.Show();
            this.Hide();
        }

        private void btnCombustivel_Click(object sender, EventArgs e)
        {
            frmCombustivel abrir = new frmCombustivel();
            abrir.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmTaxaDeFrequencia abrir = new frmTaxaDeFrequencia();
            abrir.Show();
            this.Hide();
        }

        private void btnCM_Click(object sender, EventArgs e)
        {
            frmConversãodeMoedas abrir = new frmConversãodeMoedas();
            abrir.Show();
            this.Hide();
        }

        private void btnCA_Click(object sender, EventArgs e)
        {
            frmConsumoDeAgua abrir = new frmConsumoDeAgua();
            abrir.Show();
            this.Hide();
        }
    }
}
