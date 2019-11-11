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
    public class Conexao
    {

        MySqlConnection conexao = new MySqlConnection();
        private string statusbd;

        public string Statusbd { get => statusbd; set => statusbd = value; }

        public void Conectar()
        {
            try
            {
                conexao.ConnectionString = @"server = localhost; port = 3306; User Id = root; database = cadastro; password =";
                conexao.Open();
                //MessageBox.Show("Conectado com Sucesso !!!");
                //conexao.Close();
            }
            catch
            {
                MessageBox.Show("Erro de Conexao Com O Banco de Dados !!!!");
            }
        }

        public void Desconectar()
        {
            try
            {
                conexao.Close();
            }
            catch
            {
                MessageBox.Show("Erro de Fechamento de conexão com Banco de Dados !!!!");
            }
        }

        public bool Checkconection()
        {
            if (conexao.State == ConnectionState.Open)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public MySqlConnection Traz_Conexao()
        {
            return conexao;
        }
    }
}
