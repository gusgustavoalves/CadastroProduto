using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroProduto.View
{
    public partial class CadastroProdutoView : Form
    {
        public CadastroProdutoView()
        {
            InitializeComponent();
        }

        private void CadastroProdutoView_Load(object sender, EventArgs e)
        {

        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            string desc, valtemp;
            int quant;
            float val;

            Control.ProdutosC cpro = new Control.ProdutosC();
            
            if (txtDescricao.Text != "" && txtQuantidade.Text != "" && txtValorUnitario.Text != "")
            {
                desc = txtDescricao.Text;
                quant = Convert.ToInt32(txtQuantidade.Text);
                valtemp = txtValorUnitario.Text;
                valtemp = valtemp.Replace(".", ",");
                val = float.Parse(valtemp);
                if (cpro.CadastraProduto(desc, quant, val))
                {
                    MessageBox.Show("Produto cadastrado com sucesso!");
                }
                else
                {
                    MessageBox.Show("O produto na foi Cadastrado Revise os dados");
                }
               
            }
            else
            {
                MessageBox.Show("Campos não podem ser vazios");
            }
        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            PesquisarProduto pes = new PesquisarProduto();
            pes.Show();
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            ExcluirProduto exc = new ExcluirProduto();
            exc.Show();

        }
    }
}
