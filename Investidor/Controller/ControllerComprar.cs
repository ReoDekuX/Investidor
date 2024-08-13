using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Investidor.Model;

namespace Investidor.Controller
{
    internal class ControllerComprar
    {
        public void CadastrarComprar()
        {

            {
                SqlConnection cn = new SqlConnection(Conexao.Conectar());
                SqlCommand cmd = new SqlCommand("PCadastrarComprar", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                try
                {
                    cmd.Parameters.AddWithValue("@codigo", Comprar.Id_Comprar);
                    cmd.Parameters.AddWithValue("@Data_Comprar", Comprar.Data_Comprar);
                    cmd.Parameters.AddWithValue("@Tipo_Comprar", Comprar.Tipo_Comprar);
                    cmd.Parameters.AddWithValue("@Qtd_Comprar", Comprar.Qtd_Comprar);
                    cmd.Parameters.AddWithValue("@Preco_Comprar", Comprar.Preco_Comprar);
                    cmd.Parameters.AddWithValue("@Custos_Comprar", Comprar.Custos_Comprar);
                    cmd.Parameters.AddWithValue("@Ativo_Comprar", Comprar.Ativo_Comprar);
                    cmd.Parameters.AddWithValue("@ValorTotal_Comprar", Comprar.Valortotal_Comprar);

                    cn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registros Cadastrados com Sucesso.");
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
    }
}

