using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investidor.Model
{
    internal class Conexao
    {
        public static string Conectar()
        {

            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\giovanni.rvieira\source\repos\Investidor\Investidor\Dados\Investidor.mdf;Integrated Security=True";

        }
    }
}

