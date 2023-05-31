using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FactoryMethod_Mercado
{
    public class PJClienteEUA : Cliente
    {
        public PJClienteEUA()
        {
            Name = "Empresa EUA Exemplo";
            Phone = "8888888";
            Address = "Street das empresas";
        }
    }
}
