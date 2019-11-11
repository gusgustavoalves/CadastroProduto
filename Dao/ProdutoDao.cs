using CadastroProduto.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroProduto.Dao
{
    public class ProdutoDao
    {
        Dao.Conexao Con = new Dao.Conexao();
        public void CadastraProduto()
        {
            Model.Produtos pro = new Model.Produtos();
            MessageBox.Show(pro.GetDescricao());
            if (!Con.Checkconection())
            {
                Con.Conectar();
            }

            if (Con.Checkconection())
            {
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand("INSERT INTO produto (descricao, quantidade, valor) VALUES (@desc, @quant, @val)", Con.Traz_Conexao());
                command.Parameters.Add("@desc", MySqlDbType.VarChar, 45).Value = pro.GetDescricao();
                command.Parameters.Add("@quant", MySqlDbType.Int32, 11).Value = pro.GetQuant();
                command.Parameters.Add("@val", MySqlDbType.Float).Value = pro.GetValor();
                command.ExecuteNonQuery();

                Con.Desconectar();
            }

        }
    }
}
