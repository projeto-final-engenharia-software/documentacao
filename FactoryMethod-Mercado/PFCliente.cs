using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_Mercado
{
    public class PFCliente : Cliente
    {
        public PFCliente()
        {
            Name = "Claudio";
            Phone = "99999999";
            Address = "Rua dos bobos";

        }
    }
}
