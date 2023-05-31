using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_Mercado
{
    public class ClienteSimpleFactory
    {
        public static ClienteFactoryMethod CreateClientByLocal(string local)
        {
            ClienteFactoryMethod cliente;
            switch (local)
            {
                case "BR":
                    cliente = new ClienteFactoryLocal();
                    break;
                case "EUA":
                    cliente = new ClienteFactoryEUA();
                    break;
                default:
                    throw new Exception("Local invalido");
            }
            return cliente;

        }
    }
}
