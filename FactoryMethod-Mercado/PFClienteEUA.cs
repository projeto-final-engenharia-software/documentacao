using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_Mercado
{
    public class PFClienteEUA : Cliente
    {
        public PFClienteEUA()
        {
            Name = "Thomas";
            Phone = "99999999";
            Address = "Rua dos bobos";

        }
    }
}
