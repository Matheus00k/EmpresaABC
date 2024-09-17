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
    public partial class frmConversãodeMoedas : Form
    {
        public frmConversãodeMoedas()
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
            txtReal.Clear();
            rdbDolar.Checked = false;
            rdbEuro.Checked = false;
            rdbIene.Checked = false;
            rdbPeso.Checked = false;
            lblMostraResultado.Text = ("");
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpaTudo();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double real, dolar, peso, iene, euro, result = 0;
                string moeda;

                real = Convert.ToDouble(txtReal.Text);
                moeda = "";

                dolar = 5.55;
                peso = 0.0058;
                iene = 0.040;
                euro = 6.18;

                if (!rdbPeso.Checked && !rdbIene.Checked && !rdbEuro.Checked && !rdbDolar.Checked)
                {
                    MessageBox.Show("Selecione Alguma Moeda");
                }

                if (rdbDolar.Checked)
                {
                   result= real / dolar;
                }
                if (rdbEuro.Checked)
                {
                    result = real / euro;
                }
                if (rdbIene.Checked)
                {
                    result = real / iene;
                }
                if (rdbPeso.Checked)
                {
                    result = real / peso;
                }

                if (rdbDolar.Checked)
                {
                    moeda = "Dolar US$";
                }
                if (rdbEuro.Checked)
                {
                    moeda = "Euro €";
                }
                if (rdbIene.Checked)
                {
                    moeda = "Iene ¥";
                }
                if (rdbPeso.Checked)
                {
                    moeda ="Peso $";
                }



                lblMostraResultado.Text = string.Format("{0:n2}", result);
                lblMostraMoeda.Text = string.Format("{0}", moeda);
            }
            catch (Exception)
            {

                MessageBox.Show("Preencha os campos Vazios ou Digite Corretamente", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
