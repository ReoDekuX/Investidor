using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investidor.Model
{
    internal class Comprar
    {
        private static int id_Comprar;
        private static DateTime data_Comprar;
        private static string tipo_Comprar;
        private static int qtd_Comprar;
        private static decimal preco_Comprar;
        private static decimal custos_Comprar;
        private static string ativo_Comprar;
        private static decimal valortotal_Comprar;

        public static int Id_Comprar { get => id_Comprar; set => id_Comprar = value; }
        public static DateTime Data_Comprar { get => data_Comprar; set => data_Comprar = value; }
        public static string Tipo_Comprar { get => tipo_Comprar; set => tipo_Comprar = value; }
        public static int Qtd_Comprar { get => qtd_Comprar; set => qtd_Comprar = value; }
        public static decimal Preco_Comprar { get => preco_Comprar; set => preco_Comprar = value; }
        public static decimal Custos_Comprar { get => custos_Comprar; set => custos_Comprar = value; }
        public static string Ativo_Comprar { get => ativo_Comprar; set => ativo_Comprar = value; }
        public static decimal Valortotal_Comprar { get => valortotal_Comprar; set => valortotal_Comprar = value; }
    }
}
