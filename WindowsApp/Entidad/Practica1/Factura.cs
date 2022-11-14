using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsApp.Entidad.Practica1;

namespace WindowsApp.Entidad
{
    public class Factura : DcumentoComercial
    {
        public string Tipo { get; set; }
        public string Cliente { get; set; }
    }
}
