using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_Mercado
{
    public abstract class ClienteFactoryMethod
    {
        public Cliente MontaCliente(string tipo)
        {
            Cliente product;
            product = CreateCliente(tipo);
            return product;
        }
        protected abstract Cliente CreateCliente(string tipo);
    }
}
