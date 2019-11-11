using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroProduto.Control
{
    public class ProdutosC
    {
        public bool CadastraProduto(String desc, int quant, float val)
        {
            Model.Produtos pro = new Model.Produtos();
            Dao.ProdutoDao daopro = new Dao.ProdutoDao();
            pro.setDescricao(desc);

            if(pro.setQuant(quant) && pro.setValor(val))
            {
                daopro.CadastraProduto(pro);
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
