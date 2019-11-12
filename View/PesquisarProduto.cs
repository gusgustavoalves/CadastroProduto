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
    public partial class PesquisarProduto : Form
    {
        public PesquisarProduto()
        {
            InitializeComponent();
        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            Control.ProdutosC cpro = new Control.ProdutosC();
            string desc;
            desc = txtDescricao.Text;

            if (txtDescricao.Text != "")
            {
                if (cpro.PesquisaProduto(desc))
                {
                    MessageBox.Show("Produto Encontrado !!");
                }
                else
                {
                    MessageBox.Show("Produto Nao Encontrado !!!");
                }
            }
            else
            {
                MessageBox.Show("Campo Descrição não pode ser vazio");
            }
        }
    }
}
