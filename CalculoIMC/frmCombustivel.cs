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
    public partial class frmCombustivel : Form
    {
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);
        public frmCombustivel()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            MenuPrincipal abrir = new MenuPrincipal();
            abrir.Show();
            this.Hide();
        }

        private void frmCombustivel_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double distancia, consumo, preco, km, litro, resultado = 0;

                distancia= Convert.ToDouble(txtDistancia.Text);
                consumo = Convert.ToDouble(txtConsumo.Text);
                preco = Convert.ToDouble(txtPreco.Text);

                km = distancia;
                litro = (distancia / 100) * consumo;
                resultado = litro * preco;

                lblMostraKM.Text = string.Format("{0}km", km);
                lblMostraConsumo.Text = string.Format("{0}L", litro);
                lblMostraResultado.Text = string.Format("{0:n2}$", resultado);
            }
            catch (Exception)
            {

                MessageBox.Show("Preencha os campos vazios ou Digite corretamente ", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtConsumo.Focus();
            }
        }
        public void limpaTudo()
        {
            txtDistancia.Clear();
            txtPreco.Clear();
            txtConsumo.Clear();
            lblMostraConsumo.Text = ("");
            lblMostraKM.Text = ("");
            lblMostraResultado.Text = ("");
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpaTudo();
           
        }
    }
}
