using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AC_Modelado_FactoryMethod
{
    public class Creador
    {
        public const int AUTO = 1;
        public const int MOTO = 2;

        public static Vehiculo CreadorVehiculo(int tipo)
        {
            switch (tipo)
            {
                case AUTO:
                    return new Auto();
                case MOTO:
                    return new Moto();
                default: return null;
            }


        }
    }
}
