using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AC_Modelado_FactoryMethod
{
    internal class Auto : Vehiculo
    {
        public override int kilometrosPorHora()
        {
            return 150;
        }
    }
}
