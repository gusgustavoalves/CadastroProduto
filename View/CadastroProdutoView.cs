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
            Control.ProdutosC cpro = new Control.ProdutosC();
            Model.Produtos pro = new Model.Produtos();
            Dao.ProdutoDao dao = new Dao.ProdutoDao();

            if (txtDescricao.Text != "" && txtQuantidade.Text != "" && txtValorUnitario.Text != "")
            {
                pro.SetDescricao(Convert.ToString(txtDescricao.Text));
                pro.SetQuant(Convert.ToInt32(txtQuantidade.Text));
                pro.SetValor(float.Parse(txtValorUnitario.Text));                
                dao.CadastraProduto();
            }
            else
            {
                MessageBox.Show("Campos não podem ser vazios");
            }
        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {

        }
    }
}
