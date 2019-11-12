using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroProduto.Model
{
    public class Produtos
    {
        private String descricao;
        private int quant, id;
        private float valor;

        public void setDescricao( String descricao)
        {
            this.descricao = descricao;
        }

        public String getDescricao()
        {
            return this.descricao;
        }

        public bool setQuant(int quant)
        {
            if (quant > 0)
            {
                this.quant = quant;
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public int getQuant()
        {
            return this.quant;
        }

        public bool setValor(float valor)
        {
            if (valor > 0) 
            { 
            this.valor = valor;
                return true;
            }
            else
            {
                return false;
            }
        }

        public float getValor()
        {
            return this.valor;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public int getId()
        {
            return this.id;
        }
    }
}
