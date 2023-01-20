using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilidadCarro
{
    public class CarroUtilidad
    {
        double[,] utilidad = new double[3, 5];

        public CarroUtilidad(double[,] utilidad)
        {
            this.utilidad = utilidad;
        }

        public void setUtilidad(double[,] utilidad)
        {
            this.utilidad = utilidad;
        }

    }
}
