using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroProduto.Model
{
    public class Produtos
    {
        private string descricao;
        private int quant;
        private float valor;

        public void SetDescricao( string descricao)
        {
            this.descricao = descricao;
        }

        public string GetDescricao()
        {
            return this.descricao;
        }

        public void SetQuant(int quant)
        {
            this.quant = quant;
        }

        public int GetQuant()
        {
            return this.quant;
        }

        public void SetValor(float valor)
        {
            this.valor = valor;
        }

        public float GetValor()
        {
            return this.valor;
        }

    }
}
