using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea_1_Aplicada2.Data
{
    public class Variables
    {
        public float Numero1 { get; set; }
        public float Numero2 { get; set; }
        public float ResultadoSuma { get; set; }
        public float ResultadoResta { get; set; }
        public float ResultadoMultiplicacion { get; set; }


        public Variables()
        {
            Numero1 = 0.00f;
            Numero2 = 0.00f;
            ResultadoSuma = 0.00f;
            ResultadoResta = 0.00f;
            ResultadoMultiplicacion = 0.00f;

        }
    }
}

