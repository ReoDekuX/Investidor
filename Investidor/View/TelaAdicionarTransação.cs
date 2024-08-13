using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Investidor.Controller;
using Investidor.Model;

namespace Investidor.View
{
    public partial class TelaAdicionarTransação : Form
    {
        public TelaAdicionarTransação()
        {
            InitializeComponent();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            Comprar.Data_Comprar = DTP_Data.Value;
            Comprar.Tipo_Comprar = cbx_TipoAtivo.Text;
            Comprar.Ativo_Comprar = cbx_Ativo.Text;
            Comprar.Qtd_Comprar = Convert.ToInt32(tbx_qtd.Text);
            Comprar.Preco_Comprar = Convert.ToDecimal(tbx_Preco.Text);
            Comprar.Custos_Comprar = Convert.ToDecimal(tbx_custos.Text);

            ControllerComprar controllerComprar = new ControllerComprar();
            controllerComprar.CadastrarComprar();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            decimal valor3 = Convert.ToDecimal(tbx_custos.Text);
            decimal valor1 = Convert.ToDecimal(tbx_Preco.Text);
            decimal valor2 = Convert.ToDecimal(tbx_qtd.Text);
            decimal valortotal = valor1 * valor2;
            decimal soma = valortotal + valor3;

            lbl_Total.Text = soma.ToString();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            cbx_Ativo.Text = string.Empty;
            tbx_custos.Text = string.Empty;
            tbx_Preco.Text = string.Empty;
            lbl_Total.Text = string.Empty;
            cbx_TipoAtivo.Text = string.Empty;
            tbx_qtd.Text = string.Empty;


        }
    }
}
