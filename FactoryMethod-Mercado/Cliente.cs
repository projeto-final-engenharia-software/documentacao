using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_Mercado
{
    public abstract class Cliente
    {
        protected string Name { get; set; }
        protected string Address;
        protected string Phone;

        public string MostrarDadosCliente() 
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nome:" + Name);
            sb.AppendLine("Endereco:" + Address);
            sb.AppendLine("Telefone:" + Phone);

            return sb.ToString();
        }

    }
}
