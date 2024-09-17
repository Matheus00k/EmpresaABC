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
    public partial class frmFolhadePagamento : Form
    {
        public frmFolhadePagamento()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            MenuPrincipal abrir = new MenuPrincipal();
            abrir.Show();
            this.Hide();
        }

        public void limpaTudo()
        {
            txtSB.Clear();
            lblMostraCooperativa.Text = ("");
            lblMostraINSS.Text = ("");
            lblMostraIR.Text = ("");
            lblMostraSL.Text = ("");
            rdbClassA.Checked = false;
            rdbClassB.Checked = false;
            rdbClassC.Checked = false;
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpaTudo();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double SB, INSS, IR, cooperativa, SL= 0;

                SB = Convert.ToDouble(txtSB.Text);
                INSS = SB;
                IR = SB;
                cooperativa = SB;

                if (rdbClassA.Checked)
                {
                    cooperativa = (SB * 0.30);
                }
                if (rdbClassB.Checked)
                {
                    cooperativa =  (SB * 0.20);
                }
                if (rdbClassC.Checked)
                {
                    cooperativa =  (SB * 0.10);
                }
                if (SB < 1412 )
                {
                    INSS = 0;
                    
                }
                if (SB <= 2112.01)
                {
                    IR = 0;
                }

                if (SB >= 1412 && SB <= 2666.68)
                {
                    INSS = 21.18;
                }
                if (SB >= 2112.02 && SB <= 2826.66)
                {
                    IR = 158.40;
                }
                
                if (SB >= 2666.69 && SB <= 4000.03)
                {
                    INSS = 101.18;
                }
                if (SB >= 2826.66 && SB <= 3751.05)
                {
                    IR = 158.40;
                }
              
                if (SB >= 4000.04 && SB <= 7786.02)
                {
                    INSS = 181.18;
                }
                
                if (SB >= 3751.06 && SB <= 4664.68)
                {
                    IR = 651.73;
                }
                
                if (SB > 4664.68 && SB > 7786.02)
                {
                    INSS = 181.18;
                    IR = 884.96;
                }
               

                SL = SB - INSS - IR - cooperativa;

                lblMostraSL.Text = string.Format("{0}$", SL);
                lblMostraIR.Text = string.Format("{0}$", IR);
                lblMostraINSS.Text = string.Format("{0}$", INSS);
                lblMostraCooperativa.Text = string.Format("{0}$", cooperativa);

            }
            catch (Exception)
            {

                MessageBox.Show("Preencha os campos vazios ou Digite corretamente", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
