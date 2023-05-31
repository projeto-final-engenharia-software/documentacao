using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_Mercado
{
    public class PJCliente : Cliente
    {
        public PJCliente()
        {
            Name = "Empresa Exemplo";
            Phone = "8888888";
            Address = "Rua das empresas";
        }
    }
}
