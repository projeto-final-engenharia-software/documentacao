using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_Mercado
{
    //Concrete Creator
    public class ClienteFactoryLocal : ClienteFactoryMethod
    {
        protected override Cliente CreateCliente(string tipo)
        {
            if (tipo.Equals("F")) // F - Fisica
            {
                return new PFCliente();
            }
            if (tipo.Equals("E")) // E - Empresa
            {
                return new PJCliente();
            }
            else return null;
        }
    }
}
