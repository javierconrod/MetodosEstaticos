using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodosEstaticos
{
    class matematicas
    {
        public static int Potencia(int numeroBase, int exponente)
        {
            int resultado = 1;
            if (exponente != 0)
            {
                for (int i = 0; i < exponente; i++)
                {
                    resultado *= numeroBase;
                }
            }
            return resultado;
        }
    }
}
