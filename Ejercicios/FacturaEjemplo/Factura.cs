using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturaEjemplo
{
    public class Factura
    {
        double[,] Fact = new double[10, 3];

        public Factura() 
        { 
        
        }

        public Factura(double [,] Fact)
        {
            this.Fact = Fact;
        }

        public void setFact(double [,]Fact)
        {
            this.Fact=Fact;
        }
    }
}
