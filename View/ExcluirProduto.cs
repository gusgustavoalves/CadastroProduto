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
    public partial class ExcluirProduto : Form
    {
        public ExcluirProduto()
        {
            InitializeComponent();
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            Control.ProdutosC cpro = new Control.ProdutosC();
            int id;
            id = Convert.ToInt32(txtID.Text);

            if (txtID.Text != "")
            {
                if (cpro.ExcluirProduto(id))
                {
                    MessageBox.Show("Produto Excluido !!");
                }
                else
                {
                    MessageBox.Show("Nao Foi Possivel Excluir o Produto !!!");
                }
            }
            else
            {
                MessageBox.Show("Campo ID não pode ser vazio");
            }
        }
    }
}
