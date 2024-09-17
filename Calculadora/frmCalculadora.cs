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

namespace Calculadora
{
    public partial class frmCalculadora : Form
    {
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void limparTudo()
        {
            txtVariavel1.Clear();
            txtVariavel2.Clear();
            rdbAdicao.Checked = false;
            rdbSubtracao.Checked = false;
            rdbMultiplicacao.Checked = false;
            rdbDivisao.Checked = false;
            lblMostraResultado.Text = ("");

        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparTudo();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double num1, num2, resultado = 0;
                num1 = Convert.ToDouble(txtVariavel1.Text);
                num2 = Convert.ToDouble(txtVariavel2.Text);

                if (txtVariavel1.Text.Equals("") || txtVariavel2.Text.Equals(""))
                {
                    MessageBox.Show("Preencha os campos vazios!", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                }
                else if (rdbAdicao.Checked.Equals(false) && rdbSubtracao.Checked.Equals(false) && rdbMultiplicacao.Checked.Equals(false) && rdbDivisao.Checked.Equals(false))
                {
                    MessageBox.Show("Selecione algum Operador",
                      "Sistema", MessageBoxButtons.OK,
                      MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                }


                if (rdbAdicao.Checked)
                {
                    resultado = num1 + num2;
                }
                else if (rdbSubtracao.Checked)
                {
                    resultado = num1 - num2;
                }
                else if (rdbMultiplicacao.Checked)
                {
                    resultado = num1 * num2;
                }
                else if (rdbDivisao.Checked)
                {
                    if (num2 == 0)
                    {
                        MessageBox.Show("Não é possível fazer divisão por 0", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; 
                    }
                    resultado = num1 / num2;
                }

                lblMostraResultado.Text = resultado.ToString();
            }
            catch (Exception )
            {

                MessageBox.Show("Preencha os Campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtVariavel1.Focus();
            }


        }


        private void frmCalculadora_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }
    }
}
