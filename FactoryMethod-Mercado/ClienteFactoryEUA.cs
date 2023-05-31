using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_Mercado
{
    public class ClienteFactoryEUA : ClienteFactoryMethod
    {
        protected override Cliente CreateCliente(string tipo)
        {
            if (tipo.Equals("F")) // F - Fisica
            {
                return new PFClienteEUA();
            }
            if (tipo.Equals("E")) // E - Empresa
            {
                return new PJClienteEUA();
            }
            else return null;
        }
    }
}
