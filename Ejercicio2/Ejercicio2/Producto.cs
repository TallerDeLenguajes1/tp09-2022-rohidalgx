using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    public class Producto
    {
        public string? nombre { get; set; }
        public DateOnly fechavencimiento { get; set; }
        public float precio { get; set; } //entre 1000 y 5000;
        public string? tamanio { get; set; }
    }
}
