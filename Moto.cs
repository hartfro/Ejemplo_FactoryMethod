using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AC_Modelado_FactoryMethod
{
    internal class Moto : Vehiculo
    {
        public override int kilometrosPorHora() // máximo
        {
            return 120;
        }
    }
}
